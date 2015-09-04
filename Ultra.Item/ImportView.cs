using DbEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ultra.Controls.View;
using Ultra.Excel;
using Ultra.Web.Core.Common;
using Ultra.Surface.Extend;
using Ultra.Surface.Common;

namespace Ultra.Item {
    public partial class ImportView : ImportDataView {
        public ImportView() {
            InitializeComponent();
        }

        private void fileBrowser1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if (null == FieldsMapper)
                return;

            var filedlg = new OpenFileDialog();
            filedlg.Filter = this.FileFilter;
            if (filedlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                fileBrowser1.Text = filedlg.FileName;
                //读取文件数据
                var dlg = new DevExpress.Utils.WaitDialogForm("正在加载数据,请稍候...", "导入");
                try {
                    var ipitm = ExcelCommon.ReadXls<t_item>(fileBrowser1.Text, FieldsMapper);
                    this.GridControl.DataSource = ipitm;
                } catch (Exception) {

                    throw;
                } finally {
                    dlg.Close();
                }
            }
        }

        private bool ChkData(List<t_item> ds) {
            var bok = true;
            ds.ForEach(j => {
                j.Creator = this.CurUser;
                j.CreateDate = TimeSync.Default.CurrentSyncTime;
            });
            ds.Where(j => string.IsNullOrEmpty(j.ItemName)).ToList().ForEach(j => {
                j.Remark = "商品名称不能为空";
                bok = false;
            });
            ds.Where(j => string.IsNullOrEmpty(j.ItemNo)).ToList().ForEach(j => {
                j.Remark += " 商品编码不能为空";
                bok = false;
            });
            if (bok)
                ds.ForEach(j => j.Remark = string.Empty);
            GridControl.RefreshDataSource();
            btnImp.Enabled = bok;
            return bok;
        }

        private void btnChk_Click(object sender, EventArgs e) {
            var ipitm = GridControl.GetDataSource<t_item>();
            var bok = ChkData(ipitm);
            if (!bok) {
                MsgBox.ShowMessage("", "存在无效数据！");
                return;
            }
        }

        private void btnImp_Click(object sender, EventArgs e) {
            if (MsgBox.ShowYesNoMessage("", "确定要导入吗?") == System.Windows.Forms.DialogResult.No)
                return;
            var dlg = new DevExpress.Utils.WaitDialogForm("正在导入,请稍候...", "导入");
            try {
                var ds = GridControl.GetDataSource<t_item>();
                if (null == ds || ds.Count < 1)
                    return;
                //var gid = Guid.NewGuid();
                ds.ForEach(j => {
                    j.Guid = Guid.NewGuid();
                });

                //插入临时表

                //同步到正式表

            } catch (Exception) {

                throw;
            } finally {
                dlg.Close();
            }
            MsgBox.ShowMessage("", "导入已完成!");
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
