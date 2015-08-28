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

namespace Ultra.Trade {
    public partial class NewView : DialogView {
        public NewView() {
            InitializeComponent();
        }

        private void NewView_Load(object sender, EventArgs e) {
            memgcEdt.LoadData();
            dateDeliveryDate.DateTime = TimeSync.Default.CurrentSyncTime;

            using (var db = new Database()) {
                rspItem.DataSource = db.Fetch<t_item>(" where isnull(isusing,0)=1 ");

                if (EditMode == Ultra.Web.Core.Enums.EnViewEditMode.New) {
                    GuidKey = Guid.NewGuid();
                } else {
                    var trd = db.FirstOrDefault<t_trade>(" where guid=@0", GuidKey);
                    memgcEdt.SetSelectedValue(db.FirstOrDefault<t_member>(" where guid=@0", trd.MemberGuid));
                    txtMobile.Text = trd.ReceiverMobile;
                    txtReceiverAddress.Text = trd.ReceiverAddress;
                    cmbDelivery.SelectedItem = trd.Delivery.ToString();
                    txtPeriods.Text = trd.Periods;
                    dateDeliveryDate.DateTime = trd.DeliveryDate ?? TimeSync.Default.CurrentSyncTime;
                    gcOrder.DataSource = db.Fetch<t_order>(" where tradeguid=@0",GuidKey);
                }
            }
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
                    ReceiverName = memgcEdt.GetSelectedValue().ReceiverName,
                    ReceiverMobile = memgcEdt.GetSelectedValue().ReceiverMobile,
                    ReceiverAddress = memgcEdt.GetSelectedValue().ReceiverAddress,
                    Delivery = cmbDelivery.SelectedItem.ToString(),
                    MemberGuid = memgcEdt.GetSelectedValue().Guid,
                    DeliveryDate = dateDeliveryDate.DateTime,
                    Periods=txtPeriods.Text,
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
                    trd.ReceiverName = memgcEdt.GetSelectedValue().ReceiverName;
                    trd.ReceiverMobile = txtMobile.Text;
                    trd.ReceiverAddress = txtReceiverAddress.Text;
                    trd.MemberGuid = memgcEdt.GetSelectedValue().Guid;
                    trd.Delivery = cmbDelivery.SelectedItem.ToString();
                    trd.DeliveryDate = TimeSync.Default.CurrentSyncTime;
                    trd.DeliveryDate = dateDeliveryDate.DateTime;
                    trd.Periods = txtPeriods.Text;
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
            if (gl == null) return;
            var view = gl.Properties.View;
            if (view == null) return;
            var item = view.GetFocusedDataSource<t_item>();
            if (item == null) return;
            var odr = gcOrder.GetFocusedDataSource<t_order>();
            if (odr == null) return;

            odr.ItemGuid = item.Guid;
            odr.ItemName = item.ItemName;
            odr.ItemNo = item.ItemNo;
            odr.Price = item.Price;
            odr.PointFee = item.PointFee;
            odr.Num = 1;
            odr.OrderPrice = item.Price;
            odr.OrderPointFee = item.PointFee;

            gcOrder.RefreshDataSource();
        }

        private void rspNum_EditValueChanged(object sender, EventArgs e) {
            var odr = gcOrder.GetFocusedDataSource<t_order>();
            if (odr == null) return;
            var spn = sender as DevExpress.XtraEditors.SpinEdit;
            odr.Num = (int)spn.Value;
            odr.OrderPrice = odr.Price * odr.Num;
            odr.OrderPointFee = odr.PointFee * odr.Num;
            gcOrder.RefreshDataSource();
        }

        private void cmbDelivery_EditValueChanged(object sender, EventArgs e) {
            var odrs = gcOrder.GetDataSource<t_order>();
            if (odrs == null || odrs.Count < 1) return;
            switch (cmbDelivery.SelectedItem.ToString()) {
                case "报单款拿货":
                    odrs.ForEach(k => {
                        k.PointFee *= 2;
                        k.Price *= 2;
                        k.OrderPrice = k.Price * k.Num;
                        k.OrderPointFee = k.PointFee * k.Num;
                    });
                    break;
                case "二次拿货":
                    odrs.ForEach(k => {
                        k.PointFee /= 2;
                        k.Price /= 2;
                        k.OrderPrice = k.Price * k.Num;
                        k.OrderPointFee = k.PointFee * k.Num;
                    });
                    break;
                default:
                    break;
            }
            gcOrder.RefreshDataSource();
        }

        private void memgcEdt_EditValueChanged(object sender, EventArgs e) {
            var mem = memgcEdt.GetSelectedValue();
            if (mem == null) return;
            txtMobile.Text = mem.ReceiverMobile;
            txtReceiverAddress.Text = mem.ReceiverAddress;
        }
    }
}
