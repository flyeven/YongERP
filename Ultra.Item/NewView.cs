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

namespace Ultra.Item {
    public partial class NewView : DialogView {
        public NewView() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (!dxValidationProvider1.Validate())
                return;
            if (EditMode == Ultra.Web.Core.Enums.EnViewEditMode.New) {
                using (var db = new Database()) {
                    var kt = db.FirstOrDefault<t_item>("select * from t_item where itemno=@0", txtItemNo.Text);
                    if (null != kt) {
                        MsgBox.ShowMessage("编码已存在", "编码已存在!");
                        txtItemNo.Select();
                        return;
                    }
                    db.Save(new t_item() {
                        Guid = Guid.NewGuid(),
                        ItemName  = txtItemName.Text,
                        ItemNo = txtItemNo.Text,
                        Price=spnPrice.Value,
                        PointFee=spnPointFee.Value,
                        CreateDate = TimeSync.Default.CurrentSyncTime,
                        Creator=this.CurUser,
                        IsUsing=chk.Checked,
                        Remark=string.Empty
                    });
                }
            } else if (EditMode == Ultra.Web.Core.Enums.EnViewEditMode.Edit) {
                using (var db = new Database()) {
                    var et = db.FirstOrDefault<t_item>("where Guid=@0", GuidKey);
                    if (null != et) {
                        et.ItemName = txtItemName.Text;
                        et.ItemNo = txtItemNo.Text;
                        et.Price=spnPrice.Value;
                        et.PointFee = spnPointFee.Value;
                        et.IsUsing=chk.Checked;
                        et.Remark = string.Empty;
                    }
                    db.Save(et);
                }
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void NewView_Load(object sender, EventArgs e) {
            if (EditMode == Ultra.Web.Core.Enums.EnViewEditMode.Edit) {
                using (var db = new Database()) {
                    try {
                        var et = db.FirstOrDefault<t_item>("where Guid=@0", GuidKey);
                        if (null != et) {
                            txtItemName.Text = et.ItemName;
                            txtItemNo.Text = et.ItemNo;
                            spnPrice.Value = et.Price;
                            spnPointFee.Value = et.PointFee;
                            chk.Checked = et.IsUsing;
                        }
                    } catch (Exception ex) {
                        throw ex;
                    }
                }
                txtItemName.Properties.ReadOnly = true;
            }
        }
    }
}
