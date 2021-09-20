namespace WinBiblio
{
    partial class FrmInscriptionAdherent
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
            this.lbl_titre = new System.Windows.Forms.Label();
            this.grbAdherent = new System.Windows.Forms.GroupBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMel = new System.Windows.Forms.TextBox();
            this.grbAdresse = new System.Windows.Forms.GroupBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnInscrire = new System.Windows.Forms.Button();
            this.grbAdherent.SuspendLayout();
            this.grbAdresse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(155, 35);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(322, 38);
            this.lbl_titre.TabIndex = 2;
            this.lbl_titre.Text = "Inscription adherent";
            // 
            // grbAdherent
            // 
            this.grbAdherent.Controls.Add(this.txtPrenom);
            this.grbAdherent.Controls.Add(this.txtNom);
            this.grbAdherent.Controls.Add(this.txtTel);
            this.grbAdherent.Controls.Add(this.txtMel);
            this.grbAdherent.Controls.Add(this.grbAdresse);
            this.grbAdherent.Controls.Add(this.label7);
            this.grbAdherent.Controls.Add(this.label2);
            this.grbAdherent.Controls.Add(this.label1);
            this.grbAdherent.Controls.Add(this.label6);
            this.grbAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAdherent.Location = new System.Drawing.Point(24, 100);
            this.grbAdherent.Name = "grbAdherent";
            this.grbAdherent.Size = new System.Drawing.Size(570, 367);
            this.grbAdherent.TabIndex = 3;
            this.grbAdherent.TabStop = false;
            this.grbAdherent.Text = "Adhérent";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(130, 86);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(414, 28);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(130, 43);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(414, 28);
            this.txtNom.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(83, 270);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(461, 28);
            this.txtTel.TabIndex = 11;
            // 
            // txtMel
            // 
            this.txtMel.Location = new System.Drawing.Point(83, 312);
            this.txtMel.Name = "txtMel";
            this.txtMel.Size = new System.Drawing.Size(461, 28);
            this.txtMel.TabIndex = 12;
            // 
            // grbAdresse
            // 
            this.grbAdresse.Controls.Add(this.txtVille);
            this.grbAdresse.Controls.Add(this.txtCP);
            this.grbAdresse.Controls.Add(this.txtRue);
            this.grbAdresse.Controls.Add(this.label5);
            this.grbAdresse.Controls.Add(this.label4);
            this.grbAdresse.Controls.Add(this.label3);
            this.grbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAdresse.Location = new System.Drawing.Point(10, 127);
            this.grbAdresse.Name = "grbAdresse";
            this.grbAdresse.Size = new System.Drawing.Size(554, 144);
            this.grbAdresse.TabIndex = 4;
            this.grbAdresse.TabStop = false;
            this.grbAdresse.Text = "Adresse";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(297, 82);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(237, 28);
            this.txtVille.TabIndex = 14;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(73, 82);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(149, 28);
            this.txtCP.TabIndex = 13;
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(73, 43);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(461, 28);
            this.txtRue.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ville* :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "CP* :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rue* :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prénom* :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom* :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tel* :";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(120, 473);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(113, 44);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnInscrire
            // 
            this.btnInscrire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscrire.Location = new System.Drawing.Point(411, 473);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(113, 44);
            this.btnInscrire.TabIndex = 6;
            this.btnInscrire.Text = "Inscrire";
            this.btnInscrire.UseVisualStyleBackColor = true;
            this.btnInscrire.Click += new System.EventHandler(this.btnInscrire_Click);
            // 
            // FrmInscriptionAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(616, 540);
            this.Controls.Add(this.btnInscrire);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.grbAdherent);
            this.Controls.Add(this.lbl_titre);
            this.Name = "FrmInscriptionAdherent";
            this.Text = "Bibliothèque Jacques Prévert ";
            this.grbAdherent.ResumeLayout(false);
            this.grbAdherent.PerformLayout();
            this.grbAdresse.ResumeLayout(false);
            this.grbAdresse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.GroupBox grbAdherent;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbAdresse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtMel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnInscrire;
    }
}