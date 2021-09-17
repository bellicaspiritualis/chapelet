using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Data.SqlClient;
using System.Threading;

namespace chapelet
{
    
    class OrationesLatine
    {
        public static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public static DBConn con;
        public static void SalveReginaLatine_Click(object sender, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='4' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.AppendText(dr[0].ToString());
            }
        }

        public static void CredoLatine_Click(object s, EventArgs e)
        {
            string database_connection = "Data Source=Database\\modlitewnik.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(database_connection);
            connection.Open();
            string query = string.Format("SELECT orationes FROM latin where titulus='credo' ");
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader sqReader = command.ExecuteReader();
            try
            {
                while (sqReader.Read())
                {
                    //myForm.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    myForm.richTextBox1.Text = sqReader.GetString(0);
                }
            }
            finally
            {
                sqReader.Close();
                connection.Close();
            }
        }

        public static void AveMariaLatine_Click(object s, EventArgs e)
        {
            string database_connection = "Data Source=Database\\modlitewnik.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(database_connection);
            connection.Open();
            string query = string.Format("SELECT orationes FROM latin where titulus='avemaria' ");
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader sqReader = command.ExecuteReader();
            try
            {
                while (sqReader.Read())
                {
                    //myForm.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    myForm.richTextBox1.Text = sqReader.GetString(0);
                }
            }
            finally
            {
                sqReader.Close();
                connection.Close();
            }
        }

        public static void PaterNosterLatine_Click(object s, EventArgs e)
        {
            string database_connection = "Data Source=Database\\modlitewnik.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(database_connection);
            connection.Open();
            string query = string.Format("SELECT orationes FROM latin where titulus='paternoster' ");
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader sqReader = command.ExecuteReader();
            try
            {
                while (sqReader.Read())
                {
                    //myForm.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    myForm.richTextBox1.Text = sqReader.GetString(0);
                }
            }
            finally
            {
                sqReader.Close();
                connection.Close();
            }
        }


    }
}
