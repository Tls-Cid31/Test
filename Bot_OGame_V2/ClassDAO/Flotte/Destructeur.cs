using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_OGame_V2.ClassDAO
{
    class Destructeur : VaisseauDefenses
    {
        protected Destructeur(string nom, int nombre, Minerais cout, DateTime tempsConstruction) : base(nom, nombre, cout, tempsConstruction)
        {
        }

        public override void Construire()
        {
            throw new NotImplementedException();
        }
    }
}
