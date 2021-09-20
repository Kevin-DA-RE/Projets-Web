/*================================================================================*
* Programme : AboMultisport-AR-KD
*
* But : Application desktop pour une inscription à un club omnisports
*
* Auteur : Da Re Kevin et Rochet Alexia
*
*================================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frm_Cotisation;
using AboMultisport_AR_KD;

namespace AboMultisport_AR_KD
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Accueil()); 



        }
    }
}
