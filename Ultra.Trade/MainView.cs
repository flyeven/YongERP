using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ultra.Surface.Form;
using Ultra.Surface.Lanuch;
using Ultra.Surface.Extend;
using Ultra.Surface.Common;
using Ultra.Web.Core.Common;
using DbEntity;
using System.Data.SqlClient;
using PetaPoco;
using DevExpress.XtraBars;
using DevExpress.XtraPrinting;

namespace Ultra.Trade {
    public partial class MainView : BaseForm, Ultra.Surface.Interfaces.ISurfacePermission {
        #region ISurfacePermission 成员

        public List<Control> ButtonItems {
            get;
            set;
        }

        public List<BaseSurface> DialogForms {
            get;
            set;
        }

        public List<Ultra.Surface.Interfaces.PermitGridView> Grids {
            get {
                return new List<Ultra.Surface.Interfaces.PermitGridView> { 
                new Ultra.Surface.Interfaces.PermitGridView(this.gvUnSub,"待审核"),
                new Ultra.Surface.Interfaces.PermitGridView(this.gvSubed,"已审核"),
                new Ultra.Surface.Interfaces.PermitGridView(this.gvPrinted,"已打印"),
                new Ultra.Surface.Interfaces.PermitGridView(this.gvOrder,"商品信息")
            };
            }
        }

        public List<Control> MenuItems {
            get;
            set;
        }

        public List<DevExpress.XtraBars.BarButtonItem> ToolBarItems {
            get {
                return new List<DevExpress.XtraBars.BarButtonItem> { 
                    myBar.btnCreate,
                    myBar.btnModify,
                    myBar.btnRefresh,
                    myBar.btnExport,
                    myBar.btnReView,
                    myBar.btnInvalid,
                    myBar.btnPrint
                };
            }
        }

        #endregion

        public MainView() {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e) {
            myBar.btnCreate.ItemClick += barBtnNew_ItemClick;
            myBar.btnRefresh.ItemClick += barBtnRefresh_ItemClick;
            myBar.btnExport.ItemClick += barBtnExport_ItemClick;
            myBar.btnInvalid.ItemClick += btnInvalid_ItemClick;
            myBar.btnModify.ItemClick += barBtnEdt_ItemClick;
            myBar.btnPrint.ItemClick += btnPrint_ItemClick;
            myBar.btnReView.ItemClick += btnReView_ItemClick;

            gvUnSub.FocusedRowChanged += gv_FocusedRowChanged;
            gvSubed.FocusedRowChanged += gv_FocusedRowChanged;
            gvPrinted.FocusedRowChanged += gv_FocusedRowChanged;

            tabMain_SelectedPageChanged(null, null);
        }

        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnReView_ItemClick(object sender, ItemClickEventArgs e) {
            var et = gcUnSub.GetFocusedDataSource<t_trade>();
            if (null == et)
                return;

            if (MsgBox.ShowYesNoMessage("", "确定要审核此出货单?") == DialogResult.Yes) {
                using (var db = new Database()) {
                    try {
                        var result = new SqlParameter() {
                            Direction = ParameterDirection.Output,
                            SqlDbType = SqlDbType.Bit,
                            ParameterName = "@result"
                        };
                        db.BeginTransaction();
                        db.Update<t_trade>(" set IsAudit=1 where guid=@0", et.Guid);
                        db.Execute("exec p_tradeupdateinvt @0,@1 output", et.Guid, result);

                        if (!(bool)result.Value) {
                            MsgBox.ShowMessage("", "库存不足!");
                            db.AbortTransaction();
                        } else {
                            db.CompleteTransaction();
                            gcUnSub.RemoveSelected();
                        }
                    } catch (Exception) {
                        db.AbortTransaction();
                        throw;
                    }
                }
            }
        }

