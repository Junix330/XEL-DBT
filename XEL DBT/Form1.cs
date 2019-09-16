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
    public partial class Form1 : MaterialForm
    {
        MaterialSkinManager sman;


        public Form1()
        {
            sman = MaterialSkinManager.Instance;
            sman.AddFormToManage(this);
            sman.Theme = MaterialSkinManager.Themes.LIGHT;
            sman.ColorScheme = new ColorScheme(Primary.DeepOrange600, Primary.DeepOrange700, Primary.DeepOrange200, Accent.Red100, TextShade.WHITE);


            InitializeComponent();
        }
    }
}
