using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendu_exam
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            lettre_appuyee("B");
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            lettre_appuyee("A");
        }

        FONCTION lettre_appuyee(lettre_jouee)
                verifier si la lettre_jouee est dans le mot chercher
                 ATTENTION ACCENT / ç à 
                si oui -> Afficher le lettres dans le mot caché
                    Si mot trouvé -> gagné = récupéer le score pour avoir score glol de la partie
                sinon decrémenter le score / décrémenter le nombre decoup restant / changer image
                    si plus de coup possible -> fin de la partie
private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
