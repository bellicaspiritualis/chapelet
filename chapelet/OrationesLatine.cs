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

        public static void NovenaStIosephLatine_Click(object s, EventArgs e)
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

        public static void LitaniaeSanctiIoseph_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='5' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void Oratio1_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='7' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void Oratio2_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='8' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void Oratio3_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='9' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void Oratio4_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='10' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void Oratio5_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='11' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void Oratio6_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='12' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void Oratio7_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='13' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void Oratio8_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='14' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void Oratio9_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='15' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void Oratio10_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='16' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void Oratio11_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='17' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void Oratio12_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='18' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void Oratio13_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='19' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void Oratio14_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='20' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void Oratio15_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='21' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }

        public static void Conclusio_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT orationes FROM latin where id='22' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString());
            }
        }
    }
}
