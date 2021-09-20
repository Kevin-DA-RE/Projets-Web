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
    public partial class FrmListeRetardataires : Form
    {
        public FrmListeRetardataires()
        {
            InitializeComponent();
        }

        private void FrmListeRetardataires_Load(object sender, EventArgs e)
        {
            //affichage date du jour
            lblDate.Text = DateTime.Now.ToShortDateString();
            DataTable dtListeRetardataires = new DataTable();
            string ReqListeRetardataires = "select nomAdh as Nom, prenomAdh as Prenom, dateEmprunt as 'Date emprunt', ";
            ReqListeRetardataires += "dateRetourPrevue as 'Date retour prevue', DATEDIFF(now(), dateRetourPrevue) as 'Nombre de jours de retard' ";
            ReqListeRetardataires += "from adherent inner join emprunter on codeAdherent = codeAdh ";
            ReqListeRetardataires += "where (DATEDIFF(now(), dateRetourPrevue)> 0) ";
            ReqListeRetardataires += "and isnull(dateRetourReelle) order by Nom, Prenom asc, 5 desc;";
            //MessageBox.Show(ReqListeRetardataires);
            try {
                dtListeRetardataires = PasserelleMySql.ExecutionRequete(ReqListeRetardataires);
                //dgvListeRetardataires.DataSource = dtListeRetardataires;
                //suppression de la 1° colonne de la grille (celle avec *)
                dgvListeRetardataires.RowHeadersVisible = false;
                //numero de ligne dans la grille
                int i = 0;
                // boucle de parcours de dtListeRetardataires
                foreach (DataRow l in dtListeRetardataires.Rows)
                {
                    // ajouter une ligne dans la grille
                    dgvListeRetardataires.Rows.Add(l["Nom"], l["Prenom"], ((DateTime)l["Date emprunt"]).ToShortDateString(), ((DateTime)l["Date retour prevue"]).ToShortDateString(), l["Nombre de jours de retard"]);
                    // alternance des couleurs fonds des lignes
                    if ((i % 2) == 0)
                        dgvListeRetardataires.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                    else
                        dgvListeRetardataires.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    // affichage de la 5° colonne
                    dgvListeRetardataires.Rows[i].Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    // test du nb de jours de retard
                    if ((int)l["Nombre de jours de retard"] > 7)
                        dgvListeRetardataires.Rows[i].Cells[4].Style.BackColor = Color.Red;
                    else
                        dgvListeRetardataires.Rows[i].Cells[4].Style.BackColor = Color.Green;


                    i++;
                };
            }
            catch {
                MessageBox.Show("Problème d'accès aux informations");
            }
        }
    }
}
