using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_OGame_V2.ClassDAO
{
    abstract class Construction
    {
        //------------------------ Attributs ------------------------

        private String nom;
        private DateTime tempsConstruction;
        private Ressources cout;

        public abstract string Nom { get; set; }
        public abstract DateTime TempsConstruction { get; set; }
        public abstract Ressources Cout { get ; set ; }
    }
}
