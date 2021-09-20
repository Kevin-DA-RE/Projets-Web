using System;

namespace libBanque
{
    public class CompteBancaire
    {
        #region Propriétés privées de la classe
        // Proprietes privées
        private string numCompte;
        private string nomTitulaire;
        private Decimal soldeCompte;
        

        #endregion

        #region Property: accesseurs/mutateurs publics vis a vis des propriétés
        // Property

        public string NumCompte 
        { 
            get => numCompte; 
            set => numCompte = value; 
        }
        public string NomTitulaire 
        { 
            get => nomTitulaire; 
            set => nomTitulaire = value; 
        }
        public decimal SoldeCompte 
        { 
            get => soldeCompte;
        }
        #endregion

        #region Constructeur de la classe

    /// <summary>
    /// Initialise un nouveau compte à l'aide de son numéro et de son titulaire
    /// </summary>
    /// <param name="pnumCompte"></param>
    /// <param name="pnomTitulaire"></param>
    /// <remarks>Le soilde du compte sera initialisé à 0</remarks>
        public CompteBancaire(string pnumCompte, string pnomTitulaire)
        {
            numCompte = pnumCompte;
            nomTitulaire = pnomTitulaire;
            soldeCompte = 0.00m;
        }

        /// <summary>
        /// Idem pour la méthode précédante sauf que le solde y est renseigné
        /// </summary>
        
        public CompteBancaire(string pnumCompte, string pnomTitulaire, Decimal psoldeCompte)
        {
            numCompte = pnumCompte;
            nomTitulaire = pnomTitulaire;
            soldeCompte = psoldeCompte;
        }
        public bool DebiterCompte(Decimal Mont) // Opération de débit
        {
            if (Mont > soldeCompte)
                return false;
            else
                soldeCompte = soldeCompte - Mont;
            return true;
        }

        public bool CrediterCompte(Decimal Mont)
        {
            if (Mont < 0)
                return false;
            else
                soldeCompte = soldeCompte + Mont;
            return true;
        }
        
    }

    #endregion

}
