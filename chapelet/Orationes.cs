﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapelet
{
    class Orationes
    {
        public static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        //public static void ChangeText()
        //{
        //    myExampleForm.richTextBox1.Text = "Ave Maria!";
        //}
        

        public static void orationesCredoFrancais_Click(object sender, EventArgs e)
        {
            //myExampleForm.richTextBox1.Text = "Ave Maria!";
            //string query = string.Format("SELECT modlitwa FROM polski where id='1' ");
            string database_connection = "Data Source=modlitewnik.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(database_connection);
            connection.Open();
            string query = string.Format("SELECT priere FROM francais where titre='credo' ");
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader sqReader = command.ExecuteReader();
            try
            {
                while (sqReader.Read())
                {
                    //richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
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