using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace XEL_DBT
{
    public partial class frmMain : MaterialForm
    {

        MaterialSkinManager materialSkinManager;


        public frmMain()
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);


        }



   

        private async void fLaunch_Shown(object sender, EventArgs e)
        {
            
        }

       

   



        private void fLaunch_Load(object sender, EventArgs e)
        {
            
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
