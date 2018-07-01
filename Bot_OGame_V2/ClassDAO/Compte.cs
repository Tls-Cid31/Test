using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_OGame_V2.ClassDAO
{
    class Compte
    {
        //------------------------ Attributs ------------------------

        private string pseudo; // Pseudo du compte
        private string adresseMail; // Adresse de connexion
        private string motDePasse; // Mot de passe
        private string univers; // Univers de jeu

        private List<Planete> planete; // Liste des planètes du compte


        //------------------------ Methodes ------------------------

        public void AjouterPlanete()
        {
           
        }
        


        //------------------------ Setters/Getters ------------------------

        public string Pseudo { get => pseudo; set => pseudo = value; }
        public string AdresseMail { get => adresseMail; set => adresseMail = value; }
        public string MotDePasse { get => motDePasse; set => motDePasse = value; }
        public string Univers { get => univers; set => univers = value; }
    }
}
