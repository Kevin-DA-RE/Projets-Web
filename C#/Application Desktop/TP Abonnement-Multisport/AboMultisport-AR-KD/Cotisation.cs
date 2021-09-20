/*================================================================================*
* Programme : Abonnement multi-sport
*
* But : poursuite de la solution abo multi-sport et création de la persistance des données et création de l'architecture multicouche
*
* Auteur : Da Re Kevin et Rochet Alexia
* 
* Date : 23/02/2021
*
*================================================================================*/

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
using AboMultisport_AR_KD;
using Metier;

namespace Frm_Cotisation
{
    // formulaire de cotisation

    public partial class Cotisation : Form
    {
        #region Initialisation des variables
        
        // pour l'abonnement
        public static string TypeAbonnement;
        public static float PrixAbonnement;

        // pour la fréquentation par semaine
        public static int numJour;
        public static float Majo_jour;

        // pour les activités
        public static int nbsport;
        public static float Prixsport;

        // pour montant de la cotisation
        public static float Montant;

        // nombre de jour choisit
        public static string nom_jour;
        // nom du sport choisit
        public static string nom_sport;
        // nombre de mois du type d'abonnement
        public static int nbMois;

        // id de l'abonné
        public static string IdAbo;

        #endregion

        #region Constructeur
        public Cotisation(string IDAbo)
        {
            InitializeComponent();
            IdAbo = IDAbo;
        }
        #endregion

        #region Chargement du formulaire de cotisation
        // les images ne sont pas visibles
        private void Cotisation_Load(object sender, EventArgs e)
        {
            pic_aéro.Visible = false;
            pic_box.Visible = false;
            pic_gym.Visible = false;
            pic_musc.Visible = false;
            pic_nat.Visible = false;
            pic_skate.Visible = false;
            nom_sport = null;
        }

        #endregion

        #region Choix des sports

        // pour chaque checkbox concernées, l'image correspondante ne s'affichera que si ça checkbox est cochée
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

        #endregion

