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
    public partial class LocEditView : DialogView {
        public LocEditView() {
            InitializeComponent();
        }

        private void LocEditView_Load(object sender, EventArgs e) {
            wareGridEdit1.LoadData();
            areaGridEdit1.LoadData();

            if (EditMode == Web.Core.Enums.EnViewEditMode.Edit) {
                using (var db = new Database()) {
                    var loc = db.FirstOrDefault<t_location>(" where guid=@0",this.GuidKey);

                    wareGridEdit1.SetSelectedValue(db.FirstOrDefault<t_ware>(" where warename = @0", loc.WareName));
                    areaGridEdit1.SetSelectedValue(db.FirstOrDefault<t_area>(" where areaname = @0", loc.AreaName));
                    txtName.Text = loc.LocName;
                    txtCode.Text = loc.LocCode;
                    chk.Checked = loc.IsUsing;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (!dxValidationProvider1.Validate())
                return;

            using (var db = new Database()) {
                if (EditMode == Web.Core.Enums.EnViewEditMode.Edit) {
                    var kt = db.FirstOrDefault<t_location>("where locname=@0 and guid <> @1", txtName.Text,GuidKey);
                    if (null != kt) {
                        MsgBox.ShowMessage("提示", "库位名称已存在!");
                        txtName.Select();
                        return;
                    }

                    var et = db.FirstOrDefault<t_location>(" where guid=@0", this.GuidKey);
                    et.WareName = wareGridEdit1.GetSelectedValue().WareName;
                    et.WareCode = wareGridEdit1.GetSelectedValue().WareCode;
                    et.AreaName = areaGridEdit1.GetSelectedValue().AreaName;
                    et.AreaCode = areaGridEdit1.GetSelectedValue().AreaCode;
                    et.LocName = txtName.Text;
                    et.LocCode = txtCode.Text;
                    et.IsUsing = chk.Checked;
                    db.Save(et);
                } else {
                    var kt = db.FirstOrDefault<t_location>("where locname=@0", txtName.Text);
                    if (null != kt) {
                        MsgBox.ShowMessage("提示", "库位名称已存在!");
                        txtName.Select();
                        return;
                    }
                    var et = new t_location {
                        Guid= Guid.NewGuid(),
                        WareName = wareGridEdit1.GetSelectedValue().WareName,
                        WareCode = wareGridEdit1.GetSelectedValue().WareCode,
                        AreaName = areaGridEdit1.GetSelectedValue().AreaName,
                        AreaCode = areaGridEdit1.GetSelectedValue().AreaCode,
                        LocCode = txtCode.Text,
                        LocName = txtName.Text,
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
