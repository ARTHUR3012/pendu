using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendu_exam
{
    public partial class FormMain : Form
    {
        internal static String motMystere;
        internal static Boolean Mode2joueurs;
        internal static int longueur;
        internal static Boolean[] lettreCheck;

        private string AffichageMotMystere(string mot)
        {
            char[] mottemp = new char[longueur];
            int index = 0;
            foreach (Boolean i in lettreCheck)
            {             
                if (i == false) { mottemp[index] = '-'; }
                else { mottemp[index] = mot[index]; }
                index++;
            }
            return new string(mottemp);
        }

        private void ControleLettre(string lettre)
        {            
            Debug.WriteLine(lettre);
            if (motMystere.Contains(lettre))
            {
                lettreCheck[motMystere.IndexOf(lettre)] = true;
                richTextBoxMotMystere.Text = AffichageMotMystere(motMystere);
            }                
            return;
        }
        public FormMain()
        {
            InitializeComponent();
        }

        //FONCTION lettre_appuyee(lettre_jouee)
        //        verifier si la lettre_jouee est dans le mot chercher
        //         ATTENTION ACCENT / ç à 
        //        si oui -> Afficher le lettres dans le mot caché
        //            Si mot trouvé -> gagné = récupéer le score pour avoir score glol de la partie
        //        sinon decrémenter le score / décrémenter le nombre decoup restant / changer image
        //            si plus de coup possible -> fin de la partie

        private void Intro()
        {
            FormIntro newform = new FormIntro();
            newform.ShowDialog();
            longueur = 0;
            if (Mode2joueurs == false)
            {
                motMystere = "test";
            }
            longueur = motMystere.Length;
            lettreCheck = new Boolean[longueur];
            richTextBoxMotMystere.Text = AffichageMotMystere(motMystere);
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            Intro();   
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous quitter le jeu ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void buttonMode_Click(object sender, EventArgs e)
        {
            Intro();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            ControleLettre("A");
            buttonA.Enabled = false;
        }
        private void buttonB_Click(object sender, EventArgs e)
        {
            ControleLettre("B");
            buttonB.Enabled = false;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            ControleLettre("C");
            buttonC.Enabled = false;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            ControleLettre("D");
            buttonD.Enabled = false;
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            ControleLettre("E");
            buttonE.Enabled = false;
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            ControleLettre("F");
            buttonF.Enabled = false;
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            ControleLettre("G");
            buttonG.Enabled = false;
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            ControleLettre("H");
            buttonH.Enabled = false;
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            ControleLettre("I");
            buttonI.Enabled = false;
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            ControleLettre("J");
            buttonJ.Enabled = false;
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            ControleLettre("K");
            buttonK.Enabled = false;
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            ControleLettre("L");
            buttonL.Enabled = false;
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            ControleLettre("M");
            buttonM.Enabled = false;
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            ControleLettre("N");
            buttonN.Enabled = false;
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            ControleLettre("O");
            buttonO.Enabled = false;
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            ControleLettre("P");
            buttonP.Enabled = false;
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            ControleLettre("Q");
            buttonQ.Enabled = false;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            ControleLettre("R");
            buttonR.Enabled = false;
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            ControleLettre("S");
            buttonS.Enabled = false;
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            ControleLettre("T");
            buttonT.Enabled = false;
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            ControleLettre("U");
            buttonU.Enabled = false;
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            ControleLettre("V");
            buttonV.Enabled = false;
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            ControleLettre("W");
            buttonW.Enabled = false;
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            ControleLettre("X");
            buttonX.Enabled = false;
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            ControleLettre("Y");
            buttonY.Enabled = false;
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            ControleLettre("Z");
            buttonZ.Enabled = false;
        }
    }
}
