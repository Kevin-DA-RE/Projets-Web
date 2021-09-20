namespace WinBiblio
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titre = new System.Windows.Forms.Label();
            this.mns_accueil = new System.Windows.Forms.MenuStrip();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionAdherentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPrêtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeRetardatairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutPrêtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_accueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(253, 65);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(180, 38);
            this.lbl_titre.TabIndex = 0;
            this.lbl_titre.Text = "Bienvenue";
            // 
            // mns_accueil
            // 
            this.mns_accueil.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mns_accueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeToolStripMenuItem,
            this.inscriptionAdherentToolStripMenuItem,
            this.gestionPrêtToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.mns_accueil.Location = new System.Drawing.Point(0, 0);
            this.mns_accueil.Name = "mns_accueil";
            this.mns_accueil.Size = new System.Drawing.Size(745, 28);
            this.mns_accueil.TabIndex = 1;
            this.mns_accueil.Text = "menuStrip1";
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.listeToolStripMenuItem.Text = "Liste Livres Genre";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // inscriptionAdherentToolStripMenuItem
            // 
            this.inscriptionAdherentToolStripMenuItem.Name = "inscriptionAdherentToolStripMenuItem";
            this.inscriptionAdherentToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.inscriptionAdherentToolStripMenuItem.Text = "Inscription adherent";
            this.inscriptionAdherentToolStripMenuItem.Click += new System.EventHandler(this.inscriptionAdherentToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // gestionPrêtToolStripMenuItem
            // 
            this.gestionPrêtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeRetardatairesToolStripMenuItem,
            this.ajoutPrêtToolStripMenuItem});
            this.gestionPrêtToolStripMenuItem.Name = "gestionPrêtToolStripMenuItem";
            this.gestionPrêtToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.gestionPrêtToolStripMenuItem.Text = "Gestion prêt";
            // 
            // listeRetardatairesToolStripMenuItem
            // 
            this.listeRetardatairesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.listeRetardatairesToolStripMenuItem.Name = "listeRetardatairesToolStripMenuItem";
            this.listeRetardatairesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listeRetardatairesToolStripMenuItem.Text = "Liste retardataires";
            this.listeRetardatairesToolStripMenuItem.Click += new System.EventHandler(this.listeRetardatairesToolStripMenuItem_Click);
            // 
            // ajoutPrêtToolStripMenuItem
            // 
            this.ajoutPrêtToolStripMenuItem.Name = "ajoutPrêtToolStripMenuItem";
            this.ajoutPrêtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ajoutPrêtToolStripMenuItem.Text = "Ajout prêt";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(745, 454);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.mns_accueil);
            this.MainMenuStrip = this.mns_accueil;
            this.Name = "Accueil";
            this.Text = "Form1";
            this.mns_accueil.ResumeLayout(false);
            this.mns_accueil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.MenuStrip mns_accueil;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionAdherentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionPrêtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeRetardatairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutPrêtToolStripMenuItem;
    }
}

