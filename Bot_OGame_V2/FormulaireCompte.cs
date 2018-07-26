using Bot_OGame_V2.Traitement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bot_OGame_V2
{
    public partial class FormulaireCompte : Form
    {
        public FormulaireCompte()
        {
            InitializeComponent();
        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            Controler utilisateur = new Controler();

            int valeurRetour = utilisateur.CreationCompte(textBoxPseudo.Text, textBoxIdentifiant.Text, textBoxMdp.Text, textBoxAdresseServeur.Text);

            switch (valeurRetour)
            {
                case 0:
                    labelErreurCreationCompte.Text = "Tous les champs doivent être remplis";
                    break;
                case 1:
                    labelErreurCreationCompte.Text = "Le pseudo ne peut pas contenir\nde caractère spéciaux";                    
                    break;
                case 2:
                    labelErreurCreationCompte.Text = "Adresse Email Invalide";
                    break;
                case 3:
                    labelErreurCreationCompte.Text = "Ce compte existe déjà. \nVous devez créer un compte par univers";
                    break;
                case 4:
                    this.Dispose();
                    break;
            }
        }

        private void ButtonValiderModif_Click(object sender, EventArgs e)
        {

        }
    }
}
