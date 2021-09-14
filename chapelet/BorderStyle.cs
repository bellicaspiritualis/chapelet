using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace chapelet
{
    class BorderStyle
    {
        public static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();



        public static void BttClose_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                myForm.Close();
            }

        }

        public static void BttMin_Click(object sender, EventArgs e)
        {
            myForm.WindowState = FormWindowState.Minimized;
        }

    }
}
