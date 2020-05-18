using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pendu_exam
{
    public partial class FormIntro : Form
    {
        public FormIntro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_2joueurs_Click(object sender, EventArgs e)
        {
            FormMot newform = new FormMot();
            newform.ShowDialog();
            FormMain.Mode2joueurs = true;
            if ((FormMain.Mode2joueurs == true) && (FormMain.motMystere != null))
            {
                using (StreamWriter sw = File.AppendText(FormMain.path))
                {
                    sw.WriteLine(FormMain.motMystere.ToUpperInvariant());
                    sw.Close();
                }
                Close();
            }
            else { FormMain.Mode2joueurs = false; }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
