using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_OGame_V2.ClassDAO
{
    class Energetique : BatimentTechnologie
    {
        public override string Nom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override DateTime TempsConstruction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Minerais Cout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Niveau { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
