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
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frm_Cotisation;
using Metier;

namespace AboMultisport_AR_KD
{
    // formulaire d'inscription

    public partial class FrmInscrip : Form
    {
        #region Initialisation des variables

        // pour l'id de l'abonné
        public string IDAbo;
        public string IDAbon="";

        // pour le moyen de paiment
        public static string Payment = "";

        // pour la date de début de l'abonnment
        public static string datedeb;

        // pour le montant
        public static float montant;

        // pour l'id de l'abonnement et pour ceui de la fréquence
        public static string idabonnement;
        public static string idfreq;

        // pour la fréquentation par semaine
        public static int numjour;

        //
        public static string type;

        // pour le nom des activités
        public static string activite;

        #endregion

        #region Constructeur
        public FrmInscrip()
        {
            InitializeComponent();
        }
        #endregion

        #region Constructeur surchargé pour pouvoir récuper les valeurs
        public FrmInscrip(string nom_sport, string nom_jour,int numJour, float PrixAbonnement, string IDAbo, string TypeAbonnement)
        {
            InitializeComponent();

            // label rappellant les sports choisis ainsi que le nombre de jour de fréquentation par semaine
           lbl_resultCotis.Text = "(" + nom_sport.ToString() + ")" + nom_jour.ToString() + " jours/sem";
            // affichage de la date de fin de l'abonnement
            lbl_date_fin.Text = dtp_debut.Value.AddMonths(Cotisation.nbMois).AddDays(-1).ToShortDateString();
            // reprise des valeurs
            numjour = numJour;
            IDAbon = IDAbo;
            type = TypeAbonnement;
        }
        #endregion

        #region Chargement du formulaire d'inscription
        // chargement du formulaire
        // le label récapitulatif de la cotisation et les champs de dates ne sont  visibles qu'à la fin
        private void FrmAbo_Load(object sender, EventArgs e)
        {
            label15.Text = DateTime.Now.ToShortDateString();

            // label du montant à payer
            lbl_prix.Text = Cotisation.Montant.ToString("0.00") + " €";

            if (lbl_date_fin.Text == "lbl1")
            {
                dtp_debut.Visible = false;
                lbl_date_fin.Visible = false;
                lbl_resultCotis.Visible = false;
            }
            else
            {
                dtp_debut.Visible = true;
                lbl_date_fin.Visible = true;
                lbl_resultCotis.Visible = true;
            }

            // création et execution de la requete pour remplir la liste des abonnés
            DataTable dtListeAbonnés = new DataTable();
            try
            {
                dtListeAbonnés = ReqMetier.affichAbonne();
                cbo_inscrip.ValueMember = dtListeAbonnés.Columns["id"].ToString();
                cbo_inscrip.DisplayMember = dtListeAbonnés.Columns["Identifiant"].ToString();
                cbo_inscrip.DataSource = dtListeAbonnés;
                cbo_inscrip.Select();
                cbo_inscrip.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Problème pour la liste des agents dans l'accueil.");
            }

            // champs vides
            txt_nom.Text = "";
            txt_prenom.Text = "";
            txt_rue.Text = "";
            txt_cp.Text = "";
            txt_dateNaissance.Text = "";
            txt_telFixe.Text = "";
            txt_ville.Text = "";
            txt_telPort.Text = "";
            txt_mail.Text = "";
            rb_feminin.Checked = false;
            rb_masculin.Checked = false;

            if (IDAbon != "")
            {
                cbo_inscrip.SelectedValue = IDAbon;
            }
        }

        #endregion

