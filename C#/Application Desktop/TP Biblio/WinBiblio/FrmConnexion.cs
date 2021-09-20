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
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtPassword.Text = "";
            // curseur sur le login
            txtLogin.Select();
            // info bulle au survole (toucher les bords de la textbox)
            tltLogin.SetToolTip(this.txtLogin, "Saisir un login");
            tltPassword.SetToolTip(this.txtPassword, "Saisir un password");

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // pour tester UID = dulivre; PASSWORD = mpdulivre
            procConnexion();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // code asky 13 = touche entré
            if (e.KeyChar == (char)13)
                procConnexion();
        }

        public void procConnexion ()
        {
            try
            {
                string ChaineConnection = string.Format("SERVER=localhost;DATABASE=biblio; UID=" + txtLogin.Text + ";PASSWORD=" + txtPassword.Text);
                PasserelleMySql.OuvertureConnexion(ChaineConnection);
                this.Visible = false;
                Accueil frmAccueil = new Accueil();
                frmAccueil.Show();
            }
            catch
            {
                MessageBox.Show("Login et/ou password incorrect(s)");
                txtLogin.Select();
            }
        }
    }
}
