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
using Soma_XML.Entities;

namespace Soma_XML
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent(); 
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple600, Primary.DeepPurple600, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            materialRaisedButton1.BackColor = Color.Purple;
            labelMoeda.ForeColor = Color.Red;
            labelRS.ForeColor = Color.Red;
            gridXMLS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridXMLS.AutoResizeColumns();
            gridXMLS.BackgroundColor = Color.RebeccaPurple;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            XML.Ler_Arquivos(gridXMLS, labelRS);
        }
    }
}
