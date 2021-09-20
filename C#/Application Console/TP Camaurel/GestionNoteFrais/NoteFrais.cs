using System;
using System.Collections.Generic;
using System.Text;

namespace GestionNoteFrais
{
    public class NoteFrais
    {
        protected int numero;
        protected Commercial leCommercial;
        protected DateTime date;
        protected bool estRembourse;
        protected double montantARembourser;

        protected int Numero { get => numero; set => numero = value; }
        protected Commercial LeCommercial { get => leCommercial; set => leCommercial = value; }
        protected DateTime Date { get => date; set => date = value; }
        protected bool EstRembourse { get => estRembourse; set => estRembourse = value; }
        protected double MontantARembourser { get => montantARembourser; set => montantARembourser = value; }

        public NoteFrais(int pnumero, DateTime pdate, Commercial pleCommercial)
        {
            numero = pnumero;
            date = pdate;
            leCommercial = pleCommercial;
            estRembourse = false;
            montantARembourser = 0;
        }

        public void setMontantARembourser()
        {
            montantARembourser = calculMontantARembourser();
        }

        virtual public double calculMontantARembourser()
        { return 0; }

        public void setRembourse()
        { estRembourse = true; }

        public override string ToString()
        {
            setMontantARembourser();
            return numero + "-" + date.ToShortDateString() + "-" + montantARembourser + " E -" + (estRembourse ? "R" : "NR");
        }
    }
}
