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

        ////richTextBox1.Text = "\n🕀\n\n";



        public static void orationesCredoFrancais_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='1' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
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
                myForm.richTextBox1.ReadOnly = true;
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
                myForm.richTextBox1.ReadOnly = true;
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
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void LitaniesDeStJosephFR_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='5' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Oraison1_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='6' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Oraison2_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='7' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Oraison3_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='8' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Oraison4_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='9' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Oraison5_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='10' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Oraison6_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='11' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Oraison7_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='12' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Oraison8_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='13' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Oraison9_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='14' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Oraison10_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='15' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Oraison11_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='16' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Oraison12_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='17' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Oraison13_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='18' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Oraison14_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='19' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Oraison15_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='20' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }
    }
}
