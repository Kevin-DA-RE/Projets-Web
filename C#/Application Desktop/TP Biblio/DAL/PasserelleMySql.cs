using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace DAL
{
    public class PasserelleMySql
    {
        public static MySqlConnection Connexion;

        public static void OuvertureConnexion(string ChaineConnexion)
        {
            Connexion = new MySqlConnection(ChaineConnexion);
            Connexion.Open();
        }
        public static void FermetureConnexion()
        {
            Connexion.Close();
        }
        public static DataTable ExecutionRequete(string req)
        {
            // Utilisation d'un DataAdapter
            MySqlDataAdapter unDataAdapter = new MySqlDataAdapter(req, PasserelleMySql.Connexion);
            // Remplissage du DataSet avec le résultat du DataAdapter
            DataSet unDataSet = new DataSet();
            unDataAdapter.Fill(unDataSet);
            //Sélection du 1er DataTable
            DataTable unDataTable = unDataSet.Tables[0];
            return unDataTable;
        }
        public static void ExecutionMaj(string req)
        {   // type de maj : insertion, suppression, modification
            MySqlCommand cmdMaj = new MySqlCommand(req, PasserelleMySql.Connexion);
            cmdMaj.ExecuteNonQuery();
        }
    }
}

