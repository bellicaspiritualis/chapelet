using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapelet
{
    class MenuStripOne
    {
        public static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        public static void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
