using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        internal static int compteurCoup = 0;
        internal static int[] point = { 5,10,15,25,35,50,100};
        internal static int scoreTotal = 0;
        internal static Boolean partieGagne = false;
        internal static int totalMotTrouve = 0;
        internal static string path = "dico.txt";

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
            int pos = 0;
            int LettreIndex = motMystere.IndexOf(lettre, pos, StringComparison.InvariantCultureIgnoreCase);
            if (LettreIndex >= 0)
            {
                //TROUVE
                while (LettreIndex >= 0)
                {
                    if (LettreIndex >= 0)
                    {
                        pos = LettreIndex + 1;
                        lettreCheck[LettreIndex] = true;
                        richTextBoxMotMystere.Text = AffichageMotMystere(motMystere);
                        LettreIndex = motMystere.IndexOf(lettre, pos, StringComparison.InvariantCultureIgnoreCase);
                    }
                }
            }
            else
            {
                //PAS TROUVE            
                switch (compteurCoup)
                {
                    case 1:
                        picturePendu.Image = Pendu_exam.Properties.Resources.E7;
                        break;
                    case 2:
                        picturePendu.Image = Pendu_exam.Properties.Resources.E6;
                        break;
                    case 3:
                        picturePendu.Image = Pendu_exam.Properties.Resources.E5;
                        break;
                    case 4:
                        picturePendu.Image = Pendu_exam.Properties.Resources.E4;
                        break;
                    case 5:
                        picturePendu.Image = Pendu_exam.Properties.Resources.E3;
                        break;
                    case 6:
                        picturePendu.Image = Pendu_exam.Properties.Resources.E2;
                        break;
                }
                compteurCoup--;               
                if (compteurCoup < 0)
                {
                    MessageBox.Show("PERDU - le  mot était : "+motMystere);
                    return;
                }
                richTextBox_coupRestant.Text = compteurCoup.ToString();
            }
            bool allTrue = true;
            foreach (bool b in lettreCheck)
            { 
                if (b)
                {
                    allTrue = true;
                }
                else
                {
                    allTrue = false;
                    break;
                }
            }

            if (allTrue)
                {                
                scoreTotal = scoreTotal + point[compteurCoup];
                richTextBoxScoreTotal.Text = scoreTotal.ToString();
                MessageBox.Show("VOUS AVEZ GAGNE - Votre score est de "+point[compteurCoup].ToString());
                totalMotTrouve++;
                richTextBoxMotTrouve.Text = totalMotTrouve.ToString();
                partieGagne = true;
            }
            return;
        }
        public FormMain()
        {
            InitializeComponent();
        }

        private void Intro()
        {
            partieGagne = false;
            Mode2joueurs = false;
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonE.Enabled = true;
            buttonF.Enabled = true;
            buttonG.Enabled = true;
            buttonH.Enabled = true;
            buttonI.Enabled = true;
            buttonJ.Enabled = true;
            buttonK.Enabled = true;
            buttonL.Enabled = true;
            buttonM.Enabled = true;
            buttonN.Enabled = true;
            buttonO.Enabled = true;
            buttonP.Enabled = true;
            buttonQ.Enabled = true;
            buttonR.Enabled = true;
            buttonS.Enabled = true;
            buttonT.Enabled = true;
            buttonU.Enabled = true;
            buttonV.Enabled = true;
            buttonW.Enabled = true;
            buttonX.Enabled = true;
            buttonY.Enabled = true;
            buttonZ.Enabled = true;
            FormIntro newform = new FormIntro();
            newform.ShowDialog();
            longueur = 0;
            if (Mode2joueurs == false)
            {
                try
                {
                    string[] allLines = File.ReadAllLines(path);
                    Random rnd1 = new Random();
                    motMystere = allLines[rnd1.Next(allLines.Length)];
                }
                catch (IOException)
                {
                    MessageBox.Show("Le fichier " + path + " n'existe pas");
                    Application.Exit();
                    return;
                }
                             
            }

            longueur = motMystere.Length;
            lettreCheck = new Boolean[longueur];
            richTextBoxMotMystere.Text = AffichageMotMystere(motMystere);
            compteurCoup = 6;
            richTextBox_coupRestant.Text = compteurCoup.ToString();
            picturePendu.Image = Pendu_exam.Properties.Resources.E1;
          
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
            if (partieGagne == true) { Intro(); }
            else
            { buttonA.Enabled = false; }
        }
        private void buttonB_Click(object sender, EventArgs e)
        {
            ControleLettre("B");
            if (partieGagne == true) { Intro(); }
            else { buttonB.Enabled = false; }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            ControleLettre("C");
            if (partieGagne == true) { Intro(); }
            else
            { buttonC.Enabled = false; }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            ControleLettre("D");
            if (partieGagne == true) { Intro(); }
            else
            { buttonD.Enabled = false; }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            ControleLettre("E");
            if (partieGagne == true) { Intro(); }
            else
            { buttonE.Enabled = false; }
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            ControleLettre("F");
            if (partieGagne == true) { Intro(); }
            else
            { buttonF.Enabled = false; }
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            ControleLettre("G");
            if (partieGagne == true) { Intro(); }
            else
            { buttonG.Enabled = false; }
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            ControleLettre("H");
            if (partieGagne == true) { Intro(); }
            else
            { buttonH.Enabled = false; }
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            ControleLettre("I");
            if (partieGagne == true) { Intro(); }
            else
            { buttonI.Enabled = false; }
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            ControleLettre("J");
            if (partieGagne == true) { Intro(); }
            else
            { buttonJ.Enabled = false; }
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            ControleLettre("K");
            if (partieGagne == true) { Intro(); }
            else
            { buttonK.Enabled = false; }
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            ControleLettre("L");
            if (partieGagne == true) { Intro(); }
            else
            { buttonL.Enabled = false; }
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            ControleLettre("M");
            if (partieGagne == true) { Intro(); }
            else
            { buttonM.Enabled = false; }
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            ControleLettre("N");
            if (partieGagne == true) { Intro(); }
            else
            { buttonN.Enabled = false; }
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            ControleLettre("O");
            if (partieGagne == true) { Intro(); }
            else
            { buttonO.Enabled = false; }
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            ControleLettre("P");
            if (partieGagne == true) { Intro(); }
            else
            { buttonP.Enabled = false; }
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            ControleLettre("Q");
            if (partieGagne == true) { Intro(); }
            else
            { buttonQ.Enabled = false; }
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            ControleLettre("R");
            if (partieGagne == true) { Intro(); }
            else
            { buttonR.Enabled = false; }
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            ControleLettre("S");
            if (partieGagne == true) { Intro(); }
            else
            { buttonS.Enabled = false; }
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            ControleLettre("T");
            if (partieGagne == true) { Intro(); }
            else
            { buttonT.Enabled = false; }
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            ControleLettre("U");
            if (partieGagne == true) { Intro(); }
            else
            { buttonU.Enabled = false; }
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            ControleLettre("V");
            if (partieGagne == true) { Intro(); }
            else
            { buttonV.Enabled = false; }
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            ControleLettre("W");
            if (partieGagne == true) { Intro(); }
            else
            { buttonW.Enabled = false; }
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            ControleLettre("X");
            if (partieGagne == true) { Intro(); }
            else
            { buttonX.Enabled = false; }
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            ControleLettre("Y");
            if (partieGagne == true) { Intro(); }
            else
            { buttonY.Enabled = false; }
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            ControleLettre("Z");
            if (partieGagne == true) { Intro(); }
            else
            { buttonZ.Enabled = false; }
        }
    }
}
