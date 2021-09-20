using System;

namespace GestionNoteFrais
{
    public class Commercial
    {
        private string nom;
        private string prenom;
        private int puissanceVoiture;
        private char categorie;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int PuissanceVoiture { get => puissanceVoiture; set => puissanceVoiture = value; }
        public char Categorie { get => categorie; set => categorie = value; }

        public Commercial(string pnom, string pprenom, int ppuissanceVoiture, char pcategorie)
        {
            nom = pnom;
            prenom = pprenom;
            puissanceVoiture = ppuissanceVoiture;
            categorie = pcategorie;
        }

        public override string ToString()
        {
            return "Nom : " + Nom + " Prenom : " + Prenom + " Puissance : " + PuissanceVoiture + " Categorie : " + categorie;
        }

    }
}

