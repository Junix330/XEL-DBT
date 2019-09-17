using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XEL_DBT
{
    public partial class frmMain : MaterialForm
    {
        Conn con;
        Database db;
        MaterialSkinManager sman;
        




        public frmMain()
        {
            sman = MaterialSkinManager.Instance;
            sman.AddFormToManage(this);
            sman.Theme = MaterialSkinManager.Themes.LIGHT;
            sman.ColorScheme = new ColorScheme(Primary.DeepOrange600, Primary.DeepOrange700, Primary.DeepOrange200, Accent.Red100, TextShade.WHITE);


            InitializeComponent();
        }


        private void BtnDetach_Click(object sender, EventArgs e)
        {
            if(db == null)
            {
                XtraMsg.Error("CONNECTION MUST ESTABLISTED FIRST!");
                return;
            }

            txtMdfLoc.Text = db.GetMDF();
            txtLdfLoc.Text = db.GetLDF();

            db.Detach();
        }

        private void BtnAttach_Click(object sender, EventArgs e)
        {
            if (db == null)
            {
                XtraMsg.Error("CONNECTION MUST ESTABLISTED FIRST!");
                return;
            }

            db.Attach();
        }

        private void Form_Shown(object sender, EventArgs e)
        {
      

        }

        private void BtnConn_Click(object sender, EventArgs e)
        {
            con = new Conn();
            con.Database = txtDb.Text;
            con.Server = txtServer.Text;
            con.Username = txtUser.Text;
            con.Password = txtPass.Text;

            if (!con.Test())
            {
                XtraMsg.Warn("CANT CONNECT TO SERVER!");
                return;
            }
            else
            {
                XtraMsg.Info("CONNECTED TO SERVER!");
            }

            db = new Database(con);
        }
    }
}
