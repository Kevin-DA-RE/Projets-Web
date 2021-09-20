using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP02Tp2
{
    public partial class FrmDiapoZoo : Form
    {
        public FrmDiapoZoo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lslAnimaux_SelectedIndexChanged(object sender, EventArgs e)
        {
            String repertoire = "..\\..\\Images\\";
            String animal = lstAnimaux.Text;
            String chemin_image = repertoire + animal + ".jpg";
            picAnimal.ImageLocation = chemin_image;
        }

        private void btnSuiv_Click(object sender, EventArgs e)
        {   // si la selection n'est pas sur le dernier élément, aller sur le suivant
            if (lstAnimaux.SelectedIndex < lstAnimaux.Items.Count - 1)
                lstAnimaux.SelectedIndex++;
            // sinon aller sur le premier
            else lstAnimaux.SelectedIndex = 0;

        }

        private void btnPrec_Click(object sender, EventArgs e)
        {   // si la selection n'est pas sur le premier élément, aller sur le suivant
            if (lstAnimaux.SelectedIndex > 0)
                lstAnimaux.SelectedIndex--;
            // sinon aller sur le dernier
            else lstAnimaux.SelectedIndex = lstAnimaux.Items.Count - 1;
        }

        private void btnDiapo_Click(object sender, EventArgs e)
        {
            if (!tmrDiapo.Enabled)
                tmrDiapo.Start();
            else
                tmrDiapo.Stop();
        }

        private void tmrDiapo_Tick(object sender, EventArgs e)
        {
            if (lstAnimaux.SelectedIndex == lstAnimaux.Items.Count - 1)
                lstAnimaux.SelectedIndex = 0;
            else
                lstAnimaux.SelectedIndex++;
        }
    }
}