        #region Bouton CalculMontant
        // affichage du montant total à payer
        private void bt_calculMontant_Click(object sender, EventArgs e)
        {
            // contrôle si tous les champs ne sont pas rentrés
            if (rb_trimestriel.Checked == false && rb_semestriel.Checked == false && rb_annuel.Checked == false
                && lisbox_liste_jour.SelectedIndex == -1 && chk_aerobic.Checked == false && chk_boxe.Checked == false
                && chk_gymnastique.Checked == false && chk_musculation.Checked == false && chk_natation.Checked == false
                && chk_skateboard.Checked == false)
            {
                MessageBox.Show("Vous devez rentrer toutes les informations.", "Message d'information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // choix du type d'abonnement
                // contrôle des champs
                if (rb_trimestriel.Checked == false && rb_semestriel.Checked == false && rb_annuel.Checked == false)
                {
                    MessageBox.Show("Vous devez sélection le type d'abonnement.", "Message d'information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    if (rb_trimestriel.Checked == true)
                    {
                        TypeAbonnement = "trimestriel";
                        nbMois = 3;
                    }
                    else if (rb_semestriel.Checked == true)
                    {
                        TypeAbonnement = "semestriel";
                        nbMois = 6;
                    }
                    else if (rb_annuel.Checked == true)
                    {
                        TypeAbonnement = "annuel";
                        nbMois = 12;
                    }
                }

                // contrôle des champs pour choix du nombre de jour de fréquentation par semaine du club
                if (lisbox_liste_jour.SelectedIndex == -1)
                {
                MessageBox.Show("Vous devez sélection le nombre de jour de fréquentation par semaine du club.", "Message d'information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                numJour = lisbox_liste_jour.SelectedIndex + 1;
                    if (numJour == 1)
                    {
                        nom_jour = " deux";
                    }
                    if (numJour == 2)
                    {
                        nom_jour = " quatre";
                    }
                    if (numJour == 3)
                    {
                        nom_jour = " six";
                    }
                }

                // contrôle des champs pour les sports
                if (chk_aerobic.Checked == false && chk_boxe.Checked == false && chk_gymnastique.Checked == false &&
                chk_musculation.Checked == false && chk_natation.Checked == false && chk_skateboard.Checked == false)
                {
                    MessageBox.Show("Vous devez sélection au moins un sport.", "Message d'information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (chk_aerobic.Checked == true)
                    {
                        nbsport++;
                        nom_sport += "aérobic";
                    }
                    if (chk_boxe.Checked == true)
                    {
                        nbsport++;
                        nom_sport += " boxe ";
                    }
                    if (chk_gymnastique.Checked == true)
                    {
                        nbsport++;
                        nom_sport += " gymnastique ";
                    }
                    if (chk_musculation.Checked == true)
                    {
                        nbsport++;
                        nom_sport += " musculation ";
                    }
                    if (chk_natation.Checked == true)
                    {
                        nbsport++;
                        nom_sport += " natation ";
                    }
                    if (chk_skateboard.Checked == true)
                    {
                        nbsport++;
                        nom_sport += " skateboard ";
                    }
                }

                // pour prix de l'abonnement
                DataTable dtPrixAbonnement = new DataTable();
                string prixabonnement = "";
                float PrixAbonnement = 0;
                    try
                    {
                        dtPrixAbonnement = ReqMetier.ChoixAbonnement(TypeAbonnement);
                        foreach (DataRow l in dtPrixAbonnement.Rows)
                        {
                            prixabonnement = l[0].ToString();
                        }
                        PrixAbonnement = float.Parse(prixabonnement, System.Globalization.CultureInfo.InvariantCulture);
                    }
                    catch
                    {
                        MessageBox.Show("Pb pour le prix de l'abonnement.");
                    }

                // pour la majoration pour les fréquences
                DataTable dtMajoJour = new DataTable();
                string majojour = "";
                float Majo_jour = 0;
                try
                {
                        dtMajoJour = ReqMetier.ChoixFrequence(numJour);
                        foreach (DataRow l in dtMajoJour.Rows)
                        {
                        majojour = l[0].ToString();
                        }
                        Majo_jour = float.Parse(majojour, System.Globalization.CultureInfo.InvariantCulture);
                }
                catch
                {
                        MessageBox.Show("Pb pour la majo jour.");
                }

                // pour le prix des sports
                Prixsport = ReqMetier.CalculActivites(nbsport);

                // calcul du montant total à payer
                Montant = ReqMetier.CalculMonant(PrixAbonnement, Majo_jour, Prixsport);

                // affichage du montant total à payer
                lbl_montant.Text = ReqMetier.CalculMonant(PrixAbonnement, Majo_jour, Prixsport).ToString("0.00") + " €";
            }
        }
        #endregion

        #region Bouton retour, retour au formulaire d'inscription
        // renvoie au formulaire Bulletin d'inscription avec le constructeur surchargé pour récuper les valeurs si l'utilisateur a rentré des informations
        //  renvoie au formulaire Bulletin d'inscription avec le constructeur normal si l'utilisateur n'a pas rentré des informations
        private void bt_retour_Click(object sender, EventArgs e)
        {
             if (chk_aerobic.Checked == false && chk_boxe.Checked == false && chk_gymnastique.Checked == false &&
               chk_musculation.Checked == false && chk_natation.Checked == false && chk_skateboard.Checked == false)
             {
                 FrmInscrip frmAbo = new FrmInscrip();
                 frmAbo.Show();
                 this.Hide();
             } else {
                 FrmInscrip frmAbo = new FrmInscrip(nom_sport,nom_jour, numJour, PrixAbonnement, IdAbo, TypeAbonnement);
                 frmAbo.Show();
                 this.Hide();
             }
        }

        #endregion

        #region Bouton annuler
        // click sur le bouton annuler
        private void bt_annuler_Click(object sender, EventArgs e)
        {
            rb_trimestriel.Checked = false;
            rb_semestriel.Checked = false;
            rb_annuel.Checked = false;
            lisbox_liste_jour.ClearSelected();
            chk_aerobic.Checked = false;
            chk_boxe.Checked = false;
            chk_gymnastique.Checked = false;
            chk_musculation.Checked = false;
            chk_natation.Checked = false;
            chk_skateboard.Checked = false;
            lbl_montant.Text = "0.00 €";
            pic_aéro.Visible = false;
            pic_box.Visible = false;
            pic_gym.Visible = false;
            pic_musc.Visible = false;
            pic_nat.Visible = false;
            pic_skate.Visible = false;
            TypeAbonnement="";
            PrixAbonnement=0;
            numJour=0;
            Majo_jour=0;
            nbsport=0;
            Prixsport=0;
            Montant=0;
            nom_jour="";
            nom_sport="";
            nbMois=0;
        }

        #endregion

    }
}
