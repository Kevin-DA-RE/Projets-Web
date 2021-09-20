using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace WinBiblio
{
    public partial class FrmInscriptionAdherent : Form
    {
        public FrmInscriptionAdherent()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // soit on fait ça
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtRue.Text = "";
            txtCP.Text = "";
            txtVille.Text = "";
            txtTel.Text = "";
            txtMel.Text = "";

            // soit on fait de la récursivité
            // recursivité = une fonction qui s'appelle elle meme, se reproduit à l'infini à l'interieur d'elle meme
            ParcoursControles(this, "TextBox");
        }

        private void ParcoursControles(Control ctrl, string tyeControl)
        {
            // boucle sur ses sous-controles
            foreach(Control sousCtrl in ctrl.Controls)
            {
                // recherche des controles de type typeControl
                if (sousCtrl.GetType().ToString() == "System.Windows.Forms." + tyeControl)
                    sousCtrl.Text = "";
                // s'il a des sous controles de type container par ex, condition d'arret
                if ((sousCtrl.Controls != null) && (sousCtrl.Controls.Count > 0))
                    // appel récursif
                    ParcoursControles(sousCtrl, tyeControl);
            }
        }



        private void btnInscrire_Click(object sender, EventArgs e)
        {
            if ((txtNom.Text == "") || (txtPrenom.Text == "") || (txtRue.Text == "") || (txtCP.Text == "") || (txtVille.Text == "") || (txtTel.Text == ""))
            {
                MessageBox.Show("Il faut saisir toutes les informations !", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                // met la 1° lettre en majuscule
                // met le reste en minuscule grace à substring (prend le reste)
                txtNom.Text = txtNom.Text[0].ToString().ToUpper() + txtNom.Text.Substring(1).ToLower();
                txtPrenom.Text = txtPrenom.Text[0].ToString().ToUpper() + txtPrenom.Text.Substring(1).ToLower();
                txtVille.Text = txtVille.Text[0].ToString().ToUpper() + txtVille.Text.Substring(1).ToLower();
                DialogResult Rep = MessageBox.Show("Confirmation de l'inscription de M/Mme " + txtNom.Text + " " + txtPrenom.Text, "CONFIRMATION INSCRIPTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(Rep == DialogResult.Yes)
                {
                    // création et execution de la requete d'insertion
                    // pas de datatable car ici ajout
                    string ReqInscriptionAdherent = "insert into adherent (";
                    ReqInscriptionAdherent += "nomAdh, prenomAdh, adrRueAdh, adrCPAdh, adrVilleAdh, telAdh, melAdh) ";
                    ReqInscriptionAdherent += "values ('" + txtNom.Text + "', '" + txtPrenom.Text + "', '" + txtRue.Text + "', '";
                    ReqInscriptionAdherent += txtCP.Text + "', '" + txtVille.Text + "', '" + txtTel.Text + "', '" + txtMel.Text + "');";
                    PasserelleMySql.ExecutionMaj(ReqInscriptionAdherent);
                    MessageBox.Show("Inscription réussi de M/Mme " + txtNom.Text + " " + txtPrenom.Text);

                }
            }
        }
    }
}
