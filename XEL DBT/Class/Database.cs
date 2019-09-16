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



        public Database(Conn Connection)
        {
            this.Con = Connection;
        }


        public void Detach()
        {
            var s = new Script(Con);
            //single user. disconnect all
            q = string.Format("alter database [{0}] set single_user with rollback immediate", Con.Database);
            s.Run(q);

            q = string.Format("EXEC sp_detach_db '{0}', 'true';", Con.Database);
            s.Run(q);

        }

        public void Attach()
        {
            var s = new Script(Con);
            q = string.Format("CREATE DATABASE [{0}] ON (FILENAME = '{1}'),(FILENAME = '{2}') FOR ATTACH;  ", Con.Database, GetMDF(), GetLDF());
            s.Run(q);

            //set multi user
            q = string.Format("alter database [{0}] set MULTI_USER", Con.Database);
            s.Run(q);
        }

        private string GetMDF()
        {

            return "";
        }

        private string GetLDF()
        {

            return "";
        }


    }
}
