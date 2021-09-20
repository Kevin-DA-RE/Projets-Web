using System;

namespace TD1_EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Données
            int Indice;
            float Sal_Brut, Sal_net, Val_Ret;
            const float Ret_Sal = 0.1f, Maj_Sal = 50f, Val_Point = 3f;



            //Calcul du salaire
            Console.WriteLine("        SALAIRE DU FONCITONNAIRE\n\n\n");
            Console.Write("Indice: ");
            Indice = int.Parse(Console.ReadLine());

            Sal_Brut = Indice * Val_Point;
            Sal_net = Sal_Brut *(1- Ret_Sal);
            Val_Ret = Sal_Brut - Sal_net;

            if (Sal_net > 600)
            {
                Sal_net += Maj_Sal;
                
            }
            //Affichage des résultats
            Console.WriteLine("Le salaire brut du fonctionnaire est: " + Sal_Brut + " euros");
            Console.WriteLine("Le montant de la retenue est: " + Val_Ret + " euros");
            Console.WriteLine("Le salaire du fonctionnaire est: " + Sal_net + " euros");                       

        }
    }
}
