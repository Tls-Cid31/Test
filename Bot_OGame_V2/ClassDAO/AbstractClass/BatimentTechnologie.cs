using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_OGame_V2.ClassDAO
{
    abstract class BatimentTechnologie
    {
        //------------------------ Attributs ------------------------

        private String nom;
        private DateTime tempsConstruction;
        private Minerais cout;
        private int niveau;
        
        public abstract void Construire();
        public abstract void Detruire();
    }
}
