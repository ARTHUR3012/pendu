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
                FormMain.motMystere = textBoxMotMystere.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Merci de donner un mot mystère");
            }

    }
    }
}
