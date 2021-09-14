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
            database_connection = "Data Source=Database\\modlitewnik.db;Version=3;";
            //SQLiteConnection connection = new SQLiteConnection(database_connection);
            //connection.Open();

            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

            button1.Click += button1_Click;
            credoLatineToolStripMenuItem.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            wyznanieWiaryCredoToolStripMenuItem.Click += WyznanieWiaryCredoToolStripMenuItem_Click;
   
            orationesCredoFrancais.Click += Orationes.orationesCredoFrancais_Click;
        }


        //static Orationes ora = new Orationes();
        //private static object orationesCredoFrancais_Click;

        private void Form_Load(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(database_connection);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            SQLiteDataReader sqReader = command.ExecuteReader();
            //ora.orationesCredoFrancais_Click();
            //Orationes.richTextBox1.Text = sqReader.GetString(0);
            //myExampleForm.richTextBox1.Text = sqReader.GetString(0);
        }


        private void WyznanieWiaryCredoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //string query = string.Format("SELECT modlitwa FROM polski where id='1' ");
            //string database_connection = "Data Source=modlitewnik.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(database_connection);
            connection.Open();
            string query = string.Format("SELECT modlitwa FROM polski where tytul='credo' ");
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader sqReader = command.ExecuteReader();
            try
            {
                while (sqReader.Read())
                {
                    //richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
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

        private void Button3_Click(object sender, EventArgs e)
        {
            //string database_connection = "Data Source=modlitewnik.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(database_connection);
            connection.Open();
            string query = string.Format("SELECT orationes FROM latin where titulus='paternoster' ");
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader sqReader = command.ExecuteReader();
            try
            {
                while (sqReader.Read())
                {
                    //richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    richTextBox1.Text = sqReader.GetString(0);
                }
            }
            finally
            {
                sqReader.Close();
                connection.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //string database_connection = "Data Source=modlitewnik.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(database_connection);
            connection.Open();
            string query = string.Format("SELECT orationes FROM latin where titulus='credo' ");
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader sqReader = command.ExecuteReader();
            try
            {
                while (sqReader.Read())
                {
                    //richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    richTextBox1.Text = sqReader.GetString(0);
                }
            }
            finally
            {
                sqReader.Close();
                connection.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string database_connection = "Data Source=modlitewnik.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(database_connection);
            connection.Open();
            string query = string.Format("SELECT orationes FROM latin where titulus='avemaria' ");
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader sqReader = command.ExecuteReader();
            try
            {
                while (sqReader.Read())
                {
                    //richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    richTextBox1.Text = sqReader.GetString(0);
                }
            }
            finally
            {
                sqReader.Close();
                connection.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Button4_Click(object sender, EventArgs e)
        {
            //string database_connection = "Data Source=modlitewnik.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(database_connection);
            connection.Open();
            string query = string.Format("SELECT orationes FROM latin where titulus='salveregina' ");
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader sqReader = command.ExecuteReader();
            try
            {
                while (sqReader.Read())
                {
                    //richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    richTextBox1.Text = sqReader.GetString(0);
                    //
                }
            }
            finally
            {
                sqReader.Close();
                connection.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string query = string.Format("SELECT orationes FROM modlitewnik  where titulus='paternoster' ");
            //zobaczyc tuto jorge resoreccion o switchach i upodobnic zeby tylko raz ustanowic
            //umiescic poaczenie w Form_Load jak sie wydaje
            //polaczenie z SQLite i tylko w buttonie dawac komende sqlite + 
            // + class'y bo bedzie tych butonow
        }

        private void paterNosterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
