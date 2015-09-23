using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetaPoco;
using Ultra.Surface.Common;
using Ultra.Surface.Form;
using Ultra.Web.Core.Common;
using DbEntity;
using Ultra.Surface.Extend;

namespace Ultra.ReturnGoods {
    public partial class NewView : DialogView {

        private t_trade Trade;

        public NewView() {
            InitializeComponent();
        }

        private void NewView_Load(object sender, EventArgs e) {

        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (!dxValidationProvider1.Validate())
                return;
            var odrs = gcOrder.GetDataSource<t_order>();
            if (odrs == null || odrs.Count < 1) {
                MsgBox.ShowMessage("提示", "没有添加商品不能保存!");
                return;
            }
            if (EditMode == Ultra.Web.Core.Enums.EnViewEditMode.New) {
                var trdnew = new t_trade() {
                    Guid = GuidKey,
                    ReceiverName = Trade.ReceiverName,
                    ReceiverMobile = Trade.ReceiverMobile,
                    ReceiverAddress = Trade.ReceiverAddress,
                    MemberGuid = Trade.Guid,
                    DeliveryDate = dateDeliveryDate.DateTime,
                    CreateDate = TimeSync.Default.CurrentSyncTime,
                    Creator = this.CurUser,
                };

                using (var db = new Database()) {
                    try {
                        db.BeginTransaction();
                        db.Save(trdnew);
                        odrs.ForEach(k => db.Save(k));
                        db.CompleteTransaction();
                    } catch (Exception) {
                        db.AbortTransaction();
                        throw;
                    }
                }
            } else if (EditMode == Ultra.Web.Core.Enums.EnViewEditMode.Edit) {
                using (var db = new Database()) {
                    var trd = db.FirstOrDefault<t_trade>(" where guid=@0", GuidKey);
                    trd.ReceiverName = Trade.ReceiverName;
                    trd.ReceiverMobile = txtMobile.Text;
                    trd.ReceiverAddress = txtReceiverAddress.Text;
                    trd.MemberGuid = Trade.Guid;
                    trd.DeliveryDate = TimeSync.Default.CurrentSyncTime;
                    trd.DeliveryDate = dateDeliveryDate.DateTime;
                    try {
                        db.BeginTransaction();
                        db.Save(trd);
                        db.Execute("delete t_order where tradeguid=@0", trd.Guid);
                        odrs.ForEach(k => {
                            k.Id = 0;
                            db.Save(k);
                        });
                        db.CompleteTransaction();
                    } catch (Exception) {
                        db.AbortTransaction();
                        throw;
                    }
                }
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void btnAddOrder_Click(object sender, EventArgs e) {
            var odrs = gcOrder.GetDataSource<t_order>();
            odrs = odrs ?? new List<t_order>();

            var newodr = new t_order();
            newodr.TradeGuid = this.GuidKey;
            newodr.CreateDate = TimeSync.Default.CurrentSyncTime;
            newodr.Creator = this.CurUser;
            odrs.Add(newodr);
            gcOrder.DataSource = odrs;
            gcOrder.RefreshDataSource();
        }

        private void btnDelOrder_Click(object sender, EventArgs e) {
            gcOrder.RemoveSelected();
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
            var odr = gcOrder.GetFocusedDataSource<t_order>();
            if (odr == null)
                return;

            odr.ItemGuid = item.Guid;
            odr.ItemName = item.ItemName;
            odr.ItemNo = item.ItemNo;
            odr.CostPrice = item.CostPrice;
            odr.Price = item.Price;
            odr.Num = 1;
            odr.OrderPrice = item.Price;

            gcOrder.RefreshDataSource();
        }

        private void rspNum_EditValueChanged(object sender, EventArgs e) {
            var odr = gcOrder.GetFocusedDataSource<t_order>();
            if (odr == null)
                return;
            var spn = sender as DevExpress.XtraEditors.SpinEdit;
            odr.Num = (int)spn.Value;
            odr.OrderPrice = odr.Price * odr.Num;
            gcOrder.RefreshDataSource();
        }

        private void txtMemberName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            var vw = new SendedTradeView();
            if (vw.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                this.Trade = vw.Trade;

                dateDeliveryDate.DateTime = this.Trade.DeliveryDate ?? DateTime.Now;
                txtMobile.Text = this.Trade.ReceiverMobile;
                txtReceiverAddress.Text = this.Trade.ReceiverAddress;

                using (var db = new Database()) {
                    gcOrder.DataSource = db.Fetch<t_order>("select * from t_order");
                }
            }
        }
    }
}
