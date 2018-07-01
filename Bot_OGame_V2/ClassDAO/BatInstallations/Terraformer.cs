using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_OGame_V2.ClassDAO
{
    class Terraformer : BatimentTechnologie
    {
        private String nom;
        private DateTime tempsConstruction;
        private Minerais cout;
        private int niveau;
        
        public override void Construire()
        {
            throw new NotImplementedException();
        }

        public override void Detruire()
        {
            throw new NotImplementedException();
        }
    }
}
