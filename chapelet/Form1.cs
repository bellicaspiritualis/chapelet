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
    public partial class Form1 : Form
    {
        public DBConn con;
        

        public Form1()
        {
            InitializeComponent();
            
            panelBttClose.Click += BorderStyle.PanelBttClose_Click;
            panelBttMin.Click += BorderStyle.PanelBttMin_Click;

            exitToolStripMenuItem.Click += MenuStripOne.exitToolStripMenuItem_Click;
   
            orationesCredoFrancais.Click += OrationesFrancais.orationesCredoFrancais_Click;
            aveMariaFrancais.Click += OrationesFrancais.aveMariaFrancais_Click;
            paterNosterFrancais.Click += OrationesFrancais.PaterNosterFrancais_Click;

            credoPl.Click += OrationesPolski.CredoPl_Click;
            zdrowaskaPl.Click += OrationesPolski.ZdrowaskaPl_Click;
            ojczeNaszPl.Click += OrationesPolski.OjczeNaszPl_Click;
            doSwJozefa.Click += OrationesPolski.DoSWJozefa_Click;

            credoLatine.Click += OrationesLatine.CredoLatine_Click;
            aveMariaLatine.Click += OrationesLatine.AveMariaLatine_Click;
            paterNosterLatine.Click += OrationesLatine.PaterNosterLatine_Click;
            salveReginaLatine.Click += OrationesLatine.SalveReginaLatine_Click;

        }
    }
}
