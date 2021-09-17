using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;
namespace chapelet
{
    class OrationesPolski
    {
        public static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public static DBConn con;
        //myForm.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

        public static void CredoPl_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='1' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void ZdrowaskaPl_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='2' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void OjczeNaszPl_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='3' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void DoSWJozefa_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='4' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }
    }
}
