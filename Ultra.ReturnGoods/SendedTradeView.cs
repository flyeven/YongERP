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

namespace Ultra.ReturnGoods {
    public partial class SendedTradeView : DialogView {
        public t_trade Trade { get; set; }

        public SendedTradeView() {
            InitializeComponent();
        }

        private void SendedTradeView_Load(object sender, EventArgs e) {
            using (var db = new Database()) {
                gc.DataSource = db.Fetch<t_trade>(" where isaudit=1");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            Trade = gc.GetFocusedDataSource<t_trade>();
            if (Trade == null)
                return;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
