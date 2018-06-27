namespace Bot_OGame_V2
{
    partial class FormulaireCompte
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonValiderModif = new System.Windows.Forms.Button();
            this.labelErreurCreationCompte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.textBoxAdresseServeur = new System.Windows.Forms.TextBox();
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.labelServeur = new System.Windows.Forms.Label();
            this.labelMdp = new System.Windows.Forms.Label();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonValiderModif);
            this.panel1.Location = new System.Drawing.Point(180, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 42);
            this.panel1.TabIndex = 23;
            this.panel1.Visible = false;
            // 
            // buttonValiderModif
            // 
            this.buttonValiderModif.Location = new System.Drawing.Point(15, 10);
            this.buttonValiderModif.Name = "buttonValiderModif";
            this.buttonValiderModif.Size = new System.Drawing.Size(75, 23);
            this.buttonValiderModif.TabIndex = 0;
            this.buttonValiderModif.Text = "Modifier";
            this.buttonValiderModif.UseVisualStyleBackColor = true;
            this.buttonValiderModif.Click += new System.EventHandler(this.buttonValiderModif_Click);
            // 
            // labelErreurCreationCompte
            // 
            this.labelErreurCreationCompte.AutoSize = true;
            this.labelErreurCreationCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErreurCreationCompte.ForeColor = System.Drawing.Color.Red;
            this.labelErreurCreationCompte.Location = new System.Drawing.Point(42, 211);
            this.labelErreurCreationCompte.Name = "labelErreurCreationCompte";
            this.labelErreurCreationCompte.Size = new System.Drawing.Size(0, 15);
            this.labelErreurCreationCompte.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Pseudo";
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Location = new System.Drawing.Point(111, 6);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(210, 20);
            this.textBoxPseudo.TabIndex = 13;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(195, 150);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 19;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(70, 150);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 20;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // textBoxAdresseServeur
            // 
            this.textBoxAdresseServeur.Location = new System.Drawing.Point(111, 84);
            this.textBoxAdresseServeur.Name = "textBoxAdresseServeur";
            this.textBoxAdresseServeur.Size = new System.Drawing.Size(210, 20);
            this.textBoxAdresseServeur.TabIndex = 18;
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Location = new System.Drawing.Point(111, 58);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.Size = new System.Drawing.Size(210, 20);
            this.textBoxMdp.TabIndex = 17;
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(111, 32);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(210, 20);
            this.textBoxIdentifiant.TabIndex = 15;
            // 
            // labelServeur
            // 
            this.labelServeur.AutoSize = true;
            this.labelServeur.Location = new System.Drawing.Point(12, 87);
            this.labelServeur.Name = "labelServeur";
            this.labelServeur.Size = new System.Drawing.Size(83, 13);
            this.labelServeur.TabIndex = 16;
            this.labelServeur.Text = "Adresse serveur";
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Location = new System.Drawing.Point(12, 61);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(71, 13);
            this.labelMdp.TabIndex = 14;
            this.labelMdp.Text = "Mot de passe";
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Location = new System.Drawing.Point(12, 35);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.labelIdentifiant.TabIndex = 12;
            this.labelIdentifiant.Text = "Identifiant";
            // 
            // FormulaireCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 316);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelErreurCreationCompte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPseudo);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.textBoxAdresseServeur);
            this.Controls.Add(this.textBoxMdp);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Controls.Add(this.labelServeur);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.labelIdentifiant);
            this.Name = "FormulaireCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau Compte";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonValiderModif;
        private System.Windows.Forms.Label labelErreurCreationCompte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPseudo;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.TextBox textBoxAdresseServeur;
        private System.Windows.Forms.TextBox textBoxMdp;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.Label labelServeur;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.Label labelIdentifiant;
    }
}