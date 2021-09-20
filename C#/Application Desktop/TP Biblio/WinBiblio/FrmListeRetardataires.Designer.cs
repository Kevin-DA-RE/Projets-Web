namespace WinBiblio
{
    partial class FrmListeRetardataires
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListeRetardataires = new System.Windows.Forms.DataGridView();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEmprunt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRetourPrevue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreJoursRetard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeRetardataires)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListeRetardataires
            // 
            this.dgvListeRetardataires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListeRetardataires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeRetardataires.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Prenom,
            this.DateEmprunt,
            this.DateRetourPrevue,
            this.NombreJoursRetard});
            this.dgvListeRetardataires.Location = new System.Drawing.Point(12, 114);
            this.dgvListeRetardataires.Name = "dgvListeRetardataires";
            this.dgvListeRetardataires.RowHeadersVisible = false;
            this.dgvListeRetardataires.RowHeadersWidth = 51;
            this.dgvListeRetardataires.RowTemplate.Height = 24;
            this.dgvListeRetardataires.Size = new System.Drawing.Size(776, 324);
            this.dgvListeRetardataires.TabIndex = 0;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(82, 42);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(388, 38);
            this.lbl_titre.TabIndex = 3;
            this.lbl_titre.Text = "Retard retour de pret au";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(509, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(170, 38);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "9/11/2020";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.MinimumWidth = 6;
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // DateEmprunt
            // 
            this.DateEmprunt.HeaderText = "Date emprunt";
            this.DateEmprunt.MinimumWidth = 6;
            this.DateEmprunt.Name = "DateEmprunt";
            this.DateEmprunt.ReadOnly = true;
            // 
            // DateRetourPrevue
            // 
            this.DateRetourPrevue.HeaderText = "Date retour prevue";
            this.DateRetourPrevue.MinimumWidth = 6;
            this.DateRetourPrevue.Name = "DateRetourPrevue";
            this.DateRetourPrevue.ReadOnly = true;
            // 
            // NombreJoursRetard
            // 
            this.NombreJoursRetard.HeaderText = "Nombre de jours retard";
            this.NombreJoursRetard.MinimumWidth = 6;
            this.NombreJoursRetard.Name = "NombreJoursRetard";
            this.NombreJoursRetard.ReadOnly = true;
            // 
            // FrmListeRetardataires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.dgvListeRetardataires);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListeRetardataires";
            this.Text = "Bibliothèque Jacques Prévert ";
            this.Load += new System.EventHandler(this.FrmListeRetardataires_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeRetardataires)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListeRetardataires;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEmprunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRetourPrevue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreJoursRetard;
    }
}