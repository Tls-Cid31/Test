using Bot_OGame_V2.ClassDAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bot_OGame_V2.Traitement
{
    class Controler
    {
        public int CreationCompte(string pseudo, string adresseEmail, string mdp, string univers)
        {
            string nomDossier = "Utilisateur";

            // Vérifie que tous les champs soient valide
            if (pseudo != String.Empty && adresseEmail != String.Empty && mdp != String.Empty && univers != String.Empty)
            {
                string patternPseudo = ("^[a-zA-Z0-9]*$");
                string pattervnEmail = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

                if (!Regex.IsMatch(pseudo, patternPseudo))
                {// Vérifie qu'il n'y ait pas de caracère spéciaux dans le pseudo
                    return 1;
                }

                if (!Regex.IsMatch(adresseEmail, pattervnEmail))
                {// Vérifie que l'adresse mail soit voalide
                    return 2;
                }               

                // string nomFichier = pseudo + ".txt";

                if (!Directory.Exists(nomDossier))
                {// Vérifie que le dossier qui contiendra les fichiers de compte existe.
                 // Sinon on le créer
                    Directory.CreateDirectory(nomDossier);
                }

                if (File.Exists(nomDossier + @"\" + pseudo))
                {// Vérifie si le dossier existe. Si oui, l'utilisateur devra choisir un autre nom d'utilisateur
                    return 3;
                }

                else
                {// Créer ule nouveau dossier es écris les données dans le fichiers
                    Directory.CreateDirectory(nomDossier + @"\" + pseudo);
                    File.WriteAllText(nomDossier + @"\" + pseudo + @"\parametreCompte.txt", adresseEmail + "\r\n" + mdp + "\r\n" + univers + "\r\n");
                    return 4; // Tout est ok
                }
            }

            else
            {// Si au moins un des champs est vide, averti l'utilisateur et n'enregistre pas les données
                return 0;
            }
        }
    }
}
