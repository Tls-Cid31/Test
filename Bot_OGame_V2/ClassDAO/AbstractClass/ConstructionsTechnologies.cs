using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_OGame_V2.ClassDAO
{
    abstract class ConstructionsTechnologies
    {
        //------------------------ Attributs ------------------------

        private String nom;
        private DateTime tempsConstruction;
        private Minerais cout;
        private int niveau;

        public string Nom { get => nom; set => nom = value; }
        public DateTime TempsConstruction { get => tempsConstruction; set => tempsConstruction = value; }
        public int Niveau { get => niveau; set => niveau = value; }
        internal Minerais Cout { get => cout; set => cout = value; }

        public void Construire() { }
        public void Detruire() { }
        
    }
}
