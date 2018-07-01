using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_OGame_V2.ClassDAO
{
    class Ressources
    {
        private MineMetal mineMetal;
        private MineCristal mineCristal;
        private SynthetiseurDeuterium synthetiseurDeuterium;
        private CentraleSolaire centraleSolaire;
        private CentraleFusion centraleFusion;
        private HangarMetal hangarMetal;
        private HangarCristal hangarCristal;
        private ReservoirDeuterium reservoirDeuterium;

        public void test()
        {
            mineCristal = new MineCristal();
            mineCristal.Niveau = 5;

            Console.WriteLine(mineCristal.Niveau);
        }
    }
}
