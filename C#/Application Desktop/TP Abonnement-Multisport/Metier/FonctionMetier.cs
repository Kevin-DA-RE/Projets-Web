using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Metier
{
    class FonctionMetier
    {

        #region Pour l'id de la fréquence
        public static int IDFrequence(int numJour)
        {
            return numJour;
        }
        #endregion

        #region Prix des sports
        public static float CalculActivites(int nbsport)
        {
            return nbsport * 100;
        }
        #endregion

        #region Calcul du montant
        public static float CalculMonant(float PrixAbonnement, float Majo_jour, float Prixsport)
        {
            return (PrixAbonnement * Majo_jour) + Prixsport;
        }
        #endregion

        #region Fonction pour enlever les caractères non autorisés
        public static string CleanString(string dirtyString)
        {
            string removeChars = "=?&^$#@!/()+-,:;<>’\'-_*";
            string result = dirtyString;

            foreach (char c in removeChars)
            {
                result = result.Replace(c.ToString(), string.Empty);
            }

            return result;
        }
        #endregion

        #region Fonction pour enlever les caractères non autorisés pour le portable
        public static string CleanPortable(string dirtyString)
        {
            string removeChars = "=?&^$#@!/(),:;<>’\'_*";
            string result = dirtyString;

            foreach (char c in removeChars)
            {
                result = result.Replace(c.ToString(), string.Empty);
            }

            return result;
        }
        #endregion


    }
}
