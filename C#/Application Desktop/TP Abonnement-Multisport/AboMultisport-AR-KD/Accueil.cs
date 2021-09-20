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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace AboMultisport_AR_KD
{
    // page de connexion

    public partial class Accueil : Form
    {

        #region Constructeur
        public Accueil()
        {
            InitializeComponent();
        }
        #endregion

        #region Bouton connexion
        private void bt_acc_connec_Click(object sender, EventArgs e)
        {
            // contrôle du mot de passe et de l'identifiant
            if (txt_acc_ident.Text == "admin" & txt_acc_mdp.Text == "admin")
            {
                // tentative de connexion à la base de données et envoie sur le formulaire d'inscription
                try
                {
                    ReqMetier.connexionBase();
                    FrmInscrip frmInscrip = new FrmInscrip();
                    frmInscrip.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Problème de connexion à la base de données. Vérifier si vous êtes bien connecté à internet et rédémarer le logiciel.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("L'identifiant ou le mot de passe est incorrect.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // réinitialisation des champs
                txt_acc_ident.Text = "";
                txt_acc_mdp.Text = "";
            }
        }
        #endregion

        #region Connexion au clavier
        // attribution de la touche entrer pour la connexion
        private void txt_acc_mdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                bt_acc_connec_Click(sender, e);
        }
        #endregion

        private void Accueil_Load(object sender, EventArgs e)
        {

        }
    }
}
