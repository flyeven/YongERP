using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DbEntity;
using System.ComponentModel;
using System.Drawing.Design;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Drawing;
using Ultra.Surface.Controls;

namespace Ultra.Controls
{
    public class MemberGridEdit : EntityGridEdit<t_member>
    {
        protected override List<t_member> GetData()
        {
            using (var db = new PetaPoco.Database())
            {
                return db.Fetch<t_member>("where IsUsing=1");
            }
        }

        public override t_member GetSelectedValue()
        {
            if (base.EditValue == null || string.IsNullOrEmpty(base.EditValue.ToString())) return null;
            var ds = base.Properties.DataSource as List<t_member>;
            if (null == ds) return base.GetSelectedValue();
            return ds.Where(k => k.Guid ==Guid.Parse(base.EditValue.ToString())).SingleOrDefault();
        }

        public override t_member SetSelectedValue(t_member vl)
        {
            if (null == vl) return base.SetSelectedValue(vl);
            this.EditValue = vl.Guid;

            var kt = base.SetSelectedValue(vl);
            var ds = base.Properties.DataSource as List<t_member>;
            if (null != ds)
            {
                var mtch = ds.Where(k => k.Guid == kt.Guid).SingleOrDefault();
                if (null == mtch)
                    base.Properties.View.FocusedRowHandle = -99997;
            }
            return kt;
        }

        public MemberGridEdit()
            : base() {
            base.DisplayMember = "ReceiverName";
            base.ValueMember = "Guid";
        }
    } 

}
