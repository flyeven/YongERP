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
            gcFromOrder.RowCellDoubleClick += gcFromOrder_RowCellDoubleClick;
            gcToOrder.RowCellDoubleClick += gcToOrder_RowCellDoubleClick;

            AdjInvtNo = Common.GetSerialNo("库存调整单");
            GuidKey = Guid.NewGuid();
            txtAdjInvtNo.Text = AdjInvtNo;
            //生成调整单号
            using (var db = new Database()) {
                gcFromOrder.DataSource = db.Fetch<t_inventory>(" select * from t_inventory");
            }
        }


        private void btnAddOrder_Click(object sender, EventArgs e) {
            var odrs = gcToOrder.GetDataSource<t_adjinvtitem>();
            odrs = odrs ?? new List<t_adjinvtitem>();

            var newodr = new t_adjinvtitem();
            newodr.Guid = Guid.NewGuid();
            newodr.AdjInvtNo = AdjInvtNo;
            newodr.CreateDate = TimeSync.Default.CurrentSyncTime;
            newodr.Creator = this.CurUser;
            odrs.Add(newodr);
            gcToOrder.DataSource = odrs;
            gcToOrder.RefreshDataSource();
        }

        private void btnDelOrder_Click(object sender, EventArgs e) {
            gcToOrder.RemoveSelected();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            var items=gcToOrder.GetDataSource<t_adjinvtitem>();
            if (items == null || items.Count < 1) {
                MsgBox.ShowMessage("","没有商品信息,不能保存!");
                return;
            }


                AdjInvt = new t_adjinvt();
                AdjInvt.Guid = GuidKey;
                AdjInvt.AdjInvtNo = AdjInvtNo;
                AdjInvt.Creator = this.CurUser;
                AdjInvt.AuditDate= AdjInvt.CreateDate = TimeSync.Default.CurrentSyncTime;
                AdjInvt.Num = items.Sum(k => Math.Abs(k.OldQty - k.NowQty));
                AdjInvt.Remark = txtRemark.Text;

                using (var db = new Database()) {
                    try {
                        db.BeginTransaction();
                        db.Save(AdjInvt);
                        items.ForEach(k=>db.Save(k));
                        
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

        void gcFromOrder_RowCellDoubleClick(object sender, MouseEventArgs e) {
            var odr = gcFromOrder.GetFocusedDataSource<t_inventory>();
            if (odr == null)
                return;

            var odrs = gcToOrder.GetDataSource<t_adjinvtitem>();
            odrs = odrs ?? new List<t_adjinvtitem>();

            if (odrs.Any(k => k.ItemNo == odr.ItemNo)) {
                return;
            }
            var toodr = new t_adjinvtitem() {
                Guid=Guid.NewGuid(),
                CreateDate=TimeSync.Default.CurrentSyncTime,
                AdjInvtNo=AdjInvtNo,
                CostPrice=odr.CostPrice,
                Creator=this.CurUser,
                IsUsing=true,
                ItemName=odr.ItemName,
                ItemNo=odr.ItemNo,
                OldQty=odr.Qty,
                NowQty=odr.Qty,
                Remark=string.Empty,
            };
            odrs.Add(toodr);
            gcToOrder.DataSource = odrs;
            gcToOrder.RefreshDataSource();

        }

        void gcToOrder_RowCellDoubleClick(object sender, MouseEventArgs e) {
            gcToOrder.RemoveSelected();
        }

        private void rspNowQty_EditValueChanged(object sender, EventArgs e) {
            var odr = gcToOrder.GetFocusedDataSource<t_adjinvtitem>();
            if (odr == null)
                return;
            var spn = sender as DevExpress.XtraEditors.SpinEdit;
            odr.NowQty = (int)spn.Value;
        }
    }
}
