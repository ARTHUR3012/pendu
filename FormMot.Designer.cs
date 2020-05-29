namespace Pendu_exam
{
    partial class FormMot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonJouer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.textBoxMotMystere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonJouer
            // 
            this.buttonJouer.Location = new System.Drawing.Point(336, 143);
            this.buttonJouer.Name = "buttonJouer";
            this.buttonJouer.Size = new System.Drawing.Size(75, 23);
            this.buttonJouer.TabIndex = 0;
            this.buttonJouer.Text = "Jouer";
            this.buttonJouer.UseVisualStyleBackColor = true;
            this.buttonJouer.Click += new System.EventHandler(this.buttonJouer_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(255, 143);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 1;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // textBoxMotMystere
            // 
            this.textBoxMotMystere.Location = new System.Drawing.Point(130, 78);
            this.textBoxMotMystere.Name = "textBoxMotMystere";
            this.textBoxMotMystere.Size = new System.Drawing.Size(200, 20);
            this.textBoxMotMystere.TabIndex = 0;
            this.textBoxMotMystere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMotMystere_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mot Mystère";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(48, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(343, 51);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Veuillez introduire un mot mystère. Uniquement en majuscule.\nLe mot sera inséré d" +
    "ans le dictionaire des mots pour les pochaines partie individuelle.";
            // 
            // FormMot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 181);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMotMystere);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonJouer);
            this.Name = "FormMot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2 joueurs - Choix du mot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJouer;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.TextBox textBoxMotMystere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}