using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_OGame_V2.Class
{
    class Technologie : Construction
    {
        //------------------------ Attributs ------------------------

        private int niveau;


        //------------------------ Setters/Getters ------------------------

        public override string Nom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override DateTime TempsConstruction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Ressources Cout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Niveau { get => niveau; set => niveau = value; }
    }
}
