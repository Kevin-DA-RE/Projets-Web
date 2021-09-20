using System;

namespace CP03_TD2_TEST
{
    class Program
    {
        class Eleve
        {
            private string Nom;
            private float NoteOral, NoteEcrit, moy, coef1, coef2;
            

            public Eleve(string pNom, float pNoteOral, float pNoteEcrit)
            {
                Nom = pNom;
                NoteOral = pNoteOral;
                NoteEcrit = pNoteEcrit;
            }

            

            public string getNom()
            {
                return Nom;
            }
            public float getNoteOral()
            {
                return NoteOral;
            }
            public float getNoteEcrit()
            {
                return NoteEcrit;
            }
            public float moyenne()
            {
                int coef1 = 1;
                int coef2 = 2;
                float moy = ((NoteOral * coef1) + (NoteEcrit * coef2));
                return moy;
            }
            
        }
        class Classe
        {
           private string = nomSection;
           private Eleve[] tbEleve = new Eleve[5];
           private int nbE = 0;



        }
        static void Main(string[] args)
        {
            Eleve eleve = new Eleve("Grangier", 15f, 11f);
            Console.WriteLine("L'élève " + eleve.getNom() + " a pour moyenne: " + ((eleve.getNoteOral() + eleve.getNoteEcrit()) / 2));

            Console.WriteLine("L'élève " + eleve.getNom() + " a pour moyenne: " + eleve.moyenne());
        }
    }
}
