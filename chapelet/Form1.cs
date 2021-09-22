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

            credoFR.Click += Repo.PrincipalesPrieres.CredoFR_Click;
            notrePereFR.Click += Repo.PrincipalesPrieres.NotrePereFR_Click;
            jeVousSalueMarieFR.Click += Repo.PrincipalesPrieres.JeVousSalueMarieFR_Click;
            priereASaintJosepFR.Click += Repo.PrincipalesPrieres.PriereStJosephFrancais_Click;
            gloireAuPere.Click += Repo.PrincipalesPrieres.GloireAuPere_Click;
            acteDeFoi.Click += Repo.PrincipalesPrieres.ActeDeFoi_Click;
            acteDesperance.Click += Repo.PrincipalesPrieres.ActeDesperance_Click;
            acteDeCharite.Click += Repo.PrincipalesPrieres.ActeDeCharite_Click;
            acteDeContrition.Click += Repo.PrincipalesPrieres.ActeDeContrition_Click;
            jeConfesseADieu.Click += Repo.PrincipalesPrieres.JeConfesseADieu_Click;

            litaniesDeSaintJosephFR.Click += Repo.Litanies.LitaniesDeStJosephFR_Click;


            oraisonPremiere.Click += Repo.QuinzeOraison.OraisonPremiere_Click;
            oraisonSeconde.Click += Repo.QuinzeOraison.OraisonSeconde_Click;
            oraisonTroisieme.Click += Repo.QuinzeOraison.OraisonTroisieme_Click;
            oraisonQuatrieme.Click += Repo.QuinzeOraison.OraisonQuatrieme_Click;
            oraisonCinquieme.Click += Repo.QuinzeOraison.OraisonCinquieme_Click;
            oraisonSixieme.Click += Repo.QuinzeOraison.OraisonSixieme_Click;
            oraisonSeptieme.Click += Repo.QuinzeOraison.OraisonSeptieme_Click;
            oraisonHuitieme.Click += Repo.QuinzeOraison.OraisonHuitieme_Click;
            oraisonNeuvieme.Click += Repo.QuinzeOraison.OraisonNeuvieme_Click;
            oraisonDixieme.Click += Repo.QuinzeOraison.OraisonDixieme_Click;
            oraisonOnzieme.Click += Repo.QuinzeOraison.OraisonOnzieme_Click;
            oraisonoDouzieme.Click += Repo.QuinzeOraison.OraisonDeuzieme_Click;
            oraisonTreizieme.Click += Repo.QuinzeOraison.OraisonTreizieme_Click;
            oraisonQuatorzieme.Click += Repo.QuinzeOraison.OraisonQuatorzieme_Click;
            oraisonQuinzieme.Click += Repo.QuinzeOraison.OraisonQuinzieme_Click;

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

        }
    }
}
