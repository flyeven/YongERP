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
    public partial class InStockEditView : DialogView {

        public t_instock InStock { get; set; }
        public string InStockNo { get; set; }

        public InStockEditView() {
            InitializeComponent();
        }

        private void InStockEditView_Load(object sender, EventArgs e) {
            //生成入库单号
            using (var db = new Database()) {
                rspItem.DataSource = db.Fetch<t_item>(" where isnull(isusing,0)=1 ");

                if (EditMode == Ultra.Web.Core.Enums.EnViewEditMode.New) {
                    InStockNo = Common.GetSerialNo("入库单");
                    GuidKey = Guid.NewGuid();
                    txtInStockNo.Text = InStockNo;
                } else {
                    txtInStockNo.Text= InStockNo = InStock.InStockNo;
                    txtOuterNo.Text = InStock.OuterNo;
                    gcOrder.DataSource = db.Fetch<t_instockitem>(" where instockno=@0", InStock.InStockNo);
                }
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e) {
            var odrs = gcOrder.GetDataSource<t_instockitem>();
            odrs = odrs ?? new List<t_instockitem>();

            var newodr = new t_instockitem();
            newodr.Guid = Guid.NewGuid();
            newodr.InStockNo = InStockNo;
            newodr.CreateDate = TimeSync.Default.CurrentSyncTime;
            newodr.Creator = this.CurUser;
            odrs.Add(newodr);
            gcOrder.DataSource = odrs;
            gcOrder.RefreshDataSource();
        }

        private void btnDelOrder_Click(object sender, EventArgs e) {
            gcOrder.RemoveSelected();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            var items=gcOrder.GetDataSource<t_instockitem>();
            if (items == null || items.Count < 1) {
                MsgBox.ShowMessage("","没有商品信息,不能保存!");
                return;
            }
            if(items.Any(K=> string.IsNullOrEmpty(K.ItemNo))){
                MsgBox.ShowMessage("","商品信息不完整!");
                return;
            }

            if (EditMode == Web.Core.Enums.EnViewEditMode.Edit) {
                using (var db = new Database()) {
                    try {
                        db.BeginTransaction();
                        db.Execute("delete t_instockitem where instockno=@0",InStockNo);
                        InStock.Remark = txtRemark.Text;
                        InStock.Num = items.Sum(k => k.Num);
                        InStock.OuterNo = txtOuterNo.Text;
                        db.Save(InStock);
                        items.ForEach(k => { k.Id = 0; db.Save(k); });
                        
                        db.CompleteTransaction();
                    } catch (Exception) {
                        db.AbortTransaction();
                        throw;
                    }
                }
            } else {

                InStock = new t_instock();
                InStock.Remark = txtRemark.Text;
                InStock.Guid = GuidKey;
                InStock.InStockNo = InStockNo;
                InStock.OuterNo = txtOuterNo.Text;
                InStock.Creator = this.CurUser;
                InStock.AuditDate= InStock.CreateDate = TimeSync.Default.CurrentSyncTime;
                InStock.Num = items.Sum(k => k.Num);

                using (var db = new Database()) {
                    try {
                        db.BeginTransaction();
                        db.Save(InStock);
                        items.ForEach(k=>db.Save(k));
                        
                        db.CompleteTransaction();
                    } catch (Exception) {
                        db.AbortTransaction();
                        throw;
                    }
                }

            }


            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
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
            var odr = gcOrder.GetFocusedDataSource<t_instockitem>();
            if (odr == null)
                return;

            var odrs = gcOrder.GetDataSource<t_instockitem>();
            if(odrs.Any(k=>k.ItemNo==item.ItemNo && k.Guid!=odr.Guid)){
                MsgBox.ShowMessage("","不能添加同样的货物,同样的货物增加数量即可!");
                return;
            }

            odr.ItemName = item.ItemName;
            odr.ItemNo = item.ItemNo;
            odr.CostPrice = 0;
            odr.Num = 1;

            gcOrder.RefreshDataSource();
        }

        private void rspNum_EditValueChanged(object sender, EventArgs e) {
            var odr = gcOrder.GetFocusedDataSource<t_instockitem>();
            if (odr == null)
                return;
            var spn = sender as DevExpress.XtraEditors.SpinEdit;
            odr.Num = (int)spn.Value;
        }
    }
}
