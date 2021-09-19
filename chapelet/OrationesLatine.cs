using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;


namespace chapelet
{
    
    class OrationesLatine
    {
        public static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public static DBConn con;
        //public static Form1 myForm = richTextBox1.ReadOnly = true;
        public static void CredoLatine_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='1' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void AveMariaLatine_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='2' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }


        public static void PaterNosterLatine_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='3' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void SalveReginaLatine_Click(object sender, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='4' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }
    }
}
