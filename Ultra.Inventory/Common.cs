using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ultra.Surface.Lanuch;
using Ultra.Web.Core.Common;

namespace Ultra.Inventory {
    public class Common {
        public static string GetSerialNo(string dep) {
            var dt=SqlHelper.ExecuteDataTable(Lanucher.ConnectonString, CommandType.StoredProcedure, "p_getserialno"
                , new SqlParameter("@Dep", dep));

            return dt.Rows[0]["SerialNo"] == null ? string.Empty : dt.Rows[0]["SerialNo"].ToString();
        }
    }
}
