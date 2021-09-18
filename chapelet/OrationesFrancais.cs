using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace chapelet
{
    class OrationesFrancais
    {
        public static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public static DBConn con;
        //RichTextBox rbox = new RichTextBox();
        ////richTextBox1.Text = "\n🕀\n\n";
        //this.Controls.Add(rbox);

        public static void orationesCredoFrancais_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='1' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {                
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void aveMariaFrancais_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='2' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void PaterNosterFrancais_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='3' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void PriereStJosephFrancais_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='4' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }
    }
}
