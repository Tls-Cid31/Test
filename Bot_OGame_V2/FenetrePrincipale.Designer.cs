namespace Bot_OGame_V2
{
    partial class FenetrePrincipale
    {

        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauCompteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierCompteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerCompteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userControlTab = new Bot_OGame_V2.UserControlTab();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauCompteMenu,
            this.modifierCompteMenu,
            this.supprimerCompteMenu});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauCompteMenu
            // 
            this.nouveauCompteMenu.Name = "nouveauCompteMenu";
            this.nouveauCompteMenu.Size = new System.Drawing.Size(210, 26);
            this.nouveauCompteMenu.Text = "Nouveau Compte";
            this.nouveauCompteMenu.Click += new System.EventHandler(this.NouveauCompteMenu_Click);
            // 
            // modifierCompteMenu
            // 
            this.modifierCompteMenu.Name = "modifierCompteMenu";
            this.modifierCompteMenu.Size = new System.Drawing.Size(210, 26);
            this.modifierCompteMenu.Text = "Modifier Compte";
            this.modifierCompteMenu.Click += new System.EventHandler(this.ModifierCompteMenu_Click);
            // 
            // supprimerCompteMenu
            // 
            this.supprimerCompteMenu.Name = "supprimerCompteMenu";
            this.supprimerCompteMenu.Size = new System.Drawing.Size(210, 26);
            this.supprimerCompteMenu.Text = "Supprimer Compte";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 656);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userControlTab);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1037, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userControlTab
            // 
            this.userControlTab.AutoScroll = true;
            this.userControlTab.Location = new System.Drawing.Point(-4, 0);
            this.userControlTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userControlTab.MinimumSize = new System.Drawing.Size(1035, 624);
            this.userControlTab.Name = "userControlTab";
            this.userControlTab.Size = new System.Drawing.Size(1041, 738);
            this.userControlTab.TabIndex = 0;
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "FenetrePrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ogame Bot";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauCompteMenu;
        private System.Windows.Forms.ToolStripMenuItem modifierCompteMenu;
        private System.Windows.Forms.ToolStripMenuItem supprimerCompteMenu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UserControlTab userControlTab;
    }
}

