using System;
using System.Collections.Generic;
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

    }


    public class Database
    {
        Conn Con { get; set; }

        string q = "";
        Script script;



        public Database(Conn Connection)
        {
            this.Con = Connection;
            script = new Script(Con);
        }


        public void Detach()
        {
            //single user. disconnect all
            q = string.Format("alter database [{0}] set single_user with rollback immediate", Con.Database);
            script.Run(q);

            q = string.Format("EXEC sp_detach_db '{0}', 'true';", Con.Database);
            script.Run(q);

        }

        public void Attach()
        {

            q = string.Format("CREATE DATABASE [{0}] ON (FILENAME = '{1}'),(FILENAME = '{2}') FOR ATTACH;  ", Con.Database, GetMDF(), GetLDF());
            script.Run(q);

            //set multi user
            q = string.Format("alter database [{0}] set MULTI_USER", Con.Database);
            script.Run(q);
        }

        private string GetMDF()
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

            return Utils.Clean(dt.Rows[0][1]);
        }

        private string GetLDF()
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

            return Utils.Clean(dt.Rows[0][1]);
        }


    }
}
