using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEL_DBT
{
    public class Script
    {
        Conn Con { get; set; }

        public Script(Conn Connection)
        {
            this.Con = Connection;
        }


        public bool Run(string q)
        {
          


            return true;
        }


    }
}
