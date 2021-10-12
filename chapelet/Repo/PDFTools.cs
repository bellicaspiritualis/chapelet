using PdfSharp;
using PdfSharp.Pdf;
using MigraDoc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf.IO;
using System.Diagnostics;
using PdfSharp.Drawing;
using PdfSharp.Pdf.AcroForms;

namespace chapelet.Repo
{

    class PDFTools
    {
        public static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        public static void PDFRead_Click(object s, EventArgs e)
        {
            //Console.WriteLine("Starting...");
            //OpenFileDialog dialog = new OpenFileDialog();


                // Open the file
                PdfDocument document = PdfReader.Open(@"D:\e-booki\Duchowość\Ewagriusz z pontu\gehin.pdf", PdfDocumentOpenMode.Modify);

                // Get the root object of all interactive form fields
                PdfAcroForm form = document.AcroForm;

                PdfTextField testField = (PdfTextField)(form.Fields["body"]);
                testField.Text = "012345";

                document.Save(@"D:\e-booki\Duchowość\Ewagriusz z pontu\gehin.pdf");

 
            //OpenFileDialog dialog = new OpenFileDialog();

            //PdfDocument document = new PdfDocument();

            //myForm.richTextBox1.ToString(page);
            //XFont font = new XFont("Verdana", 20, XFontStyle.Bold);

            //string filename = "HelloWorld.pdf";
            //document.Save(filename);
            //Process.Start(filename);


            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    document.Save(filename);
            //    Process.Start(filename);
            //}

        }

        //public static void OpenFile(string filepath)
        //{

        //}
    }
}