        #region Au changement d'index selectionné dans la combobox
        private void cbo_inscrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_inscrip.SelectedIndex == -1)
            {
                bt_inscrip_valid.Visible = true;
            }
            else
            {
                bt_inscrip_valid.Visible = false;
                // création et execution de la requête de remplissage des champs de la page d'accueil
                DataTable dtRecapAbonne = new DataTable();
                string numAbo = cbo_inscrip.SelectedValue.ToString();
                try
                {
                    dtRecapAbonne = ReqMetier.dataAbonne(numAbo);
                    foreach (DataRow l in dtRecapAbonne.Rows)
                    {
                        txt_nom.Text = l["nom"].ToString();
                        txt_prenom.Text = l["prenom"].ToString();
                        txt_dateNaissance.Text = l["date_naissance"].ToString();
                        txt_rue.Text = l["adresse"].ToString();
                        txt_cp.Text = l["code_postal"].ToString();
                        txt_ville.Text = l["ville"].ToString();
                        txt_telFixe.Text = l["tel_fixe"].ToString();
                        txt_telPort.Text = l["portable"].ToString();
                        txt_mail.Text = l["mail"].ToString();
                        string sexe = l["sexe"].ToString();

                        if (sexe.Contains("M") == true)
                        {
                            rb_masculin.Checked = true;
                            rb_feminin.Checked = false;
                        }
                        else
                        {
                            rb_masculin.Checked = false;
                            rb_feminin.Checked = true;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Problème pour remplir les champs de l'utilisateur.");
                }
            }
        }
        #endregion

        #region Bouton calcul, envoie sur le formulaire de cotisation
        // envoie au formulaire cotisation et cache le formulaire d'inscription
        private void bt_calcul_Click(object sender, EventArgs e)
        {
            if (cbo_inscrip.SelectedIndex != -1)
            {
                IDAbo = cbo_inscrip.SelectedValue.ToString();
            }
            Cotisation Cotisation = new Cotisation(IDAbo);
            Cotisation.Show();
            this.Hide();
        }

        #endregion

        #region Changement de la date de début de l'abonnement

        // changement de la date de début de l'abonnement
        // mise à jour de la date de fin de l'abonnement
        public void dtp_debut_ValueChanged(object sender, EventArgs e)
        {
            lbl_date_fin.Text = dtp_debut.Value.AddMonths(Cotisation.nbMois).AddDays(-1).ToShortDateString();
        }

        #endregion

        #region Ckeck au clavier pour rbt sexe
        private void rb_feminin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (rb_feminin.Checked == true)
                    rb_masculin.Checked = false;
                else rb_feminin.Checked = true;
            }
        }

        #endregion

        #region Tel fixe seulement numéro
        private void txt_telFixe_KeyPress(object sender, KeyPressEventArgs e)
        {
            // autorise seulement des numériques
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Bouton valider agent
        private void bt_inscrip_valid_Click(object sender, EventArgs e)
        {
            // contrôle si tout les champs ne sont pas rentrés
            if (txt_nom.Text == "" || txt_prenom.Text == "" || txt_dateNaissance.Text == "" || rb_feminin.Checked == false && rb_masculin.Checked == false
                || txt_rue.Text == "" || txt_cp.Text == "" || txt_ville.Text == "" || txt_telFixe.Text == "" || txt_telPort.Text == ""
                || txt_mail.Text == "")
            {
                MessageBox.Show("Vous devez rentrer toutes les informations.", "Message d'information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // attribution des données entré par l'utilisateur
                string nom1 = txt_nom.Text;
                string nom = ReqMetier.CleanString(nom1);
                string prenom1 = txt_prenom.Text;
                string prenom = ReqMetier.CleanString(prenom1);
                string dateNais1 = txt_dateNaissance.Text;
                string dateNais = dateNais1.ToString("yyyy'-'MM'-'dd", CultureInfo.InvariantCulture);
                string sexe = "";
                if (rb_feminin.Checked == true)
                {
                    sexe = "F";
                }
                else sexe = "M";
                string adresse1 = txt_rue.Text;
                string adresse = ReqMetier.CleanString(adresse1);
                string cp1 = txt_cp.Text;
                string cp = ReqMetier.CleanString(cp1);
                string ville1 = txt_ville.Text;
                string ville = ReqMetier.CleanString(ville1);
                string tel_fixe = txt_telFixe.Text;
                string portable1 = txt_telPort.Text;
                string portable = ReqMetier.CleanPortable(portable1);
                string mail = txt_mail.Text;

                try
                {
                    // ajouter un abonné
                    ReqMetier.AjoutAbonne(nom, prenom, dateNais, sexe, adresse, cp, ville, tel_fixe, portable, mail);
                    MessageBox.Show("Ajout réussi de l'abonné.", "Message d'information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // rechercher l'id de l'abonné
                    DataTable dtIDAbo = new DataTable();
                    dtIDAbo = ReqMetier.ReqAbonnement(nom, prenom, dateNais, sexe, adresse, cp, ville, tel_fixe, portable, mail);
                    foreach (DataRow l in dtIDAbo.Rows)
                    {
                        IDAbo = l[0].ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Problème pour l'ajout de l'abonné.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region Bouton valider
        private void bt_valid_Click(object sender, EventArgs e)
        {
            // cotrôle si un moyen de paiment est choisit
            if (lbl_resultCotis.Visible == true)
            {
                if (rb_cheque.Checked == true)
                    Payment = "CH";
                else
                {
                    if (rb_cb.Checked == true)
                        Payment = "CB";
                }

                datedeb = dtp_debut.Value.ToString("yyyy'-'MM'-'dd");
                montant = Cotisation.Montant;

                DataTable dtIDAbonnement = new DataTable();
                DataTable dtIdfreq = new DataTable();

                // récupération de l'id de la fréquence
                try
                {
                    dtIDAbonnement = ReqMetier.ReqAbonnement(type);
                    foreach (DataRow l in dtIDAbonnement.Rows)
                    {
                        idabonnement = l[0].ToString();
                    }
                    dtIdfreq = ReqMetier.ChoixFrequence(numjour);
                    foreach (DataRow l in dtIdfreq.Rows)
                    {
                        idfreq = l[0].ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Pb pour la majo jour et les jours de fréquentation.");
                }

                if (bt_inscrip_valid.Visible == false)
                {
                    IDAbon = cbo_inscrip.SelectedValue.ToString();
                }
                ReqMetier.AjoutCotis(datedeb, Payment, montant, IDAbon, idabonnement, idfreq);
                
                // recherche de l'id de la cotisation
                DataTable dtIdCotis = new DataTable();
                string idcotis="";
                dtIdCotis = ReqMetier.rechCotis(datedeb, Payment, montant, IDAbon, idabonnement, idfreq);
                foreach (DataRow l in dtIdCotis.Rows)
                {
                    idcotis = l[0].ToString();
                }

                // récupération des id des activités et création des liens entre l'activité choisit et la cotisation
                DataTable dtact = new DataTable();
                string idact = "";
                if (lbl_resultCotis.Text.Contains("boxe") == true)
                {
                    activite = "boxe";
                    dtact = ReqMetier.rechAct(activite);
                    foreach (DataRow l2 in dtact.Rows)
                    {
                       idact = l2[0].ToString();
                    }
                    ReqMetier.AjoutActivite(idact, idcotis);
                }

                if (lbl_resultCotis.Text.Contains("aérobic") == true)
                {
                    activite = "aerobic";
                    dtact = ReqMetier.rechAct(activite);
                    foreach (DataRow l3 in dtact.Rows)
                    {
                        idact = l3[0].ToString();
                        MessageBox.Show(idact);
                    }
                    ReqMetier.AjoutActivite(idact, idcotis);
                }

                if (lbl_resultCotis.Text.Contains("gymnastique") == true)
                {
                    activite = "gymnastique";
                    dtact = ReqMetier.rechAct(activite);
                    foreach (DataRow l4 in dtact.Rows)
                    {
                        idact = l4[0].ToString();
                    }
                    ReqMetier.AjoutActivite(idact, idcotis);
                }

                if (lbl_resultCotis.Text.Contains("musculation") == true)
                {
                    activite = "musculation";
                    dtact = ReqMetier.rechAct(activite);
                    foreach (DataRow l5 in dtact.Rows)
                    {
                        idact = l5[0].ToString();
                    }
                    ReqMetier.AjoutActivite(idact, idcotis);
                }

                if (lbl_resultCotis.Text.Contains("natation") == true)
                {
                    activite = "natation";
                    dtact = ReqMetier.rechAct(activite);
                    foreach (DataRow l6 in dtact.Rows)
                    {
                        idact = l6[0].ToString();
                    }
                    ReqMetier.AjoutActivite(idact, idcotis);
                }

                if (lbl_resultCotis.Text.Contains("skateboard") == true)
                {
                    activite = "skateboard";
                    dtact = ReqMetier.rechAct(activite);
                    foreach (DataRow l7 in dtact.Rows)
                    {
                        idact = l7[0].ToString();
                    }
                    ReqMetier.AjoutActivite(idact, idcotis);
                }

            } else
            {
                MessageBox.Show("Vous devez choissir un abonnement.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}
