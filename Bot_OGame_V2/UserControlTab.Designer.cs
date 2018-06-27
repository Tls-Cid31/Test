using System.Windows.Forms;

namespace Bot_OGame_V2
{
    partial class UserControlTab
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBoxConnexionAuto = new System.Windows.Forms.CheckBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxChoixCompte = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlPillage = new System.Windows.Forms.TabControl();
            this.tabPageVueGenerale = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxResumeCompte = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFlotte = new System.Windows.Forms.RichTextBox();
            this.tabPageConstruction = new System.Windows.Forms.TabPage();
            this.fileConstructions = new System.Windows.Forms.ListBox();
            this.viderListeRecherche = new System.Windows.Forms.Button();
            this.retirerListeRecherche = new System.Windows.Forms.Button();
            this.descendreListeRecherche = new System.Windows.Forms.Button();
            this.monterRechercheListe = new System.Windows.Forms.Button();
            this.viderListeConstruction = new System.Windows.Forms.Button();
            this.retirerListeConstruction = new System.Windows.Forms.Button();
            this.descendreListeConstruction = new System.Windows.Forms.Button();
            this.monterListeConstruction = new System.Windows.Forms.Button();
            this.validerRecherche = new System.Windows.Forms.Button();
            this.listeTechnologies = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listeBatimentsInstallations = new System.Windows.Forms.ComboBox();
            this.validerBatimentConstruction = new System.Windows.Forms.Button();
            this.validerContructionRessources = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listeBatimentsRessources = new System.Windows.Forms.ComboBox();
            this.listePlanetes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageFlotte = new System.Windows.Forms.TabPage();
            this.tabPagePillage = new System.Windows.Forms.TabPage();
            this.tabPageAttaque = new System.Windows.Forms.TabPage();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.tabPageNavigateur = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.fileTechnologies = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.tabControlPillage.SuspendLayout();
            this.tabPageVueGenerale.SuspendLayout();
            this.tabPageConstruction.SuspendLayout();
            this.tabPageNavigateur.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(532, 2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 19;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(451, 2);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(75, 23);
            this.buttonModifier.TabIndex = 15;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 57);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Créer un compte ?";
            // 
            // checkBoxConnexionAuto
            // 
            this.checkBoxConnexionAuto.AutoSize = true;
            this.checkBoxConnexionAuto.Location = new System.Drawing.Point(227, 5);
            this.checkBoxConnexionAuto.Name = "checkBoxConnexionAuto";
            this.checkBoxConnexionAuto.Size = new System.Drawing.Size(137, 17);
            this.checkBoxConnexionAuto.TabIndex = 13;
            this.checkBoxConnexionAuto.Text = "Connexion automatique";
            this.checkBoxConnexionAuto.UseVisualStyleBackColor = true;
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(370, 2);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(75, 23);
            this.buttonConnexion.TabIndex = 14;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Choisir un compte";
            // 
            // comboBoxChoixCompte
            // 
            this.comboBoxChoixCompte.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxChoixCompte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoixCompte.FormattingEnabled = true;
            this.comboBoxChoixCompte.Location = new System.Drawing.Point(100, 3);
            this.comboBoxChoixCompte.Name = "comboBoxChoixCompte";
            this.comboBoxChoixCompte.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChoixCompte.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlPillage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 20;
            this.panel1.Visible = false;
            // 
            // tabControlPillage
            // 
            this.tabControlPillage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlPillage.Controls.Add(this.tabPageVueGenerale);
            this.tabControlPillage.Controls.Add(this.tabPageConstruction);
            this.tabControlPillage.Controls.Add(this.tabPageFlotte);
            this.tabControlPillage.Controls.Add(this.tabPagePillage);
            this.tabControlPillage.Controls.Add(this.tabPageAttaque);
            this.tabControlPillage.Controls.Add(this.tabPageMessages);
            this.tabControlPillage.Controls.Add(this.tabPageNavigateur);
            this.tabControlPillage.Location = new System.Drawing.Point(3, 2);
            this.tabControlPillage.Name = "tabControlPillage";
            this.tabControlPillage.SelectedIndex = 0;
            this.tabControlPillage.Size = new System.Drawing.Size(797, 598);
            this.tabControlPillage.TabIndex = 0;
            // 
            // tabPageVueGenerale
            // 
            this.tabPageVueGenerale.Controls.Add(this.label5);
            this.tabPageVueGenerale.Controls.Add(this.label4);
            this.tabPageVueGenerale.Controls.Add(this.richTextBoxResumeCompte);
            this.tabPageVueGenerale.Controls.Add(this.richTextBoxFlotte);
            this.tabPageVueGenerale.Location = new System.Drawing.Point(4, 22);
            this.tabPageVueGenerale.Name = "tabPageVueGenerale";
            this.tabPageVueGenerale.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVueGenerale.Size = new System.Drawing.Size(789, 572);
            this.tabPageVueGenerale.TabIndex = 0;
            this.tabPageVueGenerale.Text = "Vue générale";
            this.tabPageVueGenerale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Résumé du compte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mouvement des flottes";
            // 
            // richTextBoxResumeCompte
            // 
            this.richTextBoxResumeCompte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxResumeCompte.Location = new System.Drawing.Point(4, 305);
            this.richTextBoxResumeCompte.Name = "richTextBoxResumeCompte";
            this.richTextBoxResumeCompte.Size = new System.Drawing.Size(780, 264);
            this.richTextBoxResumeCompte.TabIndex = 1;
            this.richTextBoxResumeCompte.Text = "";
            // 
            // richTextBoxFlotte
            // 
            this.richTextBoxFlotte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxFlotte.Location = new System.Drawing.Point(4, 6);
            this.richTextBoxFlotte.Name = "richTextBoxFlotte";
            this.richTextBoxFlotte.ReadOnly = true;
            this.richTextBoxFlotte.Size = new System.Drawing.Size(780, 293);
            this.richTextBoxFlotte.TabIndex = 0;
            this.richTextBoxFlotte.Text = "";
            // 
            // tabPageConstruction
            // 
            this.tabPageConstruction.AutoScroll = true;
            this.tabPageConstruction.BackColor = System.Drawing.Color.LightGray;
            this.tabPageConstruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageConstruction.Controls.Add(this.fileTechnologies);
            this.tabPageConstruction.Controls.Add(this.fileConstructions);
            this.tabPageConstruction.Controls.Add(this.viderListeRecherche);
            this.tabPageConstruction.Controls.Add(this.retirerListeRecherche);
            this.tabPageConstruction.Controls.Add(this.descendreListeRecherche);
            this.tabPageConstruction.Controls.Add(this.monterRechercheListe);
            this.tabPageConstruction.Controls.Add(this.viderListeConstruction);
            this.tabPageConstruction.Controls.Add(this.retirerListeConstruction);
            this.tabPageConstruction.Controls.Add(this.descendreListeConstruction);
            this.tabPageConstruction.Controls.Add(this.monterListeConstruction);
            this.tabPageConstruction.Controls.Add(this.validerRecherche);
            this.tabPageConstruction.Controls.Add(this.listeTechnologies);
            this.tabPageConstruction.Controls.Add(this.label9);
            this.tabPageConstruction.Controls.Add(this.listeBatimentsInstallations);
            this.tabPageConstruction.Controls.Add(this.validerBatimentConstruction);
            this.tabPageConstruction.Controls.Add(this.validerContructionRessources);
            this.tabPageConstruction.Controls.Add(this.label8);
            this.tabPageConstruction.Controls.Add(this.label7);
            this.tabPageConstruction.Controls.Add(this.listeBatimentsRessources);
            this.tabPageConstruction.Controls.Add(this.listePlanetes);
            this.tabPageConstruction.Controls.Add(this.label6);
            this.tabPageConstruction.Controls.Add(this.label3);
            this.tabPageConstruction.Controls.Add(this.label2);
            this.tabPageConstruction.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tabPageConstruction.Location = new System.Drawing.Point(4, 22);
            this.tabPageConstruction.Name = "tabPageConstruction";
            this.tabPageConstruction.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConstruction.Size = new System.Drawing.Size(789, 572);
            this.tabPageConstruction.TabIndex = 1;
            this.tabPageConstruction.Text = "Construction";
            // 
            // fileConstrucions
            // 
            this.fileConstructions.FormattingEnabled = true;
            this.fileConstructions.Location = new System.Drawing.Point(163, 105);
            this.fileConstructions.Name = "fileConstrucions";
            this.fileConstructions.Size = new System.Drawing.Size(193, 212);
            this.fileConstructions.TabIndex = 24;
            // 
            // viderListeRecherche
            // 
            this.viderListeRecherche.Location = new System.Drawing.Point(891, 245);
            this.viderListeRecherche.Name = "viderListeRecherche";
            this.viderListeRecherche.Size = new System.Drawing.Size(75, 23);
            this.viderListeRecherche.TabIndex = 23;
            this.viderListeRecherche.Text = "Tout retirer";
            this.viderListeRecherche.UseVisualStyleBackColor = true;
            // 
            // retirerListeRecherche
            // 
            this.retirerListeRecherche.Location = new System.Drawing.Point(891, 216);
            this.retirerListeRecherche.Name = "retirerListeRecherche";
            this.retirerListeRecherche.Size = new System.Drawing.Size(75, 23);
            this.retirerListeRecherche.TabIndex = 22;
            this.retirerListeRecherche.Text = "Retirer";
            this.retirerListeRecherche.UseVisualStyleBackColor = true;
            // 
            // descendreListeRecherche
            // 
            this.descendreListeRecherche.Location = new System.Drawing.Point(891, 164);
            this.descendreListeRecherche.Name = "descendreListeRecherche";
            this.descendreListeRecherche.Size = new System.Drawing.Size(75, 23);
            this.descendreListeRecherche.TabIndex = 21;
            this.descendreListeRecherche.Text = "Descendre";
            this.descendreListeRecherche.UseVisualStyleBackColor = true;
            // 
            // monterRechercheListe
            // 
            this.monterRechercheListe.Location = new System.Drawing.Point(891, 135);
            this.monterRechercheListe.Name = "monterRechercheListe";
            this.monterRechercheListe.Size = new System.Drawing.Size(75, 23);
            this.monterRechercheListe.TabIndex = 20;
            this.monterRechercheListe.Text = "Monter";
            this.monterRechercheListe.UseVisualStyleBackColor = true;
            // 
            // viderListeConstruction
            // 
            this.viderListeConstruction.Location = new System.Drawing.Point(362, 245);
            this.viderListeConstruction.Name = "viderListeConstruction";
            this.viderListeConstruction.Size = new System.Drawing.Size(75, 23);
            this.viderListeConstruction.TabIndex = 18;
            this.viderListeConstruction.Text = "Tout retirer";
            this.viderListeConstruction.UseVisualStyleBackColor = true;
            // 
            // retirerListeConstruction
            // 
            this.retirerListeConstruction.Location = new System.Drawing.Point(362, 216);
            this.retirerListeConstruction.Name = "retirerListeConstruction";
            this.retirerListeConstruction.Size = new System.Drawing.Size(75, 23);
            this.retirerListeConstruction.TabIndex = 17;
            this.retirerListeConstruction.Text = "Retirer";
            this.retirerListeConstruction.UseVisualStyleBackColor = true;
            // 
            // descendreListeConstruction
            // 
            this.descendreListeConstruction.Location = new System.Drawing.Point(362, 164);
            this.descendreListeConstruction.Name = "descendreListeConstruction";
            this.descendreListeConstruction.Size = new System.Drawing.Size(75, 23);
            this.descendreListeConstruction.TabIndex = 16;
            this.descendreListeConstruction.Text = "Descendre";
            this.descendreListeConstruction.UseVisualStyleBackColor = true;
            // 
            // monterListeConstruction
            // 
            this.monterListeConstruction.Location = new System.Drawing.Point(362, 135);
            this.monterListeConstruction.Name = "monterListeConstruction";
            this.monterListeConstruction.Size = new System.Drawing.Size(75, 23);
            this.monterListeConstruction.TabIndex = 15;
            this.monterListeConstruction.Text = "Monter";
            this.monterListeConstruction.UseVisualStyleBackColor = true;
            // 
            // validerRecherche
            // 
            this.validerRecherche.Location = new System.Drawing.Point(581, 162);
            this.validerRecherche.Name = "validerRecherche";
            this.validerRecherche.Size = new System.Drawing.Size(75, 23);
            this.validerRecherche.TabIndex = 12;
            this.validerRecherche.Text = "Ajouter";
            this.validerRecherche.UseVisualStyleBackColor = true;
            // 
            // listeTechnologies
            // 
            this.listeTechnologies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeTechnologies.FormattingEnabled = true;
            this.listeTechnologies.Location = new System.Drawing.Point(560, 135);
            this.listeTechnologies.Name = "listeTechnologies";
            this.listeTechnologies.Size = new System.Drawing.Size(121, 21);
            this.listeTechnologies.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Technologies";
            // 
            // listeBatimentsInstallations
            // 
            this.listeBatimentsInstallations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeBatimentsInstallations.FormattingEnabled = true;
            this.listeBatimentsInstallations.Location = new System.Drawing.Point(19, 260);
            this.listeBatimentsInstallations.Name = "listeBatimentsInstallations";
            this.listeBatimentsInstallations.Size = new System.Drawing.Size(121, 21);
            this.listeBatimentsInstallations.TabIndex = 9;
            // 
            // validerBatimentConstruction
            // 
            this.validerBatimentConstruction.Location = new System.Drawing.Point(32, 297);
            this.validerBatimentConstruction.Name = "validerBatimentConstruction";
            this.validerBatimentConstruction.Size = new System.Drawing.Size(75, 23);
            this.validerBatimentConstruction.TabIndex = 8;
            this.validerBatimentConstruction.Text = "Ajouter";
            this.validerBatimentConstruction.UseVisualStyleBackColor = true;
            // 
            // validerContructionRessources
            // 
            this.validerContructionRessources.Location = new System.Drawing.Point(34, 162);
            this.validerContructionRessources.Name = "validerContructionRessources";
            this.validerContructionRessources.Size = new System.Drawing.Size(75, 23);
            this.validerContructionRessources.TabIndex = 7;
            this.validerContructionRessources.Text = "Ajouter";
            this.validerContructionRessources.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Installations";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(585, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Liste de construcion des bâtiments";
            // 
            // listeBatimentsRessources
            // 
            this.listeBatimentsRessources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeBatimentsRessources.FormattingEnabled = true;
            this.listeBatimentsRessources.Location = new System.Drawing.Point(19, 135);
            this.listeBatimentsRessources.Name = "listeBatimentsRessources";
            this.listeBatimentsRessources.Size = new System.Drawing.Size(121, 21);
            this.listeBatimentsRessources.TabIndex = 4;
            // 
            // listePlanetes
            // 
            this.listePlanetes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listePlanetes.FormattingEnabled = true;
            this.listePlanetes.Location = new System.Drawing.Point(96, 17);
            this.listePlanetes.Name = "listePlanetes";
            this.listePlanetes.Size = new System.Drawing.Size(121, 21);
            this.listePlanetes.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ressources";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Liste de construcion des bâtiments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Planète";
            // 
            // tabPageFlotte
            // 
            this.tabPageFlotte.Location = new System.Drawing.Point(4, 22);
            this.tabPageFlotte.Name = "tabPageFlotte";
            this.tabPageFlotte.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFlotte.Size = new System.Drawing.Size(789, 572);
            this.tabPageFlotte.TabIndex = 2;
            this.tabPageFlotte.Text = "Flotte";
            this.tabPageFlotte.UseVisualStyleBackColor = true;
            // 
            // tabPagePillage
            // 
            this.tabPagePillage.Location = new System.Drawing.Point(4, 22);
            this.tabPagePillage.Name = "tabPagePillage";
            this.tabPagePillage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePillage.Size = new System.Drawing.Size(789, 572);
            this.tabPagePillage.TabIndex = 3;
            this.tabPagePillage.Text = "Pillage";
            this.tabPagePillage.UseVisualStyleBackColor = true;
            // 
            // tabPageAttaque
            // 
            this.tabPageAttaque.Location = new System.Drawing.Point(4, 22);
            this.tabPageAttaque.Name = "tabPageAttaque";
            this.tabPageAttaque.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAttaque.Size = new System.Drawing.Size(789, 572);
            this.tabPageAttaque.TabIndex = 4;
            this.tabPageAttaque.Text = "Attaque";
            this.tabPageAttaque.UseVisualStyleBackColor = true;
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Location = new System.Drawing.Point(4, 22);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(789, 572);
            this.tabPageMessages.TabIndex = 5;
            this.tabPageMessages.Text = "Messages";
            this.tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // tabPageNavigateur
            // 
            this.tabPageNavigateur.Controls.Add(this.webBrowser1);
            this.tabPageNavigateur.Location = new System.Drawing.Point(4, 22);
            this.tabPageNavigateur.Name = "tabPageNavigateur";
            this.tabPageNavigateur.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNavigateur.Size = new System.Drawing.Size(789, 572);
            this.tabPageNavigateur.TabIndex = 6;
            this.tabPageNavigateur.Text = "Navigateur";
            this.tabPageNavigateur.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(783, 566);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.ogame.fr", System.UriKind.Absolute);
            // 
            // listBox1
            // 
            this.fileTechnologies.FormattingEnabled = true;
            this.fileTechnologies.Location = new System.Drawing.Point(687, 105);
            this.fileTechnologies.Name = "listBox1";
            this.fileTechnologies.Size = new System.Drawing.Size(193, 212);
            this.fileTechnologies.TabIndex = 25;
            // 
            // UserControlTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBoxConnexionAuto);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChoixCompte);
            this.MinimumSize = new System.Drawing.Size(776, 507);
            this.Name = "UserControlTab";
            this.Size = new System.Drawing.Size(800, 600);
            this.panel1.ResumeLayout(false);
            this.tabControlPillage.ResumeLayout(false);
            this.tabPageVueGenerale.ResumeLayout(false);
            this.tabPageVueGenerale.PerformLayout();
            this.tabPageConstruction.ResumeLayout(false);
            this.tabPageConstruction.PerformLayout();
            this.tabPageNavigateur.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //------------------------ Attributs ------------------------

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button viderListeRecherche;
        private System.Windows.Forms.Button retirerListeRecherche;
        private System.Windows.Forms.Button descendreListeRecherche;
        private System.Windows.Forms.Button monterRechercheListe;
        private System.Windows.Forms.Button viderListeConstruction;
        private System.Windows.Forms.Button retirerListeConstruction;
        private System.Windows.Forms.Button descendreListeConstruction;
        private System.Windows.Forms.Button monterListeConstruction;
        private System.Windows.Forms.Button validerRecherche;
        private System.Windows.Forms.Button validerBatimentConstruction;
        private System.Windows.Forms.Button validerContructionRessources;

