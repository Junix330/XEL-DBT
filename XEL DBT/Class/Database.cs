using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEL_DBT
{
    public class Conn
    {
        public string Server { get; set; }

        public string Database { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public bool Test()
        {
            var s = string.Format("Data Source={0}; User ID='{1}'; Password='{2}'; Initial Catalog='{3}';", Server, Username, Password, Database);
            var c = new SqlConnection(s);

            try
            {
                c.Open();
                if (c.State == System.Data.ConnectionState.Open)
                {
                    c.Close();
                    c.Dispose();
                    return true;
                }

                else
                {
                    c.Dispose();
                    return false;
                }

            }
            catch (Exception ex)
            {
                XtraMsg.Error(ex.Message);
                return false;
            }
        }


    }


    public class Database
    {
        Conn Con { get; set; }

        string q = "";
        Script script;

        public string PhysicalMDF { get; set; }

        public string PhysicalLDF { get; set; }


        public Database(Conn Connection)
        {
            this.Con = Connection;
            script = new Script(Con);
        }


        public bool Detach()
        {
            //single user. disconnect all

            q = string.Format("USE [master];", Con.Database);
            script.Run(q);

            q = string.Format("USE [master]; alter database [{0}] set single_user with rollback immediate; EXEC sp_detach_db '{0}', 'true';", Con.Database);
            script.Run(q);

            return true;
        }

        public bool Attach()
        {
            //var script = new Script();
            q = string.Format("CREATE DATABASE [{0}] ON (FILENAME = '{1}'),(FILENAME = '{2}') FOR ATTACH;  ", Con.Database, PhysicalMDF, PhysicalLDF);
            script.Run(q);


            //set multi user
            q = string.Format("alter database [{0}] set MULTI_USER", Con.Database);
            script.Run(q);

            return false;
        }

        public string GetMDF()
        {
            q = string.Format("SELECT type,physical_name FROM sys.database_files WHERE type=0");
            var dt = script.Run(q, "DT");
            if (dt == null)
            {
                XtraMsg.Error("DATABASE PHYSICAL DB FILE CANNOT BE FOUND!");
                return "";
            }

            if (dt.Rows.Count <= 0)
            {
                XtraMsg.Error("DATABASE PHYSICAL DB FILE CANNOT BE FOUND!");
                return "";
            }

            this.PhysicalMDF = Utils.Clean(dt.Rows[0][1]);

            return this.PhysicalMDF;
        }

        public string GetLDF()
        {
            q = string.Format("SELECT type,physical_name FROM sys.database_files WHERE type=1");
            var dt = script.Run(q, "DT");
            if (dt == null)
            {
                XtraMsg.Error("DATABASE PHYSICAL LOG FILE CANNOT BE FOUND!");
                return "";
            }

            if (dt.Rows.Count <= 0)
            {
                XtraMsg.Error("DATABASE PHYSICAL LOG FILE CANNOT BE FOUND!");
                return "";
            }


            this.PhysicalLDF = Utils.Clean(dt.Rows[0][1]);

            return this.PhysicalLDF;
        }


    }
}
