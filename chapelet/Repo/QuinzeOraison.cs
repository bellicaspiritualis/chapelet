using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapelet.Repo
{
    class QuinzeOraison
    {
        public static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public static DBConn con;

        public static void OraisonPremiere_Click(object s, EventArgs e)
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

        public static void OraisonSeconde_Click(object s, EventArgs e)
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

        public static void OraisonTroisieme_Click(object s, EventArgs e)
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

        public static void OraisonQuatrieme_Click(object s, EventArgs e)
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

        public static void OraisonCinquieme_Click(object s, EventArgs e)
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

        public static void OraisonSixieme_Click(object s, EventArgs e)
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

        public static void OraisonSeptieme_Click(object s, EventArgs e)
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

        public static void OraisonHuitieme_Click(object s, EventArgs e)
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

        public static void OraisonNeuvieme_Click(object s, EventArgs e)
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

        public static void OraisonDixieme_Click(object s, EventArgs e)
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

        public static void OraisonOnzieme_Click(object s, EventArgs e)
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

        public static void OraisonDeuzieme_Click(object s, EventArgs e)
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

        public static void OraisonTreizieme_Click(object s, EventArgs e)
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

        public static void OraisonQuatorzieme_Click(object s, EventArgs e)
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

        public static void OraisonQuinzieme_Click(object s, EventArgs e)
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
