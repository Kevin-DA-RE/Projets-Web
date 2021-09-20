using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP02_TP2_EX_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] tbVille = new string[5] { "Auxonne", "Beaune", "Chatillon", "Dijon", "Pontailler" };
            char[,] tbStatsPluie = new char[5, 31] {{ 'O','O','N','N','N','N','N','O','O','O', 'N', 'N', 'N', 'N', 'N', 'N', 'N', 'N', 'N', 'N' , 'O', 'O', 'O', 'N', 'N', 'N', 'N', 'N', 'N', 'N' ,'N'},
                                                    { 'O','O','O','N','N','N','O','O','O','O', 'O', 'O', 'O', 'O', 'O', 'N', 'N', 'N', 'O', 'O' , 'N', 'N', 'O', 'O', 'O', 'O', 'O', 'N', 'N', 'N' ,'N'},
                                                    { 'O','O','O','O','O','N','N','N','N','N', 'N', 'N', 'N', 'O', 'O', 'O', 'O', 'N', 'N', 'N' , 'N', 'N', 'N', 'N', 'N', 'N', 'O', 'O', 'O', 'O' ,'O'},
                                                    { 'N','N','N','N','N','O','O','O','O','O', 'N', 'N', 'N', 'N', 'N', 'N', 'N', 'N', 'O', 'O' , 'O', 'N', 'N', 'N', 'N', 'N', 'N', 'O', 'O', 'O' ,'O'},
                                                    { 'N','N','N','O','O','O','O','O','O','O', 'O', 'O', 'N', 'N', 'N', 'N', 'N', 'N', 'N', 'N' , 'N', 'N', 'N', 'N', 'N', 'N', 'O', 'O', 'O', 'O' ,'O'}
                                                    };
            // Mise en forme de la grille
            dgvMeteo.RowCount = 5; // nb lignes
            dgvMeteo.ColumnCount = 12; // nb colonnes
            dgvMeteo.Columns[0].Width = 30; //Largeur de la lière colonne (nom des ville)
            dgvMeteo.Enabled = false; // Grille non modifiable par l'utilisateur
            // remplissage de la liste et de la grille avec les deux tailles
            for (int i = 0; i < 5; i++)
            {
                cboVille.Items.Add(tbVille[i]);
                dgvMeteo[0, 1].Value = tbVille[i];
                dgvMeteo[0, 1].Style.BackColor = Color.Blue;
                for (int j = 1; j < 32; j++)
                {
                    dgvMeteo.Columns[j].Width = 25;
                    dgvMeteo.EnableHeadersVisualStyles = false;
                    dgvMeteo.Columns[j].HeaderCell.Style.BackColor = Color.Blue;
                    dgvMeteo.Columns[j].Name = j.ToString();
                    dgvMeteo[j, i].Value = (tbStatsPluie[i, j - 1]).ToString();
                }

            }
        }

        private void dgvMeteo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVille.SelectedIndex > -1)
            {
                int nbJoursPluis = 0;
                for (int j = 1; j < 32; j++)
                {
                    if ((string)(dgvMeteo[j, cboVille.SelectedIndex].Value) == "O")
                        nbJoursPluis++;
                } // les accoldes ne sont pas obligatoires quand on a qu'une seule instruction.
                lblReponse.Text = nbJoursPluis.ToString() + " jours de pluie dans le mois";
            }
            else
                MessageBox.Show("Il faut choisir une ville", "Absence de choix d'une ville", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
