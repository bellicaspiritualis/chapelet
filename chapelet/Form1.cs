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
            acteDeContritionI.Click += Repo.PrincipalesPrieres.ActeDeContrition1_Click;
            acteDeContritionII.Click += Repo.PrincipalesPrieres.ActeDeContrition2_Click;
            acteDeContritionIII.Click += Repo.PrincipalesPrieres.ActeDeContrition3_Click;
            acteDeContritionIV.Click += Repo.PrincipalesPrieres.ActeDeContrition4_Click;
            saintFrancoisDAssise.Click += Repo.PrincipalesPrieres.StFrancoisAssise_Click;
            sainteThereseDeLisieux.Click += Repo.PrincipalesPrieres.SainteThereseDeLisieux_Click;
            prierePourLaFrance.Click += Repo.PrincipalesPrieres.PrierePourLaFrance_Click;
            priereDuMatinAMarie.Click += Repo.PrincipalesPrieres.PriereDuMatinAMarie_Click;
            prieresDuMatinASonAngeGardien.Click += Repo.PrincipalesPrieres.StCuredArs_Click;
            sainteMereTeresa.Click += Repo.PrincipalesPrieres.StMereTeresa_Click;
            priereAuSaintPadrePio.Click += Repo.PrincipalesPrieres.StPadrePio_Click;
            priereaSaintAntoineDePadoue.Click += Repo.PrincipalesPrieres.StAntoineDePadoue_Click;
            priereASaintPaul.Click += Repo.PrincipalesPrieres.StPaul_Click;
            priereaSaintJosephII.Click += Repo.PrincipalesPrieres.StJosephII_Click;
            priereSainteTherese.Click += Repo.PrincipalesPrieres.PriereSainteTherese_Click;

            litaniesDeSaintJosephFR.Click += Repo.Litanies.LitaniesDeStJosephFR_Click;
            litaniesDeLorette.Click += Repo.Litanies.LitaniesDeLorette_Click;
            litaniesDePrecieuxSang.Click += Repo.Litanies.LitaniesDePrecieuxSang_Click;
            litaniesDuChefSacreDeJesus.Click += Repo.Litanies.LitaniesDeChefSacreDeJesus_Click;
            litaniesDuSaintNomDeJesus.Click += Repo.Litanies.LitaniesDuSaintNomDeJesus_Click;
            litaniesDesSaints.Click += Repo.Litanies.LitaniesDesSaints_Click;
            litanieHenriGodin.Click += Repo.Litanies.LitanieHenriGodin_Click;

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

            mysLumi1.Click += Repo.Chapelet.MysLumi1_Click;
            mysLumi2.Click += Repo.Chapelet.MysLumi2_Click;
            mysLumi3.Click += Repo.Chapelet.MysLumi3_Click;
            mysLumi4.Click += Repo.Chapelet.MysLumi4_Click;
            mysLumi5.Click += Repo.Chapelet.MysLumi5_Click;
            mysDou1.Click += Repo.Chapelet.MysDou1_Click;
            mysDou2.Click += Repo.Chapelet.MysDou2_Click;
            mysDou3.Click += Repo.Chapelet.MysDou3_Click;
            mysDou4.Click += Repo.Chapelet.MysDou4_Click;
            mysDou5.Click += Repo.Chapelet.MysDou5_Click;
            mysJoy1.Click += Repo.Chapelet.MysJoy1_Click;
            mysJoy2.Click += Repo.Chapelet.MysJoy2_Click;
            mysJoy3.Click += Repo.Chapelet.MysJoy3_Click;
            mysJoy4.Click += Repo.Chapelet.MysJoy4_Click;
            mysJoy5.Click += Repo.Chapelet.MysJoy5_Click;
            mysGlo1.Click += Repo.Chapelet.MysGlo1_Click;
            mysGlo2.Click += Repo.Chapelet.MysGlo2_Click;
            mysGlo3.Click += Repo.Chapelet.MysGlo3_Click;
            mysGlo4.Click += Repo.Chapelet.MysGlo4_Click;
            mysGlo5.Click += Repo.Chapelet.MysGlo5_Click;

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
