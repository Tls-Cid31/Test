using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Bot_OGame_V2.ClassDAO
{
    class Compte
    {
        //------------------------ Attributs ------------------------

        private string adresseMail;
        private string motDePasse;
        private string univers;



        public Compte() { }

        public int CreationCompte(string adresseEmail, string pseudo, string motDePasse, string univers)
        {
            string nomDossier = "Utilisateur";

            // Vérifie que tous les champs soient valide
            if (adresseEmail != String.Empty && pseudo != String.Empty && motDePasse != String.Empty && univers != String.Empty)
            {        
                Regex regPseudo = new Regex("^[a-zA-Z0-9]*$");
                Regex regEmail = new Regex("^((([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+(\\.([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+)*)|((\\x22)((((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(([\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x7f]|\\x21|[\\x23-\\x5b]|[\\x5d-\\x7e]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(\\\\([\\x01-\\x09\\x0b\\x0c\\x0d-\\x7f]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF]))))*(((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(\\x22)))@((([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.)+(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.?$");

                if (!regEmail.IsMatch(adresseEmail))
                {// Vérifie qu'il n'y ait pas de caracère spéciaux dans la chaine de caractère
                    return 2;
                }

                if (!regPseudo.IsMatch(pseudo))
                {// Vérifie qu'il n'y ait pas de caracère spéciaux dans la chaine de caractère
                    return 3;
                }

                // string nomFichier = pseudo + ".txt";

                if (!Directory.Exists(nomDossier))
                {// Vérifie que le dossier qui contiendra les fichiers de compte existe.
                 // Sinon on le créer
                    Directory.CreateDirectory(nomDossier);
                }

                if (File.Exists(nomDossier + @"\" + pseudo))
                {// Vérifie si le dossier existe. Si oui, l'utilisateur devra choisir un autre nom d'utilisateur
                    return 4;
                }

                else
                {// Créer ule nouveau dossier es écris les données dans le fichiers
                    Directory.CreateDirectory(nomDossier + @"\" + pseudo);
                    File.WriteAllText(nomDossier + @"\" + pseudo + @"\parametreCompte.txt", adresseEmail + "\r\n" + motDePasse + "\r\n" + univers + "\r\n");
                    return 0; // Tout est ok
                }
            }

            else
            {// Si au moins un des champs est vide, averti l'utilisateur et n'enregistre pas les données
                return 1;
            }
        }


        //------------------------ Setters/Getters ------------------------

        public string AdresseMail { get => adresseMail; set => adresseMail = value; }
        public string MotDePasse { get => motDePasse; set => motDePasse = value; }
        public string Univers { get => univers; set => univers = value; }
    }
}
