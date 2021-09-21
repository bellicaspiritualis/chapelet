using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapelet
{
    class OrationesEnglish
    {
        public static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public static DBConn con;

        public static void CredoEnglish_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='1' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void HailMary_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='2' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void OurFather_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='3' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void PrayerToStJoseph_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='4' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void LitanyOfStJoseph_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='5' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void FirstPrayer_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='6' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void SecondPrayer_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='7' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void ThirdPrayer_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='8' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void FourthPrayer_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='9' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void FifthPrayer_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='10' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void SixthPrayer_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='11' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void SeventhPrayer_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='12' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void EighthPrayer_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='13' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void NinthPrayer_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='14' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void TenthPrayer_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='15' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void EleventhPrayer_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='16' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void TwelfthPrayer_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='17' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void ThirteenthPrayer_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='18' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void FourteenthPrayer_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='19' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void FifteenthPrayer_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='20' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }

        public static void Conclusion_Click(object s, EventArgs e)
        {
            con = new DBConn();
            con.SqlQuery("SELECT prayer FROM english where id='21' ");
            myForm.richTextBox1.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                myForm.richTextBox1.ReadOnly = true;
                myForm.richTextBox1.AppendText("\n🕀\n\n" + dr[0].ToString().Trim());
            }
        }
    }
}
