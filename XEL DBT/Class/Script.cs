using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEL_DBT
{
    public class Script
    {
        Conn con { get; set; }
        SqlConnection sqlCon;


        public Script(Conn Connection)
        {
            this.con = Connection;

            var s = string.Format("Data Source={0}; User ID='{1}'; Password='{2}'; Initial Catalog='{3}';", con.Server, con.Username, con.Password, con.Database);
            sqlCon = new SqlConnection(s);

        }


        public bool Run(string q)
        {
            try
            {
                if(sqlCon.State != ConnectionState.Open) sqlCon.Open();


                var cmd = new SqlCommand(q,sqlCon);
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                cmd.Dispose();
                return true;
            }
            catch(Exception ex)
            {
                XtraMsg.Error(ex.Message);
                return false;
            }
        }

        public DataTable Run(string q, string type)
        {
            var dt = new DataTable();
            var da = new SqlDataAdapter(q, sqlCon);
            da.Fill(dt);
            da.Dispose();
            sqlCon.Close();

            return dt;
        }


    }
}
