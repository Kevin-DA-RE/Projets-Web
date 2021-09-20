namespace CP02_Cinema
{
    partial class FrmCinoche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCinoche));
            this.lblChoixHoraire = new System.Windows.Forms.Label();
            this.lblChoixJour = new System.Windows.Forms.Label();
            this.lblTarif = new System.Windows.Forms.Label();
            this.lblTarifLundi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTarifReduit = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbAutre = new System.Windows.Forms.RadioButton();
            this.rdbEtudiant = new System.Windows.Forms.RadioButton();
            this.rdbCE = new System.Windows.Forms.RadioButton();
            this.cboHoraire = new System.Windows.Forms.ComboBox();
            this.cboJour = new System.Windows.Forms.ComboBox();
            this.chkMajoration3D = new System.Windows.Forms.CheckBox();
            this.chkCouponReduc = new System.Windows.Forms.CheckBox();
            this.btnTarifApplicable = new System.Windows.Forms.Button();
            this.lblTarifApplicable = new System.Windows.Forms.Label();
            this.btnAutreTicket = new System.Windows.Forms.Button();
            this.picTicket = new System.Windows.Forms.PictureBox();
            this.grbTarifReduit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoixHoraire
            // 
            this.lblChoixHoraire.AutoSize = true;
            this.lblChoixHoraire.Location = new System.Drawing.Point(49, 84);
            this.lblChoixHoraire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoixHoraire.Name = "lblChoixHoraire";
            this.lblChoixHoraire.Size = new System.Drawing.Size(106, 17);
            this.lblChoixHoraire.TabIndex = 2;
            this.lblChoixHoraire.Text = "Choisir l\'horaire";
            this.lblChoixHoraire.Click += new System.EventHandler(this.lblChoixHoraire_Click);
            // 
            // lblChoixJour
            // 
            this.lblChoixJour.AutoSize = true;
            this.lblChoixJour.Location = new System.Drawing.Point(48, 165);
            this.lblChoixJour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoixJour.Name = "lblChoixJour";
            this.lblChoixJour.Size = new System.Drawing.Size(99, 17);
            this.lblChoixJour.TabIndex = 3;
            this.lblChoixJour.Text = "Choisir un jour";
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.Location = new System.Drawing.Point(443, 84);
            this.lblTarif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(110, 17);
            this.lblTarif.TabIndex = 4;
            this.lblTarif.Text = "(5,20€ à 11h10)";
            // 
            // lblTarifLundi
            // 
            this.lblTarifLundi.AutoSize = true;
            this.lblTarifLundi.Location = new System.Drawing.Point(443, 165);
            this.lblTarifLundi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarifLundi.Name = "lblTarifLundi";
            this.lblTarifLundi.Size = new System.Drawing.Size(103, 17);
            this.lblTarifLundi.TabIndex = 5;
            this.lblTarifLundi.Text = "(5,70€ le lundi)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Plein Tarif: 8.70€";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbTarifReduit
            // 
            this.grbTarifReduit.Controls.Add(this.label3);
            this.grbTarifReduit.Controls.Add(this.label2);
            this.grbTarifReduit.Controls.Add(this.rdbAutre);
            this.grbTarifReduit.Controls.Add(this.rdbEtudiant);
            this.grbTarifReduit.Controls.Add(this.rdbCE);
            this.grbTarifReduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTarifReduit.Location = new System.Drawing.Point(49, 209);
            this.grbTarifReduit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbTarifReduit.Name = "grbTarifReduit";
            this.grbTarifReduit.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbTarifReduit.Size = new System.Drawing.Size(337, 199);
            this.grbTarifReduit.TabIndex = 7;
            this.grbTarifReduit.TabStop = false;
            this.grbTarifReduit.Text = "Tarif Réduit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Famille Nombreuse, Handicapé)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "(Carte Vermeil, Famille";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rdbAutre
            // 
            this.rdbAutre.AutoSize = true;
            this.rdbAutre.Location = new System.Drawing.Point(16, 111);
            this.rdbAutre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbAutre.Name = "rdbAutre";
            this.rdbAutre.Size = new System.Drawing.Size(155, 28);
            this.rdbAutre.TabIndex = 2;
            this.rdbAutre.TabStop = true;
            this.rdbAutre.Text = "Autre : 6,90 €";
            this.rdbAutre.UseVisualStyleBackColor = true;
            this.rdbAutre.CheckedChanged += new System.EventHandler(this.rdbAutre_CheckedChanged);
            // 
            // rdbEtudiant
            // 
            this.rdbEtudiant.AutoSize = true;
            this.rdbEtudiant.Location = new System.Drawing.Point(17, 76);
            this.rdbEtudiant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbEtudiant.Name = "rdbEtudiant";
            this.rdbEtudiant.Size = new System.Drawing.Size(276, 28);
            this.rdbEtudiant.TabIndex = 1;
            this.rdbEtudiant.TabStop = true;
            this.rdbEtudiant.Text = "Etudiant ou mineur: 5,90 €";
            this.rdbEtudiant.UseVisualStyleBackColor = true;
            // 
            // rdbCE
            // 
            this.rdbCE.AutoSize = true;
            this.rdbCE.Location = new System.Drawing.Point(17, 42);
            this.rdbCE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbCE.Name = "rdbCE";
            this.rdbCE.Size = new System.Drawing.Size(281, 28);
            this.rdbCE.TabIndex = 0;
            this.rdbCE.TabStop = true;
            this.rdbCE.Text = "Comité d\'entreprise: 5,20 €";
            this.rdbCE.UseVisualStyleBackColor = true;
            this.rdbCE.CheckedChanged += new System.EventHandler(this.rdbCE_CheckedChanged);
            // 
            // cboHoraire
            // 
            this.cboHoraire.FormattingEnabled = true;
            this.cboHoraire.Items.AddRange(new object[] {
            "11h10",
            "13h10",
            "15h10",
            "18h10",
            "20h10",
            "22h10",
            ""});
            this.cboHoraire.Location = new System.Drawing.Point(233, 74);
            this.cboHoraire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboHoraire.Name = "cboHoraire";
            this.cboHoraire.Size = new System.Drawing.Size(160, 24);
            this.cboHoraire.TabIndex = 8;
            this.cboHoraire.SelectedIndexChanged += new System.EventHandler(this.cboHoraire_SelectedIndexChanged);
            // 
            // cboJour
            // 
            this.cboJour.FormattingEnabled = true;
            this.cboJour.Items.AddRange(new object[] {
            "Lundi",
            "Mardi",
            "Mercredi",
            "Jeudi",
            "Vendredi",
            "Samedi",
            "Dimanche"});
            this.cboJour.Location = new System.Drawing.Point(233, 161);
            this.cboJour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboJour.Name = "cboJour";
            this.cboJour.Size = new System.Drawing.Size(160, 24);
            this.cboJour.TabIndex = 9;
            // 
            // chkMajoration3D
            // 
            this.chkMajoration3D.AutoSize = true;
            this.chkMajoration3D.Location = new System.Drawing.Point(67, 416);
            this.chkMajoration3D.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMajoration3D.Name = "chkMajoration3D";
            this.chkMajoration3D.Size = new System.Drawing.Size(199, 21);
            this.chkMajoration3D.TabIndex = 10;
            this.chkMajoration3D.Text = "Majoration Film 3D : 1,50 €";
            this.chkMajoration3D.UseVisualStyleBackColor = true;
            // 
            // chkCouponReduc
            // 
            this.chkCouponReduc.AutoSize = true;
            this.chkCouponReduc.Location = new System.Drawing.Point(67, 460);
            this.chkCouponReduc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCouponReduc.Name = "chkCouponReduc";
            this.chkCouponReduc.Size = new System.Drawing.Size(179, 21);
            this.chkCouponReduc.TabIndex = 11;
            this.chkCouponReduc.Text = "Coupon Réduction : 1 €";
            this.chkCouponReduc.UseVisualStyleBackColor = true;
            // 
            // btnTarifApplicable
            // 
            this.btnTarifApplicable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTarifApplicable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarifApplicable.ForeColor = System.Drawing.Color.Black;
            this.btnTarifApplicable.Location = new System.Drawing.Point(717, 332);
            this.btnTarifApplicable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTarifApplicable.Name = "btnTarifApplicable";
            this.btnTarifApplicable.Size = new System.Drawing.Size(319, 63);
            this.btnTarifApplicable.TabIndex = 12;
            this.btnTarifApplicable.Text = "Tarif Applicable";
            this.btnTarifApplicable.UseVisualStyleBackColor = false;
            this.btnTarifApplicable.Click += new System.EventHandler(this.btnTarifApplicable_Click);
            // 
            // lblTarifApplicable
            // 
            this.lblTarifApplicable.AutoSize = true;
            this.lblTarifApplicable.BackColor = System.Drawing.Color.LightCoral;
            this.lblTarifApplicable.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifApplicable.Location = new System.Drawing.Point(756, 430);
            this.lblTarifApplicable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarifApplicable.Name = "lblTarifApplicable";
            this.lblTarifApplicable.Size = new System.Drawing.Size(152, 54);
            this.lblTarifApplicable.TabIndex = 13;
            this.lblTarifApplicable.Text = "0,00 €";
            // 
            // btnAutreTicket
            // 
            this.btnAutreTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAutreTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutreTicket.Location = new System.Drawing.Point(399, 460);
            this.btnAutreTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAutreTicket.Name = "btnAutreTicket";
            this.btnAutreTicket.Size = new System.Drawing.Size(240, 63);
            this.btnAutreTicket.TabIndex = 14;
            this.btnAutreTicket.Text = "Autre Ticket";
            this.btnAutreTicket.UseVisualStyleBackColor = false;
            this.btnAutreTicket.Click += new System.EventHandler(this.btnAutreTicket_Click);
            // 
            // picTicket
            // 
            this.picTicket.ErrorImage = null;
            this.picTicket.Image = ((System.Drawing.Image)(resources.GetObject("picTicket.Image")));
            this.picTicket.Location = new System.Drawing.Point(777, 96);
            this.picTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picTicket.Name = "picTicket";
            this.picTicket.Size = new System.Drawing.Size(200, 165);
            this.picTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTicket.TabIndex = 15;
            this.picTicket.TabStop = false;
            // 
            // FrmCinoche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.picTicket);
            this.Controls.Add(this.btnAutreTicket);
            this.Controls.Add(this.lblTarifApplicable);
            this.Controls.Add(this.btnTarifApplicable);
            this.Controls.Add(this.chkCouponReduc);
            this.Controls.Add(this.chkMajoration3D);
            this.Controls.Add(this.cboJour);
            this.Controls.Add(this.cboHoraire);
            this.Controls.Add(this.grbTarifReduit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTarifLundi);
            this.Controls.Add(this.lblTarif);
            this.Controls.Add(this.lblChoixJour);
            this.Controls.Add(this.lblChoixHoraire);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCinoche";
            this.Text = "Logiciel Le Greta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbTarifReduit.ResumeLayout(false);
            this.grbTarifReduit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblChoixHoraire;
        private System.Windows.Forms.Label lblChoixJour;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.Label lblTarifLundi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbTarifReduit;
        private System.Windows.Forms.RadioButton rdbCE;
        private System.Windows.Forms.ComboBox cboHoraire;
        private System.Windows.Forms.ComboBox cboJour;
        private System.Windows.Forms.RadioButton rdbAutre;
        private System.Windows.Forms.RadioButton rdbEtudiant;
        private System.Windows.Forms.CheckBox chkMajoration3D;
        private System.Windows.Forms.CheckBox chkCouponReduc;
        private System.Windows.Forms.Button btnTarifApplicable;
        private System.Windows.Forms.Label lblTarifApplicable;
        private System.Windows.Forms.Button btnAutreTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picTicket;
    }
}

