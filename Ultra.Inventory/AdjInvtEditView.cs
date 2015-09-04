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
using Ultra.Surface.Extend;
using Ultra.Web.Core.Common;
using Ultra.Surface.Common;

namespace Ultra.Inventory {
    public partial class AdjInvtEditView : DialogView {

        public t_adjinvt AdjInvt { get; set; }
        public string AdjInvtNo { get; set; }

        public AdjInvtEditView() {
            InitializeComponent();
        }

        private void AdjustInvetEditView_Load(object sender, EventArgs e) {
            gcItem.RowCellDoubleClick += gcItem_RowCellDoubleClick;

            AdjInvtNo = Common.GetSerialNo("库存调整单");
            GuidKey = Guid.NewGuid();
            txtAdjInvtNo.Text = AdjInvtNo;
            //生成调整单号
            using (var db = new Database()) {
                rspLoc.DataSource = db.Fetch<t_location>(" where isusing=1");
                rspItem.DataSource = db.Fetch<t_item>(" where isusing=1");
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e) {
            var odrs = gcItem.GetDataSource<t_adjinvtitem>();
            odrs = odrs ?? new List<t_adjinvtitem>();

            var newodr = new t_adjinvtitem();
            newodr.Guid = Guid.NewGuid();
            newodr.AdjInvtNo = AdjInvtNo;
            newodr.CreateDate = TimeSync.Default.CurrentSyncTime;
            newodr.Creator = this.CurUser;
            newodr.NowQty = 1;
            odrs.Add(newodr);
            gcItem.DataSource = odrs;
            gcItem.RefreshDataSource();
        }

        private void btnDelOrder_Click(object sender, EventArgs e) {
            gcItem.RemoveSelected();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            var items = gcItem.GetDataSource<t_adjinvtitem>();
            if (items == null || items.Count < 1) {
                MsgBox.ShowMessage("", "没有商品信息,不能保存!");
                return;
            }

            AdjInvt = new t_adjinvt();
            AdjInvt.Guid = GuidKey;
            AdjInvt.AdjInvtNo = AdjInvtNo;
            AdjInvt.Creator = this.CurUser;
            AdjInvt.AuditDate = AdjInvt.CreateDate = TimeSync.Default.CurrentSyncTime;
            AdjInvt.Num = items.Sum(k => Math.Abs(k.OldQty - k.NowQty));
            AdjInvt.Remark = txtRemark.Text;

            using (var db = new Database()) {
                try {
                    db.BeginTransaction();
                    db.Save(AdjInvt);
                    items.ForEach(k => db.Save(k));

                    db.CompleteTransaction();
                } catch (Exception) {
                    db.AbortTransaction();
                    throw;
                }
            }


            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        void gcItem_RowCellDoubleClick(object sender, MouseEventArgs e) {
            gcItem.RemoveSelected();
        }

        private void rspNowQty_EditValueChanged(object sender, EventArgs e) {
            var odr = gcItem.GetFocusedDataSource<t_adjinvtitem>();
            if (odr == null)
                return;
            var spn = sender as DevExpress.XtraEditors.SpinEdit;
            odr.NowQty = (int)spn.Value;
        }

        private void rspLoc_EditValueChanged(object sender, EventArgs e) {
            var et = gcItem.GetFocusedDataSource<t_adjinvtitem>();
            if (et == null)
                return;
            var rsp = sender as DevExpress.XtraEditors.GridLookUpEdit;

            var view = rsp.Properties.View;
            if (view == null)
                return;

            var loc = view.GetFocusedDataSource<t_location>();
            if (loc == null)
                return;

            et.WareName = loc.WareName;
            et.AreaName = loc.AreaName;
            et.LocName = loc.LocName;

            gcItem.RefreshDataSource();
        }

        private void rspItem_EditValueChanged(object sender, EventArgs e) {
            var gl = sender as DevExpress.XtraEditors.GridLookUpEdit;
            if (gl == null)
                return;
            var view = gl.Properties.View;
            if (view == null)
                return;
            var item = view.GetFocusedDataSource<t_item>();
            if (item == null)
                return;
            var odr = gcItem.GetFocusedDataSource<t_adjinvtitem>();
            if (odr == null)
                return;

            odr.ItemName = item.ItemName;
            odr.ItemNo = item.ItemNo;
            odr.CostPrice = item.CostPrice;
            odr.NowQty = 1;

            gcItem.RefreshDataSource();
        }
    }
}
