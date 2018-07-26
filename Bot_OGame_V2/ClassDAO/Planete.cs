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

        private Ressources ressources; // Les batiments production minerais
        private Installations installations; // Les batiments "installations"
        private static Recherche recherche; // Les Technologies 
        private Flotte flotte; // Flotte présente sur la planete
        private Defense defense; // défense présente sur la planète   
        
    }
}
