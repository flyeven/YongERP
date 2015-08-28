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

namespace Ultra.Inventory {
    public partial class InventoryView : BaseForm, Ultra.Surface.Interfaces.ISurfacePermission {
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
                    new Ultra.Surface.Interfaces.PermitGridView(this.gvInvt,"库存查询"),
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
                    myBar.btnExport,
                };
            }
        }

        #endregion
        public InventoryView() {
            InitializeComponent();
        }

        private void InventoryView_Load(object sender, EventArgs e) {
            myBar.btnRefresh.ItemClick += btnRefresh_ItemClick;
            myBar.btnExport.ItemClick += btnExport_ItemClick;
        }

        void btnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            gcInvt.GridExportXls();
        }

        void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            using (var db = new Database()) {
                gcInvt.DataSource = db.Fetch<t_inventory>(" select * from t_inventory");
            }
        }
    }
}
