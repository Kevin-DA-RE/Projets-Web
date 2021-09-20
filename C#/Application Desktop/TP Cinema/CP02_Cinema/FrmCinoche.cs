using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP02_Cinema
{
    public partial class FrmCinoche : Form
    {
        private float Tarif = 8.70f;

        public FrmCinoche()
        {
            InitializeComponent();
            picTicket.Visible = false;
        }

        private void lblChoixHoraire_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTarifApplicable_Click(object sender, EventArgs e)
        {
            // Tarif Réduit;
            if (rdbCE.Checked == true)
                Tarif = 5.20f;
            if (rdbEtudiant.Checked == true)
                Tarif = 5.90f;
            if (rdbAutre.Checked == true)
                Tarif = 6.90f;

            // Horaire et jour de semaine choisi
            if ((cboHoraire.SelectedIndex > -1) && (cboJour.SelectedIndex > -1))
            {
                if ((cboHoraire.SelectedIndex == 0) || (rdbCE.Checked == true))
                    Tarif = 5.20f;   //séance du matin ou réduction CE
                else if (cboJour.SelectedIndex == 0)  //séance du lundi
                    Tarif = 5.70f;

                // Majoration film 3D
                if (chkMajoration3D.Checked == true)
                    Tarif += 1.50f;

                // Réduction coupon
                if ((chkCouponReduc.Checked == true) && (rdbCE.Checked == false))
                    Tarif -= 1.00f;
                // Affichage du tarif et de l'image
                lblTarifApplicable.Text = Tarif.ToString("0.00") + " €";
                picTicket.Visible = true;
            }
            else
            {
                // Message d'avertissement
                MessageBox.Show("Vous devez selcetionner selectionner une séance ainsi qu'une horaire", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboHoraire.Focus();



            }
        }

        private void rdbCE_CheckedChanged(object sender, EventArgs e)
        {
            // CE non choisi
            if (rdbCE.Checked == false)
            {
                // Coupon réduction activé
                chkCouponReduc.Enabled = true;
            }
            else
            {
                chkCouponReduc.Checked = false;
                chkCouponReduc.Enabled = false;
            }
        }

        private void rdbAutre_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void btnAutreTicket_Click(object sender, EventArgs e)
        {
            Tarif = 8.70f;
            // Aucun choix dans les listes
            cboHoraire.SelectedIndex = -1;
            cboJour.SelectedIndex = -1;
            // Aucune réduction et majoration
            rdbCE.Checked = false;
            rdbEtudiant.Checked = false;
            rdbAutre.Checked = false;
            chkMajoration3D.Checked = false;
            chkCouponReduc.Checked = false;
            // Enabled : controle modifiable
            chkCouponReduc.Enabled = true;
            lblTarifApplicable.Text = "0.00 €";
            picTicket.Visible = false;
        }

        private void cboHoraire_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
