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
using EmitMapper;

namespace Ultra.Member {
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
                    db.Save(new t_member() {
                        Guid = Guid.NewGuid(),
                        ReceiverNo  = txtReceiverNo.Text,
                        ReceiverName = txtReceiverName.Text,
                        CurBalance=spnCurBalance.Value,
                        CurPointFee=spnCurPointFee.Value,
                        RecvBalance=spnRecvBalance.Value,
                        RecvPointFee=spnRecvPointFee.Value,
                        ReceiverMobile=txtReceiverMobile.Text,
                        ReceiverAddress=txtReceiverAddress.Text,                        
                        CreateDate = TimeSync.Default.CurrentSyncTime,
                        Creator=this.CurUser,
                        IsUsing=chk.Checked,
                        Remark=txtRemark.Text
                    });
                }
            } else if (EditMode == Ultra.Web.Core.Enums.EnViewEditMode.Edit) {
                using (var db = new Database()) {
                    var et = db.FirstOrDefault<t_member>("where Guid=@0", GuidKey);
                    if (null != et) {
                        et.ReceiverNo  = txtReceiverNo.Text;
                        et.ReceiverName = txtReceiverName.Text;
                        et.CurBalance=spnCurBalance.Value;
                        et.CurPointFee=spnCurPointFee.Value;
                        et.RecvBalance=spnRecvBalance.Value;
                        et.RecvPointFee=spnRecvPointFee.Value;
                        et.ReceiverMobile=txtReceiverMobile.Text;
                        et.ReceiverAddress=txtReceiverAddress.Text;
                        et.IsUsing=chk.Checked;
                        et.Remark = txtRemark.Text;

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
                        var et = db.FirstOrDefault<t_member>("where Guid=@0", GuidKey);
                        if (null != et) {
                            txtReceiverNo.Text = et.ReceiverNo;
                            txtReceiverName.Text = et.ReceiverName;
                            txtReceiverMobile.Text = et.ReceiverMobile;
                            spnCurBalance.Value = et.CurBalance;
                            spnCurPointFee.Value = et.CurPointFee;
                            spnRecvBalance.Value = et.RecvBalance;
                            spnRecvPointFee.Value = et.RecvPointFee;
                            txtReceiverAddress.Text = et.ReceiverAddress;
                            txtRemark.Text = et.Remark;
                            chk.Checked = et.IsUsing;
                        }
                    } catch (Exception ex) {
                        throw ex;
                    }
                }
            }
        }
    }
}
