using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace GestionNoteFrais
{
    public class Nuitee: NoteFrais
    {
        private double montantFacture;
        private char region;

        public Nuitee(int pnumero, DateTime pdate, Commercial pleCommercial, double pmontantFacture, char pregion) : base(pnumero, pdate, pleCommercial)
        {
            montantFacture = pmontantFacture;
            region = pregion;
        }

        public override double calculMontantARembourser()
        {
            double res;
            double coef;
            if (leCommercial.Categorie == 'A')
            {
                res = 65;
            }
            else
            {
                if (leCommercial.Categorie == 'B')
                {
                    res = 55;
                }
                else
                    res = 50;
            }

            if (region == '1')
            {
                coef = 0.9;
            }
            else
                if (region =='2')
            {
                coef = 1;
            }
            else
                coef = 1.15;
            return (res * coef > montantFacture) ? montantFacture : res * coef;
            
        }

        public override string ToString()
        {
            return "N-" + numero + "-" + date.ToShortDateString() + "-" + calculMontantARembourser() + "-E-" + (estRembourse ? "R" : "NR") + "- payé-" + montantFacture + "-E-" + region + "-";
        }


    }
}