        void gv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view == null)
                return;
            var trd = view.GetFocusedDataSource<t_trade>();
            if (trd == null) {
                gcOrder.DataSource = null;
                return;
            }
            using (var db = new Database()) {
                gcOrder.DataSource = db.Fetch<t_order>(" where tradeguid=@0", trd.Guid);
            }
        }

        void btnPrint_ItemClick(object sender, ItemClickEventArgs e) {
            var trds = new List<t_trade>();
            switch (tabMain.SelectedTabPage.Text) {
                case "已审核":
                    trds = gvSubed.GetSelectedDataSource<t_trade>();
                    if (trds == null || trds.Count < 1)
                        return;
                    UpdatePrintData(trds);
                    DoPrint(trds);
                    break;
                case "已打印":
                    trds = gvPrinted.GetSelectedDataSource<t_trade>();
                    if (trds == null || trds.Count < 1)
                        return;
                    UpdatePrintCnt(trds);
                    DoPrint(trds);
                    break;
                default:
                    break;
            }

            barBtnRefresh_ItemClick(sender, e);
        }

        private void UpdatePrintCnt(List<t_trade> trds) {
            var whr = trds.Select(k => k.Guid.ToString()).Aggregate((s1, s2) => s1 + "','" + s2);
            using (var db = new Database()) {
                db.Update<t_trade>(string.Format(" set printcnt=isnull(printcnt,0)+1 where guid in ('{0}')", whr));
            }
        }

        private void UpdatePrintData(List<t_trade> trds) {
            var whr = trds.Select(k => k.Guid.ToString()).Aggregate((s1, s2) => s1 + "','" + s2);
            using (var db = new Database()) {
                try {
                    db.Update<t_trade>(string.Format(" set isprint=1,printcnt=isnull(printcnt,0)+1 where guid in ('{0}')", whr));
                } catch (Exception) {
                    throw;
                }
            }
        }

        private static void DoPrint(List<t_trade> trds) {
            var ps = new PrintingSystem();
            ps.Document.Pages.Clear();
            ps.ShowMarginsWarning = false;
            ps.ClearContent();

            var whr = trds.Select(k => k.Guid.ToString()).Aggregate((s1, s2) => s1 + "','" + s2);
            using (var db = new Database()) {
                var vtrds = db.Fetch<t_trade>(string.Format(" where guid in ('{0}')", whr));
                var orders = db.Fetch<t_order>(string.Format(" where tradeguid in ('{0}')", whr));
                vtrds.ForEach(trd => {
                    var prtinfo = new PrintInfo();
                    prtinfo.Trade = trd;
                    prtinfo.Orders = orders.Where(odr => odr.TradeGuid == trd.Guid).ToList();
                    var rptfh = new rptFH();
                    rptfh.BindPrintData(prtinfo);
                    rptfh.CreateDocument();

                    ps.Document.Pages.AddRange(rptfh.Pages);
                });
            }

            ps.Print();
        }

        void btnInvalid_ItemClick(object sender, ItemClickEventArgs e) {
            var et = gcUnSub.GetFocusedDataSource<t_trade>();
            if (null == et)
                return;
            using (var db = new Database()) {
                db.Update<t_trade>(" set IsInvalid=1 where guid=@0", et.Guid);
            }
            gcUnSub.RemoveSelected();
        }

        void barBtnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            switch (tabMain.SelectedTabPage.Text) {
                case "待审核":
                    this.gcUnSub.GridExportXls();
                    break;
                case "已审核":
                    this.gcSubed.GridExportXls();
                    break;
                case "已打印":
                    this.gcPrinted.GridExportXls();
                    break;
                default:
                    break;
            }
        }

        void barBtnEdt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            gridControlEx1_RowCellDoubleClick(sender, null);
        }

        void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            switch (tabMain.SelectedTabPage.Text) {
                case "待审核":
                    using (var db = new Database()) {
                        gcUnSub.DataSource = db.Fetch<t_trade>(" where isnull(IsAudit,0)=0 and isnull(IsPrint,0)=0 and isnull(isinvalid,0)=0");
                    }
                    break;
                case "已审核":
                    using (var db = new Database()) {
                        gcSubed.DataSource = db.Fetch<t_trade>(" where isnull(IsAudit,0)=1 and isnull(IsPrint,0)=0 and isnull(isinvalid,0)=0");
                    }
                    break;
                case "已打印":
                    using (var db = new Database()) {
                        gcPrinted.DataSource = db.Fetch<t_trade>(" where isnull(IsAudit,0)=1 and isnull(IsPrint,0)=1 and isnull(isinvalid,0)=0");
                    }
                    break;
                default:
                    break;
            }
        }

        void barBtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            var vw = new NewView();
            Lanucher.InitView(vw);
            vw.EditMode = Ultra.Web.Core.Enums.EnViewEditMode.New;
            if (vw.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                barBtnRefresh_ItemClick(sender, e);
            }
        }

        private void gridControlEx1_RowCellDoubleClick(object sender, MouseEventArgs e) {
            var et = gcUnSub.GetFocusedDataSource<t_trade>();
            if (null == et)
                return;
            var vw = new NewView();
            Lanucher.InitView(vw);
            vw.EditMode = Ultra.Web.Core.Enums.EnViewEditMode.Edit;
            vw.GuidKey = et.Guid;
            if (vw.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                barBtnRefresh_ItemClick(sender, null);
        }

        private void tabMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            myBar.btnCreate.Enabled =
                    myBar.btnModify.Enabled =
                    myBar.btnRefresh.Enabled =
                    myBar.btnExport.Enabled =
                    myBar.btnSubmit.Enabled =
                    myBar.btnInvalid.Enabled =
                    myBar.btnPrint.Enabled = true;
            switch (tabMain.SelectedTabPage.Text) {
                case "待审核":
                    myBar.btnPrint.Enabled = false;
                    break;
                case "已审核":
                    myBar.btnCreate.Enabled =
                    myBar.btnModify.Enabled =
                    myBar.btnSubmit.Enabled =
                    myBar.btnInvalid.Enabled = false;
                    break;
                case "已打印":
                    myBar.btnCreate.Enabled =
                    myBar.btnModify.Enabled =
                    myBar.btnSubmit.Enabled =
                    myBar.btnInvalid.Enabled = false;
                    break;
                default:
                    break;
            }
            barBtnRefresh_ItemClick(null, null);
        }
    }
}
