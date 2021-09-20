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
    public partial class FrmListeLivresGenre : Form
    {
        public FrmListeLivresGenre()
        {
            InitializeComponent();
        }

        private void FrmListeLivresGenre_Load(object sender, EventArgs e)
        {
            DataTable dtListeGenre = new DataTable();
            string ReqListeGenre = "select codeGenre, nomGenre from genre order by nomGenre;";
            try {
                dtListeGenre = PasserelleMySql.ExecutionRequete(ReqListeGenre);
                // remplissage liste genre (combobox)
                // associe le num dans la liste au code genre
                cboListeGenre.ValueMember = dtListeGenre.Columns["codeGenre"].ToString();
                // associe le nom genre à se qu'affiche la liste déroulante
                cboListeGenre.DisplayMember = dtListeGenre.Columns["nomGenre"].ToString();
                // valeurs viennent de la requete de la bd
                cboListeGenre.DataSource = dtListeGenre;
                // positionner le curseur sur la liste déroulante
                cboListeGenre.Select();
                cboListeGenre.SelectedIndex = -1;
                dgvListeLivresGenre.Visible = false;

            } catch
            {
                MessageBox.Show("Problème pour la liste des genres");
            }

        }

        private void cboListeGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboListeGenre.SelectedIndex > -1)
            {
                DataTable dtListeLivresGenre = new DataTable();
                string ReqListeLivresGenre = "select titreLivre as Titre, nomAuteur as Auteur, anneeLivre as Annee, langueLivre as Langue";
                ReqListeLivresGenre += " from livre inner join auteur on codeAuteur = codeAuteurLivre";
                ReqListeLivresGenre += " where codeGenreLivre = '" + cboListeGenre.SelectedValue + "' order by Auteur, Titre;";
                //MessageBox.Show(ReqListeLivresGenre);
                dtListeLivresGenre = PasserelleMySql.ExecutionRequete(ReqListeLivresGenre);
                dgvListeLivresGenre.DataSource = dtListeLivresGenre;
                dgvListeLivresGenre.Visible = true;
            } else
            {
                MessageBox.Show("Choisir un genre");
            }
        }
    }
}
