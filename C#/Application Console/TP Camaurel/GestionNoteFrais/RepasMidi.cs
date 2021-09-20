using System;
using System.Collections.Generic;
using System.Text;

namespace GestionNoteFrais
{
    public class RepasMidi : NoteFrais
    {
        private int repMidi;
        

        public RepasMidi(int pnumero, DateTime pdate, Commercial pleCommercial, int prepasMidi): base (pnumero, pdate, pleCommercial)
        {
            repMidi = prepasMidi;
        }

        public override double calculMontantARembourser()
        {
            switch (leCommercial.Categorie)
            {
                case 'A': return 25;

                case 'B': return  22;

                case 'C': return 20;
            }
            return base.calculMontantARembourser();
        }
        public override string ToString()
        {
            return "R-" + numero + "-" + date.ToShortDateString() + "-" + calculMontantARembourser()+ "-E-" + (estRembourse ? "R" : "NR") + "-" + "payé : " + repMidi + "E";
        }
    }
}
