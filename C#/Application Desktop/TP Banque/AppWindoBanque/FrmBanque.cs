using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libBanque;

namespace AppWindoBanque
{
    public partial class FrmBanque : Form
    {
        // Variables globales au formulaire = Propriétés du formulaire
        private AgenceBancaire MonAgence;
        public FrmBanque()
        {
            InitializeComponent();
            InitialiserLaBanque();
        }

        private void InitialiserLaBanque()
        {
            // Instanciation de l'objet MonAgence, en passant en paramètre le nom de l'agence
            MonAgence = new AgenceBancaire("MENTA");
            // Modification du titre de l'onglet
            lbl_ac_Titre.Text = "AGENCE de " + MonAgence.NomAgence;

            // Appel d'un sous-programme générant le jeu d'essai, autrement dit créant les comptes de l'agence
            GenererJeuDessai();
            // Appel d'un sous-programme remplissant le DataGridView avec la liste des comptes de l'agence


        }

       

        private void GenererJeuDessai()
        {
            CompteBancaire cbPatrick = new CompteBancaire("0211651079JP", "M. JANE Patrick");
            CompteBancaire cbTeresa = new CompteBancaire("1231212312LT", "Mle LISBON Teresa", 1500.00m);
            CompteBancaire cbCho = new CompteBancaire("9173826431KC", "M. KIMBALL Cho", 5050.00m);

            MonAgence.AjouterCompte(cbPatrick);
            MonAgence.AjouterCompte(cbTeresa);
            MonAgence.AjouterCompte(cbCho);

        }

        private void tabConsultation_Enter(object sender, EventArgs e)
        {
            // Rafraichissement si on se positionne sur cet onglet
            // Remplissage de la combo box
            RemplirComboBox(cbo_co_ChoixCompte);

        }

        /// <summary>
        /// Sous programme permettant de remplir une combobox avec la liste des comptes
        /// </summary>
        /// <param name="cbo_co_ChoixCompte">La Combo Box a rempir</param>
        private void RemplirComboBox(ComboBox laCombo)
        {
            // Supprimer le contenu actuel éventuel de la combobox 
            laCombo.Items.Clear();
            // Remplir la combobox à l'aide de la structure itérative foreach
            // -> cette structure permet de parcourir facilement une collection
            foreach (CompteBancaire unCompte in MonAgence.LesComptes)
            {
                // ... Ajouter le numéro du compte suivi du titulaire dans les items de la combobox
                laCombo.Items.Add(unCompte.NumCompte + " ( " + unCompte.NomTitulaire + " )");
                // NB : Items est une propriété de la combobox certes, mais c'est aussi une collection
                //      En fait une collection d'items (ou lignes)
            }

        }

        private void cbo_co_ChoixCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            // on récupère l'indice (ou index) du compte selectionné
            int iCompte = cbo_co_ChoixCompte.SelectedIndex;
            CompteBancaire leCompte;  //Déclaration d'un objet compte bancaire

            if (iCompte >= 0) //Si on a bien selectionné un compte
            {
                // On récupère dans la collection lesComptes de MonAgence le compte qui nous interesse
                // lequel compte est situé dans le collection à l'indice iCompte
                leCompte = MonAgence.LesComptes.ElementAt(iCompte);
                // Une fois l'objet CompteBancaire qui nous interesse récupéré,
                // on affiche la valeur de ses propriétés dans les Textbox
                txt_co_Numero.Text = leCompte.NumCompte.ToString();
                txt_co_Titulaire.Text = leCompte.NomTitulaire;
                txt_co_SoldeActuel.Text = leCompte.SoldeCompte.ToString();
            }
        }

