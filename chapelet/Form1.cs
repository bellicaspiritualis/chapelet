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

        //richTextBox1.Clear();

        public Form1()
        {
            InitializeComponent();
            
            panelBttClose.Click += BorderStyle.PanelBttClose_Click;
            panelBttMin.Click += BorderStyle.PanelBttMin_Click;

            newToolStripMenuItem.Click += MenuStripOne.NewToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += MenuStripOne.ExitToolStripMenuItem_Click;
            openToolStripMenuItem.Click += MenuStripOne.OpenToolStripMenuItem_Click;
            undoToolStripMenuItem.Click += MenuStripOne.UndoToolStripMenuItem_Click;
            redoToolStripMenuItem.Click += MenuStripOne.RedoToolStripMenuItem_Click;
            cutToolStripMenuItem.Click += MenuStripOne.CutToolStripMenuItem_Click;
            copyToolStripMenuItem.Click += MenuStripOne.CopyToolStripMenuItem_Click;
            pasteToolStripMenuItem.Click += MenuStripOne.PasteToolStripMenuItem_Click;
            selectAllToolStripMenuItem.Click += MenuStripOne.SelectAllToolStripMenuItem_Click;
            saveToolStripMenuItem.Click += MenuStripOne.SaveToolStripMenuItem_Click;

            orationesCredoFrancais.Click += OrationesFrancais.orationesCredoFrancais_Click;
            aveMariaFrancais.Click += OrationesFrancais.aveMariaFrancais_Click;
            paterNosterFrancais.Click += OrationesFrancais.PaterNosterFrancais_Click;
            priereStJosephFrancais.Click += OrationesFrancais.PriereStJosephFrancais_Click;
            litaniesDeStJosephFR.Click += OrationesFrancais.LitaniesDeStJosephFR_Click;
            oraison1.Click += OrationesFrancais.Oraison1_Click;

            credoPl.Click += OrationesPolski.CredoPl_Click;
            zdrowaskaPl.Click += OrationesPolski.ZdrowaskaPl_Click;
            ojczeNaszPl.Click += OrationesPolski.OjczeNaszPl_Click;
            doSwJozefa.Click += OrationesPolski.DoSWJozefa_Click;
            litaniaDoŚwJózefaPL.Click += OrationesPolski.LitaniaDoŚwJózefaPL_Click;
            modlitwa1.Click += OrationesPolski.Modlitwa1_Click;
            modlitwa2.Click += OrationesPolski.Modlitwa2_Click;
            modlitwa3.Click += OrationesPolski.Modlitwa3_Click;
            modlitwa4.Click += OrationesPolski.Modlitwa4_Click;
            modlitwa5.Click += OrationesPolski.Modlitwa5_Click;
            modlitwa6.Click += OrationesPolski.Modlitwa6_Click;
            modlitwa7.Click += OrationesPolski.Modlitwa7_Click;
            modlitwa8.Click += OrationesPolski.Modlitwa8_Click;
            modlitwa9.Click += OrationesPolski.Modlitwa9_Click;
            modlitwa10.Click += OrationesPolski.Modlitwa10_Click;
            modlitwa11.Click += OrationesPolski.Modlitwa11_Click;
            modlitwa12.Click += OrationesPolski.Modlitwa12_Click;
            modlitwa13.Click += OrationesPolski.Modlitwa13_Click;
            modlitwa14.Click += OrationesPolski.Modlitwa14_Click;
            modlitwa15.Click += OrationesPolski.Modlitwa15_Click;

            credoLatine.Click += OrationesLatine.CredoLatine_Click;
            aveMariaLatine.Click += OrationesLatine.AveMariaLatine_Click;
            paterNosterLatine.Click += OrationesLatine.PaterNosterLatine_Click;
            salveReginaLatine.Click += OrationesLatine.SalveReginaLatine_Click;
            litaniaeSanctiIoseph.Click += OrationesLatine.LitaniaeSanctiIoseph_Click;
        }
    }
}
