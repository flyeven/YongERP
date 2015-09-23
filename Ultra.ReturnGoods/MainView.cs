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

namespace Ultra.ReturnGoods {
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
                new Ultra.Surface.Interfaces.PermitGridView(this.gvUnAudit,"待审核"),
                new Ultra.Surface.Interfaces.PermitGridView(this.gvAudit,"已审核"),
                new Ultra.Surface.Interfaces.PermitGridView(this.gvInvalid,"已作废"),
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
            myBar.btnRefresh.ItemClick += btnRefresh_ItemClick;
            myBar.btnReView.ItemClick += btnReView_ItemClick;
            myBar.btnCreate.ItemClick += btnCreate_ItemClick;
            myBar.btnModify.ItemClick += btnModify_ItemClick;
            myBar.btnExport.ItemClick += btnExport_ItemClick;
            myBar.btnInvalid.ItemClick += btnInvalid_ItemClick;
        }

        void btnInvalid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            throw new NotImplementedException();
        }

        void btnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            throw new NotImplementedException();
        }

        void btnModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            throw new NotImplementedException();
        }

        void btnCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            var vw = new NewView();
            if (Lanucher.InitView(vw).ShowDialog() == System.Windows.Forms.DialogResult.OK) {

            }
        }

        void btnReView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            throw new NotImplementedException();
        }

        void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            
        }
    }
}
