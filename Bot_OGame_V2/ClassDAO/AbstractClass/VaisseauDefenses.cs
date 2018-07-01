using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_OGame_V2.ClassDAO
{
    abstract class VaisseauDefenses
    {
        private String nom;
        private int nombre;
        private Minerais cout;
        private DateTime tempsConstruction;

        protected VaisseauDefenses(string nom, int nombre, Minerais cout, DateTime tempsConstruction)
        {
            this.nom = nom;
            this.nombre = nombre;
            this.cout = cout;
            this.tempsConstruction = tempsConstruction;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Nombre { get => nombre; set => nombre = value; }
        public DateTime TempsConstruction { get => tempsConstruction; set => tempsConstruction = value; }
        public Minerais Cout { get => cout; set => cout = value; }

        public abstract void Construire();
    }
}
