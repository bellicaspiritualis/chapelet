using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapelet
{
    class MenuStripOne
    {
        public static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        public static void NewToolStripMenuItem_Click(object s, EventArgs e)
        {
            myForm.richTextBox2.Clear();
        }

        public static void ExitToolStripMenuItem_Click(object s, EventArgs e)
        {
            Application.Exit();
        }

        public static void OpenToolStripMenuItem_Click(object s, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files (*.*) | *.*";
            ofd.Title = "Open a file ...";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                myForm.richTextBox2.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        public static void SaveToolStripMenuItem_Click(object s, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "All files (*.*) | *.*";
            sfd.Title = "Save a file ...";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.Write(myForm.richTextBox2.Text);
                sw.Close();
            }
        }

        public static void UndoToolStripMenuItem_Click(object s, EventArgs e)
        {
            myForm.richTextBox2.Undo();
        }

        public static void RedoToolStripMenuItem_Click(object s, EventArgs e)
        {
            myForm.richTextBox2.Redo();
        }

        public static void CutToolStripMenuItem_Click(object s, EventArgs e)
        {
            myForm.richTextBox2.Cut();
        }

        public static void CopyToolStripMenuItem_Click(object s, EventArgs e)
        {
            myForm.richTextBox2.Copy();
        }

        public static void PasteToolStripMenuItem_Click(object s, EventArgs e)
        {
            myForm.richTextBox2.Paste();
        }

        public static void SelectAllToolStripMenuItem_Click(object s, EventArgs e)
        {
            myForm.richTextBox2.SelectAll();
        }
    }
}
