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
    public partial class AreaEditView : DialogView {
        public AreaEditView() {
            InitializeComponent();
        }

        private void AreaEditView_Load(object sender, EventArgs e) {
            if (EditMode == Web.Core.Enums.EnViewEditMode.Edit) {
                using (var db = new Database()) {
                    var area = db.FirstOrDefault<t_area>(" where guid=@0",this.GuidKey);
                    txtName.Text = area.AreaName;
                    txtCode.Text = area.AreaCode;
                    chk.Checked = area.IsUsing;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            using (var db = new Database()) {
                if (EditMode == Web.Core.Enums.EnViewEditMode.Edit) {
                    var kt = db.FirstOrDefault<t_area>("where areaname=@0 and guid <> @1", txtName.Text,GuidKey);
                    if (null != kt) {
                        MsgBox.ShowMessage("提示", "区域名称已存在!");
                        txtName.Select();
                        return;
                    }

                    var et = db.FirstOrDefault<t_area>(" where guid=@0", this.GuidKey);
                    et.AreaName = txtName.Text;
                    et.AreaCode = txtCode.Text;
                    et.IsUsing = chk.Checked;
                    db.Save(et);
                } else {
                    var kt = db.FirstOrDefault<t_area>("where areaname=@0", txtName.Text);
                    if (null != kt) {
                        MsgBox.ShowMessage("提示", "区域名称已存在!");
                        txtName.Select();
                        return;
                    }
                    var et = new t_area {
                        Guid= Guid.NewGuid(),
                        AreaName = txtCode.Text,
                        AreaCode = txtName.Text,
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
