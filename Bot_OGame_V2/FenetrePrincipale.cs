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
    public partial class FenetrePrincipale : Form
    {
        public FenetrePrincipale()
        {
            InitializeComponent();
        }

        private void NouveauCompteMenu_Click(object sender, EventArgs e)
        {
            FormulaireCompte formulaire = new FormulaireCompte();
            formulaire.Show();
        }

        private void ModifierCompteMenu_Click(object sender, EventArgs e)
        {
            FormulaireCompte formulaire = new FormulaireCompte();
            formulaire.panel1.Visible = true;
            formulaire.Text = "Formulaire de modification";
            formulaire.Show();

        }        
    }
}