        private System.Windows.Forms.LinkLabel linkLabel1;

        private System.Windows.Forms.CheckBox checkBoxConnexionAuto;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TabControl tabControlPillage;
        private System.Windows.Forms.TabPage tabPageVueGenerale;
        private System.Windows.Forms.TabPage tabPageConstruction;
        private System.Windows.Forms.TabPage tabPageFlotte;
        private System.Windows.Forms.TabPage tabPagePillage;
        private System.Windows.Forms.TabPage tabPageAttaque;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.TabPage tabPageNavigateur;

        private System.Windows.Forms.WebBrowser webBrowser1;

        private System.Windows.Forms.RichTextBox richTextBoxResumeCompte;
        private System.Windows.Forms.RichTextBox richTextBoxFlotte;
        private System.Windows.Forms.ListBox fileConstructions;
        private System.Windows.Forms.ListBox fileTechnologies;

        private System.Windows.Forms.ComboBox listeBatimentsInstallations;
        private System.Windows.Forms.ComboBox listeTechnologies;
        private System.Windows.Forms.ComboBox comboBoxChoixCompte;
        private System.Windows.Forms.ComboBox listeBatimentsRessources;
        private System.Windows.Forms.ComboBox listePlanetes;


        //------------------------ Setters/Getters ------------------------


        public ListBox FileConstructions { get => fileConstructions; set => fileConstructions = value; }
        public ListBox FileTechnologies { get => fileTechnologies; set => fileTechnologies = value; }
        public ComboBox ListeBatimentsInstallations { get => listeBatimentsInstallations; set => listeBatimentsInstallations = value; }
        public ComboBox ListeTechnologies { get => listeTechnologies; set => listeTechnologies = value; }
        public ComboBox ComboBoxChoixCompte { get => comboBoxChoixCompte; set => comboBoxChoixCompte = value; }
        public ComboBox ListeBatimentsRessources { get => listeBatimentsRessources; set => listeBatimentsRessources = value; }
        public ComboBox ListePlanetes { get => listePlanetes; set => listePlanetes = value; }
    }
}
