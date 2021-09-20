namespace CP02Tp2
{
    partial class FrmDiapoZoo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiapoZoo));
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblEntete = new System.Windows.Forms.Label();
            this.lstAnimaux = new System.Windows.Forms.ListBox();
            this.btnDiapo = new System.Windows.Forms.Button();
            this.picAnimal = new System.Windows.Forms.PictureBox();
            this.btnPrec = new System.Windows.Forms.Button();
            this.btnSuiv = new System.Windows.Forms.Button();
            this.tmrDiapo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitre.Location = new System.Drawing.Point(170, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(468, 50);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "LES ANIMAUX DU ZOO";
            this.lblTitre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEntete
            // 
            this.lblEntete.AutoSize = true;
            this.lblEntete.Location = new System.Drawing.Point(43, 77);
            this.lblEntete.Name = "lblEntete";
            this.lblEntete.Size = new System.Drawing.Size(219, 34);
            this.lblEntete.TabIndex = 1;
            this.lblEntete.Text = "Choisir son animal pour visualiser\r\nson image correspondante";
            // 
            // lstAnimaux
            // 
            this.lstAnimaux.FormattingEnabled = true;
            this.lstAnimaux.ItemHeight = 16;
            this.lstAnimaux.Items.AddRange(new object[] {
            "Ara",
            "Autruche",
            "Casoar",
            "Chameau",
            "Chimpanze",
            "Colobe",
            "Elephant",
            "Fennec",
            "Gibbon",
            "Girafe",
            "Lion",
            "Lynx",
            "Murien",
            "Ours",
            "Pelican",
            "Zebre"});
            this.lstAnimaux.Location = new System.Drawing.Point(46, 156);
            this.lstAnimaux.Name = "lstAnimaux";
            this.lstAnimaux.Size = new System.Drawing.Size(230, 276);
            this.lstAnimaux.TabIndex = 2;
            this.lstAnimaux.Click += new System.EventHandler(this.lslAnimaux_SelectedIndexChanged);
            this.lstAnimaux.SelectedIndexChanged += new System.EventHandler(this.lslAnimaux_SelectedIndexChanged);
            // 
            // btnDiapo
            // 
            this.btnDiapo.Location = new System.Drawing.Point(100, 457);
            this.btnDiapo.Name = "btnDiapo";
            this.btnDiapo.Size = new System.Drawing.Size(107, 43);
            this.btnDiapo.TabIndex = 3;
            this.btnDiapo.Text = "Diaporama\r\nStart/Stop";
            this.btnDiapo.UseVisualStyleBackColor = true;
            this.btnDiapo.Click += new System.EventHandler(this.btnDiapo_Click);
            // 
            // picAnimal
            // 
            this.picAnimal.ErrorImage = null;
            this.picAnimal.Image = ((System.Drawing.Image)(resources.GetObject("picAnimal.Image")));
            this.picAnimal.InitialImage = ((System.Drawing.Image)(resources.GetObject("picAnimal.InitialImage")));
            this.picAnimal.Location = new System.Drawing.Point(389, 113);
            this.picAnimal.Name = "picAnimal";
            this.picAnimal.Size = new System.Drawing.Size(375, 310);
            this.picAnimal.TabIndex = 4;
            this.picAnimal.TabStop = false;
            // 
            // btnPrec
            // 
            this.btnPrec.Location = new System.Drawing.Point(484, 457);
            this.btnPrec.Name = "btnPrec";
            this.btnPrec.Size = new System.Drawing.Size(96, 43);
            this.btnPrec.TabIndex = 5;
            this.btnPrec.Text = "Précedent";
            this.btnPrec.UseVisualStyleBackColor = true;
            this.btnPrec.Click += new System.EventHandler(this.btnPrec_Click);
            // 
            // btnSuiv
            // 
            this.btnSuiv.Location = new System.Drawing.Point(631, 457);
            this.btnSuiv.Name = "btnSuiv";
            this.btnSuiv.Size = new System.Drawing.Size(133, 43);
            this.btnSuiv.TabIndex = 6;
            this.btnSuiv.Text = "Suivant";
            this.btnSuiv.UseVisualStyleBackColor = true;
            this.btnSuiv.Click += new System.EventHandler(this.btnSuiv_Click);
            // 
            // tmrDiapo
            // 
            this.tmrDiapo.Interval = 1000;
            this.tmrDiapo.Tick += new System.EventHandler(this.tmrDiapo_Tick);
            // 
            // FrmDiapoZoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.btnSuiv);
            this.Controls.Add(this.btnPrec);
            this.Controls.Add(this.picAnimal);
            this.Controls.Add(this.btnDiapo);
            this.Controls.Add(this.lstAnimaux);
            this.Controls.Add(this.lblEntete);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmDiapoZoo";
            this.Text = "Mon petit zoo Window";
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblEntete;
        private System.Windows.Forms.ListBox lstAnimaux;
        private System.Windows.Forms.Button btnDiapo;
        private System.Windows.Forms.PictureBox picAnimal;
        private System.Windows.Forms.Button btnPrec;
        private System.Windows.Forms.Button btnSuiv;
        private System.Windows.Forms.Timer tmrDiapo;
    }
}

