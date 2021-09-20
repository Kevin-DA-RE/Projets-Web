/*================================================================================*
* Programme : Abonnement multi-sport
*
* But : poursuite de la solution abo multi-sport et création de la persistance des données et création de l'architecture multicouche
*
* Auteur : Da Re Kevin et Rochet Alexia
* 
* Date : 09/02/2021
*
*================================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class PasserelleMySQL
    {
        public static MySqlConnection connexion;

        #region Ouverture connexion
        public static void ouvertureConnexion(string chaineConnexion)
        {
            connexion = new MySqlConnection(chaineConnexion);
            connexion.Open();
        }
        #endregion

        #region Fermeture connexion
        public static void fermetureConnexion()
        {
            connexion.Close();
        }
        #endregion

        #region Execution req normale
        public static DataTable executionRequete(string req)
        {
            // Utilisation d'un DataAdapter
            MySqlDataAdapter unDataAdapter = new MySqlDataAdapter(req, PasserelleMySQL.connexion);
            // Remplissage du DataSet avec le resultat du DataAdapter
            DataSet unDataSet = new DataSet();
            unDataAdapter.Fill(unDataSet);
            //Selection du 1er DataTable
            DataTable unDataTable = unDataSet.Tables[0];
            return unDataTable;
        }
        #endregion

        #region Execution req princ
        public static void executionMaj(string req)
        {   // type de maj : insertion, suppression, modification
            MySqlCommand cmdMaj = new MySqlCommand(req, PasserelleMySQL.connexion);
            cmdMaj.ExecuteNonQuery();
        }
        #endregion

    }
}
