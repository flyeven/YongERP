using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ultra.Surface.Form;
using Ultra.Surface.Lanuch;
using Ultra.Surface.Extend;
using Ultra.Surface.Common;
using Ultra.Web.Core.Common;
using DbEntity;
using System.Data.SqlClient;
using PetaPoco;

namespace Ultra.Inventory {
    public partial class AdjInvtView : BaseForm, Ultra.Surface.Interfaces.ISurfacePermission {
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
                    new Ultra.Surface.Interfaces.PermitGridView(this.gvUnAudit,"待审核"),
                    new Ultra.Surface.Interfaces.PermitGridView(this.gvAudit,"已审核"),
                    new Ultra.Surface.Interfaces.PermitGridView(this.gvInvalid,"已作废")
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
                    myBar.btnRefresh,
                    myBar.btnReView,
                    myBar.btnCreate,
                    myBar.btnExport,
                    myBar.btnInvalid
                };
            }
        }

        #endregion
        public AdjInvtView() {
            InitializeComponent();
        }

        private void AdjustInventoryView_Load(object sender, EventArgs e) {
            myBar.btnReView.ItemClick += btnReView_ItemClick;
            myBar.btnRefresh.ItemClick += btnRefresh_ItemClick;
            myBar.btnExport.ItemClick += btnExport_ItemClick;
            myBar.btnCreate.ItemClick += btnCreate_ItemClick;
            myBar.btnInvalid.ItemClick += btnInvalid_ItemClick;

            gvUnAudit.FocusedRowChanged += gv_FocusedRowChanged;
            gvAudit.FocusedRowChanged += gv_FocusedRowChanged;
            gvInvalid.FocusedRowChanged += gv_FocusedRowChanged;
        }

        void btnInvalid_ItemClick(object sender, ItemClickEventArgs e) {
            var et = gcUnAudit.GetFocusedDataSource<t_adjinvt>();
            if (et == null)
                return;
            using (var db = new Database()) {
                db.Execute(" update t_adjinvt set isinvalid=1 where adjinvtno=@0",et.AdjInvtNo);
            }
            gcUnAudit.RemoveSelected();
        }

        void btnCreate_ItemClick(object sender, ItemClickEventArgs e) {
            var vw = new AdjInvtEditView();
            vw.EditMode = Web.Core.Enums.EnViewEditMode.New;
            if (Lanucher.InitView(vw).ShowDialog() == DialogResult.OK) {
                btnRefresh_ItemClick(null, null);
            }
        }

        void btnExport_ItemClick(object sender, ItemClickEventArgs e) {
            gcOrder.GridExportXls();
        }

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e) {
            switch (tabMain.SelectedTabPage.Text) {
                case "待审核":
                    using (var db = new Database()) {
                        gcUnAudit.DataSource = db.Fetch<t_adjinvt>(" where isnull(isaudit,0)=0 and isnull(isinvalid,0)=0");
                    }
                    break;
                case "已审核":
                    using (var db = new Database()) {
                        gcAudit.DataSource = db.Fetch<t_adjinvt>(" where isnull(isaudit,0)=1 and isnull(isinvalid,0)=0");
                    }
                    break;
                case "已作废":
                    using (var db = new Database()) {
                        gcInvalid.DataSource = db.Fetch<t_adjinvt>(" where isnull(isinvalid,0)=1");
                    }
                    break;
                default:
                    break;
            }
        }

        void btnReView_ItemClick(object sender, ItemClickEventArgs e) {
            var et = gcUnAudit.GetFocusedDataSource<t_adjinvt>();
            if (et == null)
                return;
            using (var db = new Database()) {
                try {
                    db.BeginTransaction();
                    db.Execute(" update t_adjinvt set isaudit=1,auditdate=getdate() where AdjInvtNo=@0", et.AdjInvtNo);
                    //更新库存
                    db.Execute("exec p_adjinvtupdateinvt @0,@1", et.AdjInvtNo,this.CurUser);
                    db.CompleteTransaction();
                    gcUnAudit.RemoveSelected();
                } catch (Exception) {
                    db.AbortTransaction();
                    throw;
                }
            }
        }

        public string Sql_UpdateInventory {
            get {
                return @"
--更新存在的商品库存
;with t as 
(
	select a.AdjInvtNo,b.[ItemName],b.ItemNo,b.CostPrice,b.NowQty,b.Creator from t_adjinvt a 
	join t_adjinvtitem b on a.AdjInvtNo=b.AdjInvtNo
)
update a set a.qty=b.NowQty
from [t_inventory] a 
join t b on a.ItemNo=b.itemno
where b.AdjInvtNo=@0

";
            }
        }

        private void tabMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            myBar.btnCreate.Enabled =
                    myBar.btnRefresh.Enabled =
                    myBar.btnExport.Enabled =
                    myBar.btnReView.Enabled =
                    myBar.btnInvalid.Enabled = true;
            switch (tabMain.SelectedTabPage.Text) {
                case "待审核":
                    break;
                case "已审核":
                    myBar.btnCreate.Enabled =
                    myBar.btnReView.Enabled =
                    myBar.btnInvalid.Enabled = false;
                    break;
                case "已作废":
                    myBar.btnCreate.Enabled =
                    myBar.btnReView.Enabled =
                    myBar.btnInvalid.Enabled = false;
                    break;
                default:
                    break;
            }
            btnRefresh_ItemClick(null, null);
        }

        private void gv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            var gv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gv == null)
                return;

            var et = gv.GetFocusedDataSource<t_adjinvt>();
            if (et == null) {
                gcOrder.DataSource = null;
                return;
            }

            using (var db = new Database()) {
                gcOrder.DataSource = db.Fetch<t_adjinvtitem>(" where AdjInvtNo=@0", et.AdjInvtNo);
            }
        }
    }
}
