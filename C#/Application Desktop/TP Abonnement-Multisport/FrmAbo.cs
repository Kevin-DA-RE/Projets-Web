using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frm_Cotisation;

namespace AboMultisport_AR_KD
{
    public partial class FrmAbo : Form
    {
        public static FrmAbo staticVar = null;
        public FrmAbo()
        {
            InitializeComponent();
        }

        private void bt_calcul_Click(object sender, EventArgs e)
        {
           /* Frm_Cotisation Cotisation = new Frm_Cotisation();
            cotisation.Show();*/

        }

        private void FrmAbo_Load(object sender, EventArgs e)
        {
            dtp_debut.Visible = false;
            dtp_fin.Visible = false;
            lbl_resultCotis.Visible = false;
        }
    }
}
