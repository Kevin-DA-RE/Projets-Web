using System;

namespace TD2_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, F, Cpt;
            Console.Write("Entrez une valeur de N: ");
            N = int.Parse(Console.ReadLine());

            if(N<=0)
            {
                Console.WriteLine("Erreur");
                Console.WriteLine("Veuillez resaisir une valeur de N: ");
                N = int.Parse(Console.ReadLine());
            }
            F = 1;
            for (Cpt = 1; Cpt <= N; Cpt ++)
            {
                F = F * Cpt;
                Console.WriteLine("La factorielle de N est: " + F);

            }
                           
        }
    }
}
