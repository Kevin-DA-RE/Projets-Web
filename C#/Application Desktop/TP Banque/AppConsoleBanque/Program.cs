/*==========================================================================
* Programme: AppConsoleBanque
*
*Date Création:
*Date dernière modification:
*
*Description : test de la DLL libBanque
*
*Auteur : KD
*
*===========================================================================*/

using System;
using libBanque;

namespace AppConsoleBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création des comptes
            Console.WriteLine("Création des comptes ...");
            CompteBancaire cbPatrick = new CompteBancaire("0211651079B", "M. JANE Patrick");
            CompteBancaire cbTeresa = new CompteBancaire("1231212312D", "Mle LISBON Teresa", 1500.00m);
            // Consultation des comptes avant opérations
            Console.WriteLine();
            Console.WriteLine("Consulation du compte " + cbPatrick.NumCompte + " de " + cbPatrick.NomTitulaire + " :");
            Console.WriteLine(" -> Solde : " + cbPatrick.SoldeCompte + " Euros");
            Console.WriteLine("Consulation du compte " + cbTeresa.NumCompte + " de " + cbTeresa.NomTitulaire + " :");
            Console.WriteLine(" -> Solde : " + cbTeresa.SoldeCompte + " Euros");
            // Dans sa grande gentillesse, Teresa débite 500 Euros de son compte pour les donner à Patrick ...
            Console.WriteLine("\nDébiter le compte de Mle LISBON de 500 Euros :");
            if (!cbTeresa.DebiterCompte(500.0m)) // Si l'opération de débit s'est mal passée
                Console.WriteLine(" -> Opération impossible pour insuffisance de solde !");
            else
            {
                Console.WriteLine(" -> Ok pour créditer le compte de M. JANE de 400 Euros :");
                // ... ce qui permet à Patrick de créditer son compte de 400 Euros (il a perdu 100 Euros au jeu)
                cbPatrick.CrediterCompte(400.0m);
            }
            // Consultation des comptes après opérations
            Console.WriteLine();
            Console.WriteLine("Consultation du compte " + cbTeresa.NumCompte + " de " + cbTeresa.NomTitulaire + " :");
            Console.WriteLine(" -> Solde : " + cbTeresa.SoldeCompte + " Euros");
            Console.WriteLine("Consultation du compte " + cbPatrick.NumCompte + " de " + cbPatrick.NomTitulaire + " :");
            Console.WriteLine(" -> Solde : " + cbPatrick.SoldeCompte + " Euros");

            /*cbPatrick.NomTitulaire = "kevin";
            Console.WriteLine("Consultation du compte " + cbPatrick.NumCompte + " de " + cbPatrick.NomTitulaire + " :");*/

            /*cbTeresa.DebiterCompte(1600m);
            if (!cbTeresa.DebiterCompte(1600.0m)) // Si l'opération de débit s'est mal passée
                Console.WriteLine(" -> Opération impossible pour insuffisance de solde !");
            Console.WriteLine(" -> Solde : " + cbTeresa.SoldeCompte + " Euros");*/

        }
    }
}
