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
using DevExpress.XtraBars;

namespace Ultra.Inventory {
    public partial class InStockView : BaseForm, Ultra.Surface.Interfaces.ISurfacePermission {
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
                    myBar.btnModify,
                    myBar.btnCreate,
                    myBar.btnExport,
                    myBar.btnInvalid
                };
            }
        }

        #endregion
        public InStockView() {
            InitializeComponent();
        }

        private void InStockView_Load(object sender, EventArgs e) {
            myBar.btnReView.ItemClick += btnReView_ItemClick;
            myBar.btnRefresh.ItemClick += btnRefresh_ItemClick;
            myBar.btnExport.ItemClick += btnExport_ItemClick;
            myBar.btnCreate.ItemClick += btnCreate_ItemClick;
            myBar.btnModify.ItemClick += btnModify_ItemClick;
            myBar.btnInvalid.ItemClick += btnInvalid_ItemClick;

            gvUnAudit.FocusedRowChanged += gv_FocusedRowChanged;
            gvAudit.FocusedRowChanged += gv_FocusedRowChanged;
            gvInvalid.FocusedRowChanged += gv_FocusedRowChanged;
        }

        void btnInvalid_ItemClick(object sender, ItemClickEventArgs e) {
            var et = gcUnAudit.GetFocusedDataSource<t_instock>();
            if (et == null)
                return;
            using (var db = new Database()) {
                db.Execute(" update t_instock set isinvalid=1 where InStockNo=@0", et.InStockNo);
            }
            gcUnAudit.RemoveSelected();
        }

        void btnModify_ItemClick(object sender, ItemClickEventArgs e) {
            var et = gcUnAudit.GetFocusedDataSource<t_instock>();
            if (et == null)
                return;
            var vw = new InStockEditView();
            vw.EditMode = Web.Core.Enums.EnViewEditMode.Edit;
            vw.InStock = et;
            if (Lanucher.InitView(vw).ShowDialog() == DialogResult.OK) {
                btnRefresh_ItemClick(null, null);
            }
        }

        void btnCreate_ItemClick(object sender, ItemClickEventArgs e) {
            var vw = new InStockEditView();
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
                        gcUnAudit.DataSource = db.Fetch<t_instock>(" where isnull(isaudit,0)=0 and isnull(isinvalid,0)=0");
                    }
                    break;
                case "已审核":
                    using (var db = new Database()) {
                        gcAudit.DataSource = db.Fetch<t_instock>(" where isnull(isaudit,0)=1 and isnull(isinvalid,0)=0");
                    }
                    break;
                case "已作废":
                    using (var db = new Database()) {
                        gcInvalid.DataSource = db.Fetch<t_instock>(" where isnull(isinvalid,0)=1");
                    }
                    break;
                default:
                    break;
            }
        }

        void btnReView_ItemClick(object sender, ItemClickEventArgs e) {
            var et=gcUnAudit.GetFocusedDataSource<t_instock>();
            if (et == null)
                return;
            using (var db = new Database()) {
                try {
                    db.BeginTransaction();
                    db.Execute(" update t_instock set isaudit=1,auditdate=getdate() where instockno=@0", et.InStockNo);
                    //更新库存
                    db.Execute("exec p_instockupdateinvt @0", et.InStockNo);
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
declare @tb table(
	ItemName nvarchar(200) NULL,
	ItemNo nvarchar(50) NULL,
	Price decimal(18, 2) NOT NULL,
	PointFee decimal(18, 2) NOT NULL,
	OldQty int NOT NULL,
	NowQty int NOT NULL,
	ActionName nvarchar(200) NULL,
	ActionNo nvarchar(200) NULL)


--更新存在的商品库存
;with t as 
(
	select a.instockno,b.[ItemName],b.ItemNo,b.CostPrice,b.Num,b.Creator from t_instock a 
	join t_instockitem b on a.instockno=b.instockno
)
update a set a.qty=a.qty+b.num
output deleted.ItemName,deleted.ItemNo,0,0,deleted.Qty,inserted.Qty
,'货物入库',b.InStockNo into @tb
from [t_inventory] a 
join t b on a.ItemNo=b.itemno
where b.instockno=@0


--插入中没有的商品库存
INSERT INTO [dbo].[t_inventory]
([ItemName],[ItemNo],[CostPrice],[Qty],[Creator],[IsUsing])
output inserted.ItemName,inserted.ItemNo,0,0,0,inserted.Qty
,'货物入库',@0 into @tb
select b.[ItemName],b.ItemNo,b.CostPrice,b.Num,b.Creator,1 from t_instock a 
join t_instockitem b on a.instockno=b.instockno
left join [t_inventory] c on b.itemno=c.itemno
where c.id is null and a.instockno=@0

INSERT INTO dbo.t_inventorylog
(Guid,ItemName,ItemNo,Price,PointFee
,OldQty,NowQty,ActionName,ActionNo,CreateDate,Creator,IsUsing)
select newid(),ItemName,ItemNo,Price,PointFee
,OldQty,NowQty,ActionName,ActionNo,GETDATE(),'',1
from @tb

"; 
            }        
        }

        private void tabMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            myBar.btnCreate.Enabled =
                    myBar.btnModify.Enabled =
                    myBar.btnRefresh.Enabled =
                    myBar.btnExport.Enabled =
                    myBar.btnReView.Enabled =
                    myBar.btnInvalid.Enabled =true;
            switch (tabMain.SelectedTabPage.Text) {
                case "待审核":
                    break;
                case "已审核":
                    myBar.btnCreate.Enabled =
                    myBar.btnModify.Enabled =
                    myBar.btnReView.Enabled =
                    myBar.btnInvalid.Enabled = false;
                    break;
                case "已作废":
                    myBar.btnCreate.Enabled =
                    myBar.btnModify.Enabled =
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

            var et = gv.GetFocusedDataSource<t_instock>();
            if (et == null) {
                gcOrder.DataSource = null;
                return;
            }

            using (var db = new Database()) {
                gcOrder.DataSource= db.Fetch<t_instockitem>(" where instockno=@0",et.InStockNo);
            }
        }
    }
}
