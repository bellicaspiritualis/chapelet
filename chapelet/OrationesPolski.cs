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
                myForm.richTextBox1.ReadOnly = true;
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
                myForm.richTextBox1.ReadOnly = true;
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
                myForm.richTextBox1.ReadOnly = true;
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
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void LitaniaDoŚwJózefaPL_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='5' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Modlitwa1_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='6' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Modlitwa2_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='7' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Modlitwa3_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='8' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Modlitwa4_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='9' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Modlitwa5_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='10' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Modlitwa6_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='11' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Modlitwa7_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='12' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Modlitwa8_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='13' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Modlitwa9_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='14' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Modlitwa10_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='15' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Modlitwa11_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='16' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Modlitwa12_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='17' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Modlitwa13_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='18' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Modlitwa14_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='19' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Modlitwa15_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT modlitwa FROM polski where id='20' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }
    }
}
