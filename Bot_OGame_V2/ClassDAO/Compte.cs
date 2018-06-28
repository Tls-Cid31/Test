using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_OGame_V2.Class
{
    class Compte
    {
        //------------------------ Attributs ------------------------

        private string pseudo;
        private string adresseMail;
        private string motDePasse;
        private string univers;


        //------------------------ Setters/Getters ------------------------

        public string Pseudo { get => pseudo; set => pseudo = value; }
        public string AdresseMail { get => adresseMail; set => adresseMail = value; }
        public string MotDePasse { get => motDePasse; set => motDePasse = value; }
        public string Univers { get => univers; set => univers = value; }
    }
}