        private void btn_cr_Creer_Click(object sender, EventArgs e)
        {
            // Récupération des valeurs des textbox
            string numero = txt_cr_Numero.Text;
            string titulaire = txt_cr_Titulaire.Text;
            string soldeString = txt_cr_SoldeInitial.Text;
            decimal soldeDecimal;

            if (Decimal.TryParse(soldeString, out soldeDecimal)) //Si la conversion est possible...
            {
                //.... utiliser le paramètre en sortie soldeDécimal qui est une décimal
                CompteBancaire cb = new CompteBancaire(numero, titulaire, soldeDecimal);
                // On ajoute ce nouveau compte à l'agence
                MonAgence.AjouterCompte(cb);
                // On affiche une message de confirmation
                lbl_cr_Message.Text = "Le compte de " + titulaire + " a bien été créé !";
                lbl_cr_Message.ForeColor = Color.Green;
            }
            else
            {
                // On affiche un message d'erreur
                lbl_cr_Message.Text = "Valeur incorrect pour le solde initial !";
                lbl_cr_Message.ForeColor = Color.Red;
            }

        }

        private void tabAcceuil_Enter(object sender, EventArgs e)
        {
            // Appel d'un sous-programme remplissant le DataGridView avec la liste des comptes de l'agence
            RemplirListeComptes();
        }

        private void RemplirListeComptes()
        {
            // Pour forcer le rafraichissement en cas de retour sur l'onglet d'accueil
            // on change le DataSource du DataGridView en commençant par dire pas de DataSource
            dgv_ListeComptes.DataSource = null;
            // On indique tout simplement que la source de données de la DataGridView est une collection
            // -> La DataGridView contiendra autant de lignes que la collection contient d'objets
            // -> La DataGridView contiendra autant de colonnes que le type d'objet contient de property
            dgv_ListeComptes.DataSource = MonAgence.LesComptes;
            // On peut éventuellement adapter la mise en forme, ici en redimensionnant automatiquement
            // la largeur des colonnes
            // dgv_ListeComptes.AutoResizeColumns();

        }

        private void btn_cr_Annuler_Click(object sender, EventArgs e)
        {
            string numero = txt_cr_Numero.Text;
            txt_cr_Numero.Clear();
            string titulaire = txt_cr_Titulaire.Text;
            txt_cr_Titulaire.Clear();
            string soldeString = txt_cr_SoldeInitial.Text;
            txt_cr_SoldeInitial.Clear();
        }

        private void btn_ve_Enregistrer_Click(object sender, EventArgs e)
        {
            string message = "Le versement a bien été enregistré !"; // On part du principe que c'est OK
            int iCompte = cbo_ve_ChoixCompte.SelectedIndex;
            CompteBancaire leCompte;
            // On récupère le montant en vérifiant qu'il est correct
            decimal montant = RecupererMontant(txt_ve_Montant_A_Crediter);
            // On verifie d'abord si un compte a bien été sélectionné
            if (iCompte >= 0)
            {
                // Si le montant est positif
                if (montant >= 0)
                {
                    // On tente d'effectuer le versement
                    leCompte = MonAgence.LesComptes.ElementAt(iCompte);
                    if (!leCompte.CrediterCompte(montant))    // Si l'opération de crédit s'est mal passée
                                                              // On signale une erreur
                        message = "Le virement n'a pu s'effectuer pour cause de montant incorrect."; // montant<0
                                                                                                     // Rappel : on sait que CrediterCompte renvoie faux si le montant est négatif ce qui ne devrait
                                                                                                     // pas se produire puisqu'on l'a testé avant. Mieux vaut deux protections qu'une seule !                                                                            }
                    else
                        message = "Le virement n'a pas pu être effectué parce que la saisie du montant est incorrecte !";
                }
                else
                {
                    message = "Le virement n'a pas pu être effectué parce que vous n'avez pas sélectionné le compte à créditer !";
                }
                // On affiche le résultat
                lbl_ve_Message.Text = message;
                if (message == "Le versement a bien été enregistré !")
                    lbl_ve_Message.ForeColor = Color.Green;
                else
                    lbl_ve_Message.ForeColor = Color.Red;
            }


        }

        private decimal RecupererMontant(TextBox leTextBox)
        {
            decimal montant;

            try     // On essaie la conversion …
            {
                montant = decimal.Parse(leTextBox.Text);
            }
            catch	// ... si elle ne fonctionne pas on affecte -1 comme valeur erronée
            {
                montant = -1.0m;
            }
            // Retour de la valeur
            return (montant);

        }

        private void cbo_ve_ChoixCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirComboBox(cbo_ve_ChoixCompte);
        }
    }
}
