using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Cotisation
{
    public partial class Cotisation : Form
    {

        float abo;
        float majo_jour;

        float sport = 0;

        float montant_total;

        public Cotisation()
        {
            InitializeComponent();
        }

        private void Cotisation_Load(object sender, EventArgs e)
        {
            pic_aéro.Visible = false;
            pic_box.Visible = false;
            pic_gym.Visible = false;
            pic_musc.Visible = false;
            pic_nat.Visible = false;
            pic_skate.Visible = false;
        }

        private void chk_aerobic_Click(object sender, EventArgs e)
        {
            if (chk_aerobic.Checked)
                pic_aéro.Visible = true;
            else pic_aéro.Visible = false;
        }

        private void chk_boxe_Click(object sender, EventArgs e)
        {
            if (chk_boxe.Checked)
                pic_box.Visible = true;
            else pic_box.Visible = false;
        }

        private void chk_gymnastique_Click(object sender, EventArgs e)
        {
            if (chk_gymnastique.Checked)
                pic_gym.Visible = true;
            else pic_gym.Visible = false;
        }

        private void chk_musculation_Click(object sender, EventArgs e)
        {
            if (chk_musculation.Checked)
                pic_musc.Visible = true;
            else pic_musc.Visible = false;
        }

        private void chk_natation_Click(object sender, EventArgs e)
        {
            if (chk_natation.Checked)
                pic_nat.Visible = true;
            else pic_nat.Visible = false;
        }

        private void chk_skateboard_Click(object sender, EventArgs e)
        {
            if (chk_skateboard.Checked)
                pic_skate.Visible = true;
            else pic_skate.Visible = false;
        }

        private void bt_calculMontant_Click(object sender, EventArgs e)
        {
            if (rb_trimestriel.Checked = true)
                abo = 80;
            else if (rb_semestriel.Checked = true)
                abo = 130;
            else if (rb_annuel.Checked = true)
                abo = 220;

            if (lisbox_liste_jour.SelectedIndex == 0)
                majo_jour = 1;
            else if (lisbox_liste_jour.SelectedIndex == 1)
                majo_jour = 1.25f;
            else if (lisbox_liste_jour.SelectedIndex == 2)
                majo_jour = 1.45f;

            // prévoir un message d'erreur si rien n'est choisit

            // attention bien mettre == car si un seul = on affecte la valeur, avec == on vérifie si c'est égale à la valeur qu'on a mise après
            if (chk_aerobic.Checked == true)
                sport += 100;
            else if (chk_aerobic.Checked == false)
                sport += 0;
            if (chk_boxe.Checked == true)
                sport += 100;
            else if (chk_aerobic.Checked == false)
                sport += 0;
            if (chk_gymnastique.Checked == true)
                sport += 100;
            else if (chk_aerobic.Checked == false)
                sport += 0;
            if (chk_musculation.Checked == true)
                sport += 100;
            else if (chk_aerobic.Checked == false)
                sport += 0;
            if (chk_natation.Checked == true)
                sport += 100;
            else if (chk_aerobic.Checked == false)
                sport += 0;
            if (chk_skateboard.Checked == true)
                sport += 100;
            else if (chk_aerobic.Checked == false)
                sport += 0;
            // marche pas trouver pourquoi

            montant_total = (abo * majo_jour) + sport;

        lbl_montant.Text = montant_total.ToString("0.00") + " €";

        }


    }
}
