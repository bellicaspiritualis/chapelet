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

namespace chapelet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;

        }



        private void Button3_Click(object sender, EventArgs e)
        {
            string database_connection = "Data Source=latine.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(database_connection);
            connection.Open();
            string query = string.Format("SELECT orationes FROM latin where titulus='paternoster' ");
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

        private void Button2_Click(object sender, EventArgs e)
        {
            string database_connection = "Data Source=latine.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(database_connection);
            connection.Open();
            string query = string.Format("SELECT orationes FROM latin where titulus='credo' ");
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

        private void button1_Click(object sender, EventArgs e)
        {
            string database_connection = "Data Source=latine.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(database_connection);
            connection.Open();
            string query = string.Format("SELECT orationes FROM latin where titulus='avemaria' ");
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Button4_Click(object sender, EventArgs e)
        {
            string database_connection = "Data Source=latine.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(database_connection);
            connection.Open();
            string query = string.Format("SELECT orationes FROM latin where titulus='salveregina' ");
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader sqReader = command.ExecuteReader();
            try
            {
                while (sqReader.Read())
                {
                    richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
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

        }
    }
}
