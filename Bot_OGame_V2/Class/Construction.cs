using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_OGame_V2.Class
{
    abstract class Construction
    {
        //------------------------ Attributs ------------------------

        String nom;
        int niveau;
        DateTime tempsConstruction;

        public abstract string Nom { get; set; }
        public abstract int Niveau { get; set; }
        public abstract DateTime TempsConstruction { get; set; }
    }
}
