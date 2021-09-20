using System;
using System.Collections.Generic;
using System.Text;

namespace GestionNoteFrais
{
    public class FraisTransport: NoteFrais // Déclaration de/des variables à utiliser
    {
        private int nbKm;

    // Déclaratrion du constructeur
    public FraisTransport(int pnumero, DateTime pdate, Commercial pleCommercial, int pnbKm) :base (pnumero, pdate, pleCommercial)
        {
            nbKm = pnbKm;
        }
    // Calcul de la fonction
    public override double calculMontantARembourser()
        {
            if (leCommercial.PuissanceVoiture < 5)
                return nbKm * 0.7f;
            else
                if (leCommercial.PuissanceVoiture < 10)
                return nbKm * 0.8f;
            else
                return nbKm * 0.9f;
        }
        public override string ToString()
        {
            return "T"+ "-" + numero + "-"+ date.ToShortDateString() + "-" + calculMontantARembourser() +"-" + "E" + "-" + (estRembourse ? "R" : "NR") + "-" + nbKm + " Kms";
        }

    }
}
