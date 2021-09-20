using System;

namespace CP03_TD1_EX2
{
    class Program
    {   
        static float CalculPrime(int Ca)
        {
            const float Tx1 = 0, Tx2 = 0.03f, Tx3 = 0.05f;
            float Tx, Prime;

            if (Ca < 10000)
                Tx = Tx1;
            else if (Ca < 20000)
                Tx = Tx2;
            else Tx = Tx3;

            Prime = Ca * Tx;

            return Prime;
        }
        static void Main(string[] args)
        {
            float Fixe, Salaire;
            int ChAff;

            Console.Write("Fixe: ");
            Fixe = float.Parse(Console.ReadLine());

            Console.Write("CA: ");
            ChAff = int.Parse(Console.ReadLine());

            Salaire = Fixe + CalculPrime(ChAff);
            Console.WriteLine("Salaire: " + Salaire + " euros avec une prime de " + CalculPrime(ChAff).ToString("0.00") + " euros");

        }
        
    }
}
