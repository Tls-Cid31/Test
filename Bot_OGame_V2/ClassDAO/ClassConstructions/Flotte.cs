using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_OGame_V2.Class
{
    class Flotte : Construction
    {
        //------------------------ Attributs ------------------------

        private int nombre;


        //------------------------ Setters/Getters ------------------------

        public override string Nom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override DateTime TempsConstruction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Nombre { get => nombre; set => nombre = value; }
        public override Ressources Cout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
