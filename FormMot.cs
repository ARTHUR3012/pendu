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
    public partial class FormMot : Form
    {

        public FormMot()
        {
            InitializeComponent();
        }


        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonJouer_Click(object sender, EventArgs e)
        {
            if (textBoxMotMystere.TextLength > 0)
            {                 
                FormMain.motMystere = textBoxMotMystere.Text.ToUpperInvariant();
                Close();
            }
            else
            {
                MessageBox.Show("Merci de donner un mot mystère");
            }

    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMotMystere_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || e.KeyChar == 8) return;
            e.Handled = true;
        }
    }
}
