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
            oraison2.Click += OrationesFrancais.Oraison2_Click;
            oraison3.Click += OrationesFrancais.Oraison3_Click;
            oraison4.Click += OrationesFrancais.Oraison4_Click;
            oraison5.Click += OrationesFrancais.Oraison5_Click;
            oraison6.Click += OrationesFrancais.Oraison6_Click;
            oraison7.Click += OrationesFrancais.Oraison7_Click;
            oraison8.Click += OrationesFrancais.Oraison8_Click;
            oraison9.Click += OrationesFrancais.Oraison9_Click;
            oraison10.Click += OrationesFrancais.Oraison10_Click;
            oraison11.Click += OrationesFrancais.Oraison11_Click;
            oraison12.Click += OrationesFrancais.Oraison12_Click;
            oraison13.Click += OrationesFrancais.Oraison13_Click;
            oraison14.Click += OrationesFrancais.Oraison14_Click;
            oraison15.Click += OrationesFrancais.Oraison15_Click;

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
            novenaStIosephLatine.Click += OrationesLatine.NovenaStIosephLatine_Click;
            litaniaeSanctiIoseph.Click += OrationesLatine.LitaniaeSanctiIoseph_Click;
            oratio1.Click += OrationesLatine.Oratio1_Click;
            oratio2.Click += OrationesLatine.Oratio2_Click;
            oratio3.Click += OrationesLatine.Oratio3_Click;
            oratio4.Click += OrationesLatine.Oratio4_Click;
            oratio5.Click += OrationesLatine.Oratio5_Click;
            oratio6.Click += OrationesLatine.Oratio6_Click;
            oratio7.Click += OrationesLatine.Oratio7_Click;
            oratio8.Click += OrationesLatine.Oratio8_Click;
            oratio9.Click += OrationesLatine.Oratio9_Click;
            oratio10.Click += OrationesLatine.Oratio10_Click;
            oratio11.Click += OrationesLatine.Oratio11_Click;
            oratio12.Click += OrationesLatine.Oratio12_Click;
            oratio13.Click += OrationesLatine.Oratio13_Click;
            oratio14.Click += OrationesLatine.Oratio14_Click;
            oratio15.Click += OrationesLatine.Oratio15_Click;
            conclusio.Click += OrationesLatine.Conclusio_Click;

            credoEn.Click += OrationesEnglish.CredoEnglish_Click;
            hailMary.Click += OrationesEnglish.HailMary_Click;
            ourFather.Click += OrationesEnglish.OurFather_Click;
            prayerToStJoseph.Click += OrationesEnglish.PrayerToStJoseph_Click;
            litanyOfStJoseph.Click += OrationesEnglish.LitanyOfStJoseph_Click;
            firstPrayer.Click += OrationesEnglish.FirstPrayer_Click;
            secondPrayer.Click += OrationesEnglish.SecondPrayer_Click;
            thirdPrayer.Click += OrationesEnglish.ThirdPrayer_Click;
            fourthPrayer.Click += OrationesEnglish.FourthPrayer_Click;
            fifthPrayer.Click += OrationesEnglish.FifthPrayer_Click;
            sixthPrayer.Click += OrationesEnglish.SixthPrayer_Click;
            seventhPrayer.Click += OrationesEnglish.SeventhPrayer_Click;
            eighthPrayer.Click += OrationesEnglish.EighthPrayer_Click;
            ninthPrayer.Click += OrationesEnglish.NinthPrayer_Click;
            tenthPrayer.Click += OrationesEnglish.TenthPrayer_Click;
            eleventhPrayer.Click += OrationesEnglish.EleventhPrayer_Click;
            twelfthPrayer.Click += OrationesEnglish.TwelfthPrayer_Click;
            thirteenthPrayer.Click += OrationesEnglish.ThirteenthPrayer_Click;
            fourteenthPrayer.Click += OrationesEnglish.FourteenthPrayer_Click;
            fifteenthPrayer.Click += OrationesEnglish.FifteenthPrayer_Click;
            conclusion.Click += OrationesEnglish.Conclusion_Click;
        }
    }
}
