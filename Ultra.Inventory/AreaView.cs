using DbEntity;
using PetaPoco;
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
using Ultra.Web.Core.Common;
using Ultra.Surface.Extend;
using Ultra.Surface.Common;

namespace Ultra.Inventory {
    public partial class AreaView :  BaseForm , Ultra.Surface.Interfaces.ISurfacePermission {
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
                    new Ultra.Surface.Interfaces.PermitGridView(this.gv,"区域")
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
                    myBar.btnModify,
                    myBar.btnCreate,
                    myBar.btnExport,
                    myBar.btnUnUsing,
                    myBar.btnUsing
                };
            }
        }

        #endregion

        public AreaView() {
            InitializeComponent();
        }

        private void AreaView_Load(object sender, EventArgs e) {
            myBar.btnRefresh.ItemClick += btnRefresh_ItemClick;
            myBar.btnModify.ItemClick += btnModify_ItemClick;
            myBar.btnCreate.ItemClick += btnCreate_ItemClick;
            myBar.btnExport.ItemClick += btnExport_ItemClick;
            myBar.btnUnUsing.ItemClick += btnUnUsing_ItemClick;
            myBar.btnUsing.ItemClick += btnUsing_ItemClick;
        }

        void btnUsing_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            var et = gc.GetFocusedDataSource<t_area>();
            if (et == null)
                return;
            using (var db = new Database()) {
                db.Execute("update t_area set isusing=1 where guid = @0 ", et.Guid);
                btnRefresh_ItemClick(null, null);
            }
        }

        void btnUnUsing_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            var et = gc.GetFocusedDataSource<t_area>();
            if (et == null)
                return;
            using (var db = new Database()) {
                db.Execute("update t_area set isusing=0 where guid = @0 ",et.Guid);
                btnRefresh_ItemClick(null, null);
            }
        }

        void btnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            gc.GridExportXls();
        }

        void btnCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            var vw = new AreaEditView();
            vw.EditMode = Web.Core.Enums.EnViewEditMode.New;
            if (Lanucher.InitView(vw).ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                btnRefresh_ItemClick(null, null);
            }
        }

        void btnModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            var et = gc.GetFocusedDataSource<t_area>();
            if (et == null)
                return;
            var vw = new AreaEditView();
            vw.EditMode = Web.Core.Enums.EnViewEditMode.Edit;
            vw.GuidKey = et.Guid;
            if (Lanucher.InitView(vw).ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                btnRefresh_ItemClick(null, null);
            }
        }

        void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            using (var db = new Database()) {
                gc.DataSource = db.Fetch<t_area>(string.Empty);
            }
        }
    }
}
