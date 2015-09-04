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
using Ultra.Surface.Common;
using Ultra.Surface.Form;
using Ultra.Web.Core.Common;

namespace Ultra.Inventory {
    public partial class WareEditView : DialogView {
        public WareEditView() {
            InitializeComponent();
        }

        private void WareEditView_Load(object sender, EventArgs e) {
            if (EditMode == Web.Core.Enums.EnViewEditMode.Edit) {
                using (var db = new Database()) {
                    var ware = db.FirstOrDefault<t_ware>(" where guid=@0",this.GuidKey);
                    txtName.Text = ware.WareName;
                    txtCode.Text = ware.WareCode;
                    chk.Checked = ware.IsUsing;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            using (var db = new Database()) {
                if (EditMode == Web.Core.Enums.EnViewEditMode.Edit) {
                    var kt = db.FirstOrDefault<t_ware>("where warename=@0 and guid <> @1", txtName.Text,GuidKey);
                    if (null != kt) {
                        MsgBox.ShowMessage("提示", "仓库名称已存在!");
                        txtName.Select();
                        return;
                    }

                    var et = db.FirstOrDefault<t_ware>(" where guid=@0", this.GuidKey);
                    et.WareName = txtName.Text;
                    et.WareCode = txtCode.Text;
                    et.IsUsing = chk.Checked;
                    db.Save(et);
                } else {
                    var kt = db.FirstOrDefault<t_ware>("where warename=@0", txtName.Text);
                    if (null != kt) {
                        MsgBox.ShowMessage("提示", "仓库名称已存在!");
                        txtName.Select();
                        return;
                    }
                    var et = new t_ware {
                        Guid= Guid.NewGuid(),
                        WareCode = txtCode.Text,
                        WareName = txtName.Text,
                        IsUsing = chk.Checked,
                        Creator=this.CurUser,
                        CreateDate=TimeSync.Default.CurrentSyncTime
                    };
                    db.Save(et);
                }
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
