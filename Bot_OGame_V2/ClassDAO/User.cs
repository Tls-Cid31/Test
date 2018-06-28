using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_OGame_V2.ClassDAO
{
    class User
    {
        //------------------------ Attributs ------------------------

        private String pseudo;
        private String mail;
        private String pass;
        private String univers;


        //------------------------ Setters/Getters ------------------------

        public string Pseudo { get => pseudo; set => pseudo = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Univers { get => univers; set => univers = value; }
    }
}
