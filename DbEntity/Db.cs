using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PetaPoco
{
    public partial class Database
    {
        //public Database(string connectionString, bool ismysql)
        //{
        //    _connectionString = connectionString;
        //    _providerName = ismysql ? "MySql.Data.MySqlClient" : "System.Data.SqlClient";
        //    CommonConstruct();
        //}

        public Database()//:this(true,Apex.Surmnt.Common.DbConnection.ConnectionString)
        {
            string connectionString = string.Empty;
            try
            {
                connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbconstr"].ConnectionString;
            }
            catch (Exception)
            {
#if DEBUG
                connectionString = @"server=113.105.237.98,4908\mssql2012;uid=sa;pwd=1qaz2wsx;database=erp_power";
#else
                connectionString = string.Empty;
#endif
            }
            _connectionString = connectionString;
            //_providerName = true ? "System.Data.SqlClient" : "MySql.Data.MySqlClient";
            _providerName ="System.Data.SqlClient";
            CommonConstruct();
        }


        public DataTable ExecuteDataTable(string sql, params object[] args) {
            DataTable dt = new DataTable();
            OpenSharedConnection();
            try {
                using (var cmd = CreateCommand(_sharedConnection, sql, args)) {
                    using (DbDataAdapter dbDataAdapter = _factory.CreateDataAdapter()) {
                        dbDataAdapter.SelectCommand = (DbCommand)cmd;
                        dbDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            } catch (Exception x) {
                OnException(x);
                throw;
            } finally {
                CloseSharedConnection();
            }
        }
    }

    public partial class DbController {
        public string ConnStr { get; set; }

        private Database _Db { get; set; }

        protected virtual Database Db {
            get {
                return _Db = _Db ?? new PetaPoco.Database(ConnStr);
            }
        }

        public DbController() {
            ConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["dbconstr"].ConnectionString;//Ultra.Surface.Lanuch.Lanucher.ConnectonString;
        }

        public DbController(string con) {
            ConnStr = con;
        }
    }
}
