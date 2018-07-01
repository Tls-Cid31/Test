using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_OGame_V2.ClassDAO
{
    class Position
    {
        private int galaxie;
        private int systemeSolaire;
        private int planete;

        public int Galaxie { get => galaxie; set => galaxie = value; }
        public int SystemeSolaire { get => systemeSolaire; set => systemeSolaire = value; }
        public int Planete { get => planete; set => planete = value; }
    }
}
