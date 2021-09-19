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
            myForm.richTextBox1.ReadOnly = false;
            myForm.richTextBox1.Clear();
        }

        public static void ExitToolStripMenuItem_Click(object s, EventArgs e)
        {
            Application.Exit();
        }

        public static void OpenToolStripMenuItem_Click(object s, EventArgs e)
        {
            myForm.richTextBox1.ReadOnly = false;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files (*.*) | *.*";
            ofd.Title = "Open a file ...";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                myForm.richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        public static void SaveToolStripMenuItem_Click(object s, EventArgs e)
        {
            myForm.richTextBox1.ReadOnly = false;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "All files (*.*) | *.*";
            sfd.Title = "Save a file ...";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.Write(myForm.richTextBox1.Text);
                sw.Close();
            }
        }

        public static void UndoToolStripMenuItem_Click(object s, EventArgs e)
        {
            myForm.richTextBox1.Undo();
        }

        public static void RedoToolStripMenuItem_Click(object s, EventArgs e)
        {
            myForm.richTextBox1.Redo();
        }

        public static void CutToolStripMenuItem_Click(object s, EventArgs e)
        {
            myForm.richTextBox1.Cut();
        }

        public static void CopyToolStripMenuItem_Click(object s, EventArgs e)
        {
            myForm.richTextBox1.Copy();
        }

        public static void PasteToolStripMenuItem_Click(object s, EventArgs e)
        {
            myForm.richTextBox1.Paste();
        }

        public static void SelectAllToolStripMenuItem_Click(object s, EventArgs e)
        {
            myForm.richTextBox1.SelectAll();
        }
    }
}
