using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapelet.Repo
{
    class PrincipalesPrieres
    {
        public static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public static DBConn con;

        public static void CredoFR_Click(object s, EventArgs e)
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

        public static void NotrePereFR_Click(object s, EventArgs e)
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
        
        public static void JeVousSalueMarieFR_Click(object s, EventArgs e)
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

        public static void GloireAuPere_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='21' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void ActeDeFoi_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='22' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void ActeDesperance_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='23' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void ActeDeCharite_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='24' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void ActeDeContrition_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='25' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void JeConfesseADieu_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT priere FROM francais where id='26' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }
    }
}
