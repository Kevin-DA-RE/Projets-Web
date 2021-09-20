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
    public partial class Accueil : Form
    {
        //public string ChaineConnection = string.Format("SERVER=localhost;DATABASE=bdbiblio; UID=dulivre; PASSWORD=mpdulivre");

        public Accueil()
        {
            InitializeComponent();
            /*try { 
                PasserelleMySql.OuvertureConnexion(ChaineConnection); 
            } catch {
                MessageBox.Show("Problème de connexion");
            };*/
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasserelleMySql.FermetureConnexion();
            Application.Exit();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeLivresGenre frmListeLivresGenre = new FrmListeLivresGenre();
            this.Visible = false;
            // avec showdialog peut pas accéder au formualaire parent si le formulaire enfant n'est pas fermé
            frmListeLivresGenre.ShowDialog(this);
            this.Visible = true;
        }

        private void inscriptionAdherentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInscriptionAdherent frmInscriptionAdherent = new FrmInscriptionAdherent();
            this.Visible = false;
            frmInscriptionAdherent.ShowDialog(this);
            this.Visible = true;
        }

        private void listeRetardatairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeRetardataires frmListeRetardataires = new FrmListeRetardataires();
            this.Visible = false;
            frmListeRetardataires.ShowDialog(this);
            this.Visible = true;
        }
    }
}
