using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_OGame_V2.ClassDAO
{
    class Planete
    {
        //------------------------ Attributs ------------------------

        private string nomPlanete; // Nom de la planète 
        private int diametre; // Taille de la planète
        private int temperatureMax; // Température maximum sur la planète
        private int temperatureMin; // Température minimim sur la planète 
        private Position positionPlanete; // Coordonnées de la planète
        private Minerais minerais; // Ressources présentes sur la planète
        private Ressources ressources; // Batiments production minerais
        private Installations installations; // Les batiments "installations"
        private Recherche recherche;
        private Flotte flotte;
        private Defense defense;
   
        
    }
}
