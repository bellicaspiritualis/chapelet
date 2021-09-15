using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Threading;

namespace chapelet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //string database_connection;
            //richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

            panelBttClose.Click += BorderStyle.PanelBttClose_Click;
            panelBttMin.Click += BorderStyle.PanelBttMin_Click;

            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
   
            orationesCredoFrancais.Click += Orationes.orationesCredoFrancais_Click;
            aveMariaFrancais.Click += Orationes.aveMariaFrancais_Click;
            paterNosterFrancais.Click += Orationes.PaterNosterFrancais_Click;

            credoPl.Click += OrationesPolski.CredoPl_Click;
            zdrowaskaPl.Click += OrationesPolski.ZdrowaskaPl_Click;
            ojczeNaszPl.Click += OrationesPolski.OjczeNaszPl_Click;

            credoLatine.Click += OrationesLatine.CredoLatine_Click;
            aveMariaLatine.Click += OrationesLatine.AveMariaLatine_Click;
            paterNosterLatine.Click += OrationesLatine.PaterNosterLatine_Click;

        }

        private void Form_Load(object sender, EventArgs e)
        {
            //string database_connection;
            //database_connection = "Data Source=Database\\modlitewnik.db;Version=3;Mode = Read Only;";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
