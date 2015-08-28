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
                new Ultra.Surface.Interfaces.PermitGridView(this.gvUnSub,"未提交"),
                new Ultra.Surface.Interfaces.PermitGridView(this.gvSubed,"已提交"),
                new Ultra.Surface.Interfaces.PermitGridView(this.gvPrinted,"已打印"),
                new Ultra.Surface.Interfaces.PermitGridView(this.gvOrder,"货物信息")
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
                    myBar.btnSubmit,
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
            myBar.btnSubmit.ItemClick += btnSubmit_ItemClick;
            myBar.btnInvalid.ItemClick += btnInvalid_ItemClick;
            myBar.btnModify.ItemClick += barBtnEdt_ItemClick;
            myBar.btnPrint.ItemClick += btnPrint_ItemClick;

            gvUnSub.FocusedRowChanged += gv_FocusedRowChanged;
            gvSubed.FocusedRowChanged += gv_FocusedRowChanged;
            gvPrinted.FocusedRowChanged += gv_FocusedRowChanged;

            tabMain_SelectedPageChanged(null, null);
        }

        void gv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view == null) return;
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
                case "已提交":
                    trds = gvSubed.GetSelectedDataSource<t_trade>();
                    if (trds == null || trds.Count < 1) return;
                    UpdatePrintData(trds);
                    DoPrint(trds);
                    break;
                case "已打印":
                    trds = gvPrinted.GetSelectedDataSource<t_trade>();
                    if (trds == null || trds.Count < 1) return;
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
                    //trd.DeliveryDateStr = (trd.DeliveryDate ?? TimeSync.Default.CurrentSyncTime).ToString("yyyy年MM月dd日");
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
            if (null == et) return;
            using (var db = new Database()) {
                db.Update<t_trade>(" set IsInvalid=1 where guid=@0", et.Guid);
            }
            gcUnSub.RemoveSelected();
        }

        void btnSubmit_ItemClick(object sender, ItemClickEventArgs e) {
            var et = gcUnSub.GetFocusedDataSource<t_trade>();
            if (null == et) return;

            if (MsgBox.ShowYesNoMessage("", "确定要提交此出货单?") == DialogResult.Yes) {
                using (var db = new Database()) {
                    try {
                        db.BeginTransaction();
                        db.Update<t_trade>(" set IsSubmit=1 where guid=@0", et.Guid);
                        db.Execute("exec p_tradeupdateinvt @0", et.Guid);
                        db.Execute(string.Format(Sql_UpdateMember, et.Guid.ToString()));
                        db.CompleteTransaction();
                    } catch (Exception) {
                        db.AbortTransaction();
                        throw;
                    }
                }
                gcUnSub.RemoveSelected();
            }
        }

        void barBtnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            switch (tabMain.SelectedTabPage.Text) {
                case "未提交":
                    this.gcUnSub.GridExportXls();
                    break;
                case "已提交":
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
                case "未提交":
                    using (var db = new Database()) {
                        gcUnSub.DataSource = db.Fetch<t_trade>(" where isnull(issubmit,0)=0 and isnull(IsPrint,0)=0 and isnull(isinvalid,0)=0");
                    }
                    break;
                case "已提交":
                    using (var db = new Database()) {
                        gcSubed.DataSource = db.Fetch<t_trade>(" where isnull(issubmit,0)=1 and isnull(IsPrint,0)=0 and isnull(isinvalid,0)=0");
                    }
                    break;
                case "已打印":
                    using (var db = new Database()) {
                        gcPrinted.DataSource = db.Fetch<t_trade>(" where isnull(issubmit,0)=1 and isnull(IsPrint,0)=1 and isnull(isinvalid,0)=0");
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
            if (null == et) return;
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
                case "未提交":
                    myBar.btnPrint.Enabled = false;
                    break;
                case "已提交":
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

        public string Sql_UpdateInventory { 
            get {
                return @"
declare @tb table(
	ItemName nvarchar(200) NULL,
	ItemNo nvarchar(50) NULL,
	Price decimal(18, 2) NOT NULL,
	PointFee decimal(18, 2) NOT NULL,
	OldQty int NOT NULL,
	NowQty int NOT NULL,
	ActionName nvarchar(200) NULL,
	ActionNo nvarchar(200) NULL)

;with t as (
select a.Guid,Delivery,ReceiverName,b.ItemNo,sum(b.Num) num,sum(Price) price,sum(PointFee) pointfee
 from t_trade a 
join t_order b on a.guid=b.tradeguid 
where a.guid in ('{0}')
group by b.ItemNo,a.ReceiverName,a.Delivery,a.Guid
)
update a set a.qty=a.qty-b.num
output deleted.ItemName,deleted.ItemNo,b.price,b.pointfee,deleted.Qty,inserted.Qty
,b.ReceiverName+b.Delivery,cast(b.Guid as nvarchar(50)) into @tb
from t_inventory a 
join t b on a.ItemNo=b.ItemNo

INSERT INTO dbo.t_inventorylog
(Guid,ItemName,ItemNo,Price,PointFee
,OldQty,NowQty,ActionName,ActionNo,CreateDate,Creator,IsUsing)
select newid(),ItemName,ItemNo,Price,PointFee
,OldQty,NowQty,ActionName,ActionNo,GETDATE(),'',1
from @tb";
            } 
        }

        public string Sql_UpdateMember {
            get {
                return @"
select  a.memberguid,a.receivername,a.Delivery,SUM(b.num) num,SUM(b.orderprice) price,SUM(orderpointfee) pointfee
into #trds from t_trade a 
join t_order b on a.guid=b.tradeguid 
where a.guid in ('{0}')
group by a.memberguid,a.receivername,a.Delivery


INSERT INTO t_pointfeelog
([Guid],RecvName,[Desc],PointFee,CurPointFee,RecvPointFee,Remark,CreateDate,Creator,IsUsing)
select NEWID(),a.receivername,Delivery+'+',pointfee
,case Delivery 
	when '报单款拿货' then b.CurPointFee
	when '二次拿货' then b.CurPointFee+a.pointfee
end
,case Delivery 
	when '报单款拿货' then b.RecvPointFee+a.pointfee
	when '二次拿货' then b.RecvPointFee
end
,'',GETDATE(),'Sys',1
from #trds a 
join t_member b on a.memberguid=b.guid

INSERT INTO t_balancelog
([Guid],RecvName,[Desc],Amount,CurBalance,RecvBalance,Remark,CreateDate,Creator,IsUsing)
select NEWID(),a.receivername,Delivery+'-',price
,case Delivery 
	when '报单款拿货' then b.CurBalance
	when '二次拿货' then b.CurBalance-a.price
end
,case Delivery 
	when '报单款拿货' then b.RecvBalance-a.price
	when '二次拿货' then b.RecvBalance
end
,'',GETDATE(),'Sys',1
   from #trds a 
join t_member b on a.memberguid=b.guid

update a set a.CurPointFee=case Delivery 
	when '报单款拿货' then a.CurPointFee
	when '二次拿货' then a.CurPointFee+b.pointfee
end
,a.RecvPointFee= case Delivery 
	when '报单款拿货' then a.RecvPointFee+b.pointfee
	when '二次拿货' then a.RecvPointFee
end
,a.CurBalance=case Delivery 
	when '报单款拿货' then a.CurBalance
	when '二次拿货' then a.CurBalance-b.price
end
,a.RecvBalance=case Delivery 
	when '报单款拿货' then a.RecvBalance-b.price
	when '二次拿货' then a.RecvBalance
end
from t_member a 
join #trds b on a.guid=b.memberguid

drop table #trds";
            }
        }
    }
}
