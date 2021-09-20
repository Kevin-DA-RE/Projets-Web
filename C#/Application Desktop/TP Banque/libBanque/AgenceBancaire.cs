using System;
using System.Collections.Generic;
using System.Text;

namespace libBanque
{
    public class AgenceBancaire
    {
        // Propriétés privées
        // Liste (collection) des comptes bancaires
        // Une collection est un "tableau dynamique" d'objets,
        // ici d'objets de type CompteBancaire
        private List<CompteBancaire> lesComptes;
        // Nom de l’agence
        private string nomAgence;
        // Acesseurs / Property
        public List<CompteBancaire> LesComptes
        {
            get { return lesComptes; } // Accesseur en lecture seule retournant la liste
        }
        public string NomAgence
        {
            get { return nomAgence; }
            set { nomAgence = value; }
        }
        public int NombreComptes
        {
            get { return lesComptes.Count; }
            // Remarque la propriété privée ne nous intéresse pas vraiment : en effet
            // une collection permet de récupérer le nombre d’éléments qu’elle contient
        }
        // Constructeur
        public AgenceBancaire(string sonNom)
        {
            // Création (instanciation) de la liste de comptes
            // Elle sera vide pour commencer et lesComptes.Count renverra 0
            lesComptes = new List<CompteBancaire>();
            nomAgence = sonNom;
        }
        // Méthodes
        public void AjouterCompte(CompteBancaire unCompte)
        {
            lesComptes.Add(unCompte); // Ajoute un objet CompteBancaire à la collection
        }
        public void SupprimerCompte(CompteBancaire unCompte)
        {
            lesComptes.Remove(unCompte); // Supprime un objet CompteBancaire de la collection
        }
        


    }
}
