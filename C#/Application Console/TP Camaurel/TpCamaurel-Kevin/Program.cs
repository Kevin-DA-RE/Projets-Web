using System;
using GestionNoteFrais;

namespace TpCamaurel_Kevin
{
    class Program
    {
        static void Main(string[] args)
        {
            Commercial c;
            c = new Commercial("Dupond", "Jean", 7, 'B');
            Console.WriteLine(c.ToString());

            DateTime d = new DateTime(2020, 02, 23);
            NoteFrais nf = new NoteFrais(1, d, c);
            Console.WriteLine(nf.ToString());

            FraisTransport ft = new FraisTransport(2, d, c, 100);
            Console.WriteLine(ft.ToString());

            RepasMidi fr = new RepasMidi(3, d, c, 35);
            Console.WriteLine(fr.ToString());

            Nuitee fn = new Nuitee(4, d, c, 46, '2');
            Console.WriteLine(fn.ToString());
        }
    }
}
