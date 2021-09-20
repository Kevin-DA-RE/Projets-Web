/*================================================================================*
* Programme : Abonnement multi-sport
*
* But : poursuite de la solution abo multi-sport et création de la persistance des données et création de l'architecture multicouche
*
* Auteur : Da Re Kevin et Rochet Alexia
* 
* Date : 22/02/2021
*
*================================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Metier
{
    public class ReqMetier
    {
        // chaine de connection pour la base de données
        private const string chaineConnexion = "SERVER=localhost; DATABASE=abomultisport; UID=root; PASSWORD=mysql";

        #region Connexion BD
        public static void connexionBase()
        {
            PasserelleMySQL.ouvertureConnexion(chaineConnexion);
        }
        #endregion

        #region Deconnexion BD
        public static void deconnexionBase()
        {
            PasserelleMySQL.fermetureConnexion();
        }
        #endregion

        #region Ajouter un abonné
        public static void AjoutAbonne(string nom, string prenom, string dateNais, string sexe, string adresse, string cp, string ville, string tel_fixe, string portable, string mail)
        {
            string AjoutAbonne = "INSERT into abonne(nom, prenom, date_naissance, sexe, adresse, code_postal, ville, tel_fixe, portable,";
            AjoutAbonne += " mail) VALUES('" + nom + "', '" + prenom + "', '" + dateNais + "', '" + sexe + "', '" + adresse + "',";
            AjoutAbonne += " '" + cp + "', '" + ville + "', '" + tel_fixe + "', '" + portable + "', '" + mail + "');";
            PasserelleMySQL.executionMaj(AjoutAbonne);
        }
        #endregion

        #region Ajouter cotisation
        public static void AjoutCotis(string datedeb, string Payment, float montant, string IDAbo, string idabonnement, string idfreq)
        {
            string ReqAjCotis = "INSERT INTO cotisation(cotisation.date_debut, cotisation.type_reglement, cotisation.montant, cotisation.id_abonne, cotisation.id_abonnement, cotisation.id_frequence)";
            ReqAjCotis += " VALUES('" + datedeb + "','" + Payment + "','" + montant + "','" + IDAbo + "','" + idabonnement + "','" + idfreq + "');";
            PasserelleMySQL.executionMaj(ReqAjCotis);
        }
        #endregion

        #region Choix abonnement
        public static DataTable ChoixAbonnement(string TypeAbonnement)
        {
            string ReqPrixAbonnelent = "SELECT abonnement.prix from abonnement WHERE abonnement.type='" + TypeAbonnement + "';";
            return PasserelleMySQL.executionRequete(ReqPrixAbonnelent);
        }
        #endregion

        #region Afficher tous les abonnés
        public static DataTable affichAbonne()
        {
            string reqAfficAbo = "SELECT id, CONCAT(nom,' ', prenom) AS 'Identifiant' FROM abonne ORDER BY nom and prenom;";
            return PasserelleMySQL.executionRequete(reqAfficAbo);
        }
        #endregion

        #region Afficher Données Abonné
        public static DataTable dataAbonne(string id)
        {
            string reqDataAbonne = "SELECT `nom`, `prenom`, `date_naissance`, `sexe`, `adresse`, `code_postal`,";
            reqDataAbonne += "`ville`, `tel_fixe`, `portable`, `mail` FROM `abonne` WHERE abonne.id='" + id + "';";
            return PasserelleMySQL.executionRequete(reqDataAbonne);
        }
        #endregion

        #region Requête pour l'id de l'abonne
        public static DataTable ReqAbonnement(string nom, string prenom, string dateNais, string sexe, string adresse, string cp, string ville, string tel_fixe, string portable, string mail)
        {
            string ReqAbonnement = "select abonne.id from abonne WHERE nom='" + nom + "'and prenom='" + prenom + "'and date_naissance='" + dateNais + "' and";
            ReqAbonnement += "  sexe='" + sexe + "'and adresse='" + adresse + "' and code_postal='" + cp + "' and ville='" + ville + "' and";
            ReqAbonnement += "  tel_fixe='" + tel_fixe + "' and portable='" + portable + "' and mail='" + mail + "';";
            return PasserelleMySQL.executionRequete(ReqAbonnement);
        }
        #endregion

        #region Choix fréquence
        public static DataTable ChoixFrequence(int numJour)
        {
            string ReqMajoJour = "SELECT frequence.majoration FROM frequence WHERE frequence.id='" + numJour + "';";
            return PasserelleMySQL.executionRequete(ReqMajoJour);
        }
        #endregion

        #region Req pour id de l'abonnement
        public static DataTable ReqAbonnement (string type)
        {
            string ReqMajoJour = "SELECT id FROM abonnement WHERE type ='" + type + "';";
            return PasserelleMySQL.executionRequete(ReqMajoJour);
        }
        #endregion

        #region Rechercher id de l'activité
        public static DataTable rechAct(string nom)
        {
            string rechAct = "SELECT id FROM activite WHERE activite.nom = '" + nom + "';";
            return PasserelleMySQL.executionRequete(rechAct);
        }
        #endregion

        #region Ajouter un lien entre l'activité et la cotisation
        public static void AjoutActivite (string idAct, string idCotis)
        {
            string AjAct = "INSERT INTO dependre value ('" + idAct + "', '" + idCotis + "');";
            PasserelleMySQL.executionMaj(AjAct);
        }
        #endregion

        #region Rechercher Id Cotisation
        public static DataTable rechCotis(string date, string reg, float mont, string idAbo, string idAbonnement, string idFreq)
        {
            string rechCotis = "SELECT id FROM cotisation WHERE cotisation.date_debut= '" + date +"'";
            rechCotis += " AND cotisation.type_reglement= '" + reg + "' AND cotisation.montant= '";
            rechCotis += +mont + "' AND cotisation.id_abonne= '" + idAbo + "' AND cotisation.id_abonnement= '" + idAbonnement +"'";
            rechCotis += " AND cotisation.id_frequence= '" + idFreq + "';";
            return PasserelleMySQL.executionRequete(rechCotis);
        }
        #endregion

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
