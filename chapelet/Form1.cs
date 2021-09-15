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
        string database_connection;

        public Form1()
        {
            InitializeComponent();
            database_connection = "Data Source=Database\\modlitewnik.db;Version=3;Mode = Read Only;";

            //richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

            panelBttClose.Click += BorderStyle.PanelBttClose_Click;
            panelBttMin.Click += BorderStyle.PanelBttMin_Click;


            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            wyznanieWiaryCredoToolStripMenuItem.Click += WyznanieWiaryCredoToolStripMenuItem_Click;
   
            orationesCredoFrancais.Click += Orationes.orationesCredoFrancais_Click;
            aveMariaFrancais.Click += Orationes.aveMariaFrancais_Click;
            paterNosterFrancais.Click += Orationes.PaterNosterFrancais_Click;

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void WyznanieWiaryCredoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(database_connection);
            connection.Open();
            string query = string.Format("SELECT modlitwa FROM polski where tytul='credo' ");
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader sqReader = command.ExecuteReader();
            try
            {
                while (sqReader.Read())
                {
                    richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    richTextBox1.Text = sqReader.GetString(0);
                }
            }
            finally
            {
                sqReader.Close();
                connection.Close();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
