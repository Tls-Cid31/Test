using System;
using System.Windows.Forms;

namespace Bot_OGame_V2
{
    public partial class UserControlTab : UserControl
    {
        public UserControlTab()
        {
            InitializeComponent();

            Bot_OGame_V2.ClassDAO.Ressources a = new ClassDAO.Ressources();

            fileConstructions.Items.Add("test");
            //a.test();
        }

        private void ButtonConnexion_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        
    }
}
