using System;

namespace CP03_TD2_EX1_Eleves
{
    class Program
    {
        class Eleve
        {
            private string Nom;
            private float NoteOral, NoteEcrit;

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
            public float getMoyenne()
            {
                int coeff1 = 1;
                int coeff2 = 2;
                float moy = ((NoteEcrit * coeff2) + (NoteOral * coeff1)) / 3;
                return moy;
            }
            public bool estMeilleur(Eleve El)
            {
                if ((this.getMoyenne() > El.getMoyenne()))
                    return true;
                else return false;
            }

        }
        class Equipe
        {
            private string nomSection;
            private Eleve[] tbEleve = new Eleve[5];
            private int nbEleve = 0;

            public Equipe(string pNomSection)
            {
                nomSection = pNomSection;
            }

            public string getNomSection() // accesseur
            {
                return nomSection;
            }

            public void ajoutEleve(Eleve e) // void car on ne retourne rien
            {
                if (nbEleve < 5)
                {
                    tbEleve[nbEleve] = e; // e = Instance de la classse ELeve que l'on introduit dans la classe Equipê
                    nbEleve++;


                }
                else Console.WriteLine("Section complete");
            }

            public int effectifEquipe()
            {
                return nbEleve;
            }

            public Eleve leaderEquipe()
            {
                float moyMax = 0;
                Eleve e = tbEleve[0]; // D2claration du Premier élève du tableau
                for (int i = 0; i < nbEleve; i++)
                {
                    if (tbEleve[i].getMoyenne() >= moyMax)
                    {
                        moyMax = tbEleve[i].getMoyenne();
                        e = tbEleve[i];
                    }
                }
                return e;
            }

            public float moyenneEquipe()
            {
                float moyEquipe = 0;
                for (int i = 0; i < nbEleve; i++)
                {
                    moyEquipe += tbEleve[i].getMoyenne();
                }
                return (moyEquipe / nbEleve);

            }
            static void Main(string[] args)
            {
                Console.WriteLine("Bonjour !");

               
                Eleve e3 = new Eleve("Guichard", 14f, 18f);
                Eleve e4 = new Eleve("Coulon", 18f, 13f);
                Eleve e5 = new Eleve("Pierrebenoit", 14f, 15f);
                Eleve e6 = new Eleve("Kevin", 18f, 16f);



                /* Q1 ç Q6
                Console.Write("les noms des candidats: " + e1.getNom() +" "+ e2.getNom() +" "+ e3.getNom() +" "+ e4.getNom() +" "+ e5.getNom() +" "+ e6.getNom());
                Console.WriteLine("la moyenne de: " + e1.getNom() + " est de : " + e1.getMoyenne());
                Eleve Elev2 = new Eleve("Dupont", 11, 18);
                Console.WriteLine("la moyenne de " + e2.getNom() + " est de : " + e2.getMoyenne());
                Console.Write("le meilleur est : ");

                if (e1.estMeilleur(e2))
                {
                Console.Write(e1.getNom());
                 }
                 else Console.Write(e2.getNom());*/

                //Q7
                Equipe eq = new Equipe("CDA"); // Déclaration d'une variable eq dans la nvelle classe Equipe
                Eleve e = new Eleve("Da Re", 10f, 13f);
                Eleve e2 = new Eleve("Dupont", 12f, 18f);

                eq.ajoutEleve(e); // Déclaration des élèves dans le tableau eq
                eq.ajoutEleve(e2);

                Console.WriteLine("Effectif: " + eq.effectifEquipe());
                Console.WriteLine("Le leader de " + eq.getNomSection() + " est " + eq.leaderEquipe().getNom() + " avec une moyenne de: " + eq.leaderEquipe().getMoyenne().ToString("0.0"));
                Console.ReadKey();



            }
        }
    }
}
