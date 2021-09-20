namespace AboMultisport_AR_KD
{
    partial class FrmInscrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInscrip));
            this.label1 = new System.Windows.Forms.Label();
            this.gb_etatCivil = new System.Windows.Forms.GroupBox();
            this.bt_inscrip_valid = new System.Windows.Forms.Button();
            this.rb_masculin = new System.Windows.Forms.RadioButton();
            this.rb_feminin = new System.Windows.Forms.RadioButton();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_telPort = new System.Windows.Forms.TextBox();
            this.txt_telFixe = new System.Windows.Forms.TextBox();
            this.txt_ville = new System.Windows.Forms.TextBox();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.txt_rue = new System.Windows.Forms.TextBox();
            this.txt_dateNaissance = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_Cotisation = new System.Windows.Forms.GroupBox();
            this.bt_valid = new System.Windows.Forms.Button();
            this.lbl_prix = new System.Windows.Forms.Label();
            this.lbl_resultCotis = new System.Windows.Forms.Label();
            this.bt_calcul = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_typeReglement = new System.Windows.Forms.GroupBox();
            this.rb_cb = new System.Windows.Forms.RadioButton();
            this.rb_cheque = new System.Windows.Forms.RadioButton();
            this.gb_Periode = new System.Windows.Forms.GroupBox();
            this.lbl_date_fin = new System.Windows.Forms.Label();
            this.dtp_debut = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbo_inscrip = new System.Windows.Forms.ComboBox();
            this.gb_etatCivil.SuspendLayout();
            this.gb_Cotisation.SuspendLayout();
            this.gb_typeReglement.SuspendLayout();
            this.gb_Periode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(396, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "BULLETIN D\'INSCRIPTION";
            // 
            // gb_etatCivil
            // 
            this.gb_etatCivil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_etatCivil.Controls.Add(this.bt_inscrip_valid);
            this.gb_etatCivil.Controls.Add(this.rb_masculin);
            this.gb_etatCivil.Controls.Add(this.rb_feminin);
            this.gb_etatCivil.Controls.Add(this.txt_mail);
            this.gb_etatCivil.Controls.Add(this.txt_telPort);
            this.gb_etatCivil.Controls.Add(this.txt_telFixe);
            this.gb_etatCivil.Controls.Add(this.txt_ville);
            this.gb_etatCivil.Controls.Add(this.txt_cp);
            this.gb_etatCivil.Controls.Add(this.txt_rue);
            this.gb_etatCivil.Controls.Add(this.txt_dateNaissance);
            this.gb_etatCivil.Controls.Add(this.txt_prenom);
            this.gb_etatCivil.Controls.Add(this.txt_nom);
            this.gb_etatCivil.Controls.Add(this.label11);
            this.gb_etatCivil.Controls.Add(this.label10);
            this.gb_etatCivil.Controls.Add(this.label9);
            this.gb_etatCivil.Controls.Add(this.label8);
            this.gb_etatCivil.Controls.Add(this.label7);
            this.gb_etatCivil.Controls.Add(this.label6);
            this.gb_etatCivil.Controls.Add(this.label5);
            this.gb_etatCivil.Controls.Add(this.label4);
            this.gb_etatCivil.Controls.Add(this.label3);
            this.gb_etatCivil.Controls.Add(this.label2);
            this.gb_etatCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_etatCivil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb_etatCivil.Location = new System.Drawing.Point(133, 127);
            this.gb_etatCivil.Name = "gb_etatCivil";
            this.gb_etatCivil.Size = new System.Drawing.Size(1023, 377);
            this.gb_etatCivil.TabIndex = 1;
            this.gb_etatCivil.TabStop = false;
            this.gb_etatCivil.Text = "Etat civil";
            // 
            // bt_inscrip_valid
            // 
            this.bt_inscrip_valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inscrip_valid.ForeColor = System.Drawing.Color.Blue;
            this.bt_inscrip_valid.Location = new System.Drawing.Point(404, 327);
            this.bt_inscrip_valid.Name = "bt_inscrip_valid";
            this.bt_inscrip_valid.Size = new System.Drawing.Size(258, 34);
            this.bt_inscrip_valid.TabIndex = 13;
            this.bt_inscrip_valid.Text = "Valider l\'abonner";
            this.bt_inscrip_valid.UseVisualStyleBackColor = true;
            this.bt_inscrip_valid.Click += new System.EventHandler(this.bt_inscrip_valid_Click);
            // 
            // rb_masculin
            // 
            this.rb_masculin.AutoSize = true;
            this.rb_masculin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_masculin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rb_masculin.Location = new System.Drawing.Point(801, 85);
            this.rb_masculin.Name = "rb_masculin";
            this.rb_masculin.Size = new System.Drawing.Size(111, 29);
            this.rb_masculin.TabIndex = 5;
            this.rb_masculin.TabStop = true;
            this.rb_masculin.Text = "Masculin";
            this.rb_masculin.UseVisualStyleBackColor = true;
            // 
            // rb_feminin
            // 
            this.rb_feminin.AutoSize = true;
            this.rb_feminin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_feminin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rb_feminin.Location = new System.Drawing.Point(630, 85);
            this.rb_feminin.Name = "rb_feminin";
            this.rb_feminin.Size = new System.Drawing.Size(102, 29);
            this.rb_feminin.TabIndex = 4;
            this.rb_feminin.TabStop = true;
            this.rb_feminin.Text = "Féminin";
            this.rb_feminin.UseVisualStyleBackColor = true;
            this.rb_feminin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rb_feminin_KeyPress);
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mail.Location = new System.Drawing.Point(211, 285);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(701, 30);
            this.txt_mail.TabIndex = 11;
            // 
            // txt_telPort
            // 
            this.txt_telPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telPort.Location = new System.Drawing.Point(630, 236);
            this.txt_telPort.Name = "txt_telPort";
            this.txt_telPort.Size = new System.Drawing.Size(282, 30);
            this.txt_telPort.TabIndex = 10;
            // 
            // txt_telFixe
            // 
            this.txt_telFixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telFixe.Location = new System.Drawing.Point(211, 241);
            this.txt_telFixe.Name = "txt_telFixe";
            this.txt_telFixe.Size = new System.Drawing.Size(217, 30);
            this.txt_telFixe.TabIndex = 9;
            this.txt_telFixe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telFixe_KeyPress);
            // 
            // txt_ville
            // 
            this.txt_ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ville.Location = new System.Drawing.Point(630, 180);
            this.txt_ville.Name = "txt_ville";
            this.txt_ville.Size = new System.Drawing.Size(282, 30);
            this.txt_ville.TabIndex = 8;
            // 
            // txt_cp
            // 
            this.txt_cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cp.Location = new System.Drawing.Point(211, 182);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(217, 30);
            this.txt_cp.TabIndex = 7;
            // 
            // txt_rue
            // 
            this.txt_rue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rue.Location = new System.Drawing.Point(211, 136);
            this.txt_rue.Name = "txt_rue";
            this.txt_rue.Size = new System.Drawing.Size(701, 30);
            this.txt_rue.TabIndex = 6;
            // 
            // txt_dateNaissance
            // 
            this.txt_dateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dateNaissance.Location = new System.Drawing.Point(211, 84);
            this.txt_dateNaissance.Name = "txt_dateNaissance";
            this.txt_dateNaissance.Size = new System.Drawing.Size(217, 30);
            this.txt_dateNaissance.TabIndex = 3;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prenom.Location = new System.Drawing.Point(630, 28);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(282, 30);
            this.txt_prenom.TabIndex = 2;
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(211, 28);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(217, 30);
            this.txt_nom.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(493, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Portable * :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(493, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ville * :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(493, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Sexe * :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(493, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Prénom * :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Adresse mail * :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tél fixe * :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Code postal * :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rue * :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date naissance * :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom * :";
            // 
            // gb_Cotisation
            // 
            this.gb_Cotisation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_Cotisation.Controls.Add(this.bt_valid);
            this.gb_Cotisation.Controls.Add(this.lbl_prix);
            this.gb_Cotisation.Controls.Add(this.lbl_resultCotis);
            this.gb_Cotisation.Controls.Add(this.bt_calcul);
            this.gb_Cotisation.Controls.Add(this.label12);
            this.gb_Cotisation.Controls.Add(this.gb_typeReglement);
            this.gb_Cotisation.Controls.Add(this.gb_Periode);
            this.gb_Cotisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Cotisation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb_Cotisation.Location = new System.Drawing.Point(133, 510);
            this.gb_Cotisation.Name = "gb_Cotisation";
            this.gb_Cotisation.Size = new System.Drawing.Size(1023, 231);
            this.gb_Cotisation.TabIndex = 2;
            this.gb_Cotisation.TabStop = false;
            this.gb_Cotisation.Text = "Cotisation";
            // 
            // bt_valid
            // 
            this.bt_valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_valid.ForeColor = System.Drawing.Color.Blue;
            this.bt_valid.Location = new System.Drawing.Point(39, 153);
            this.bt_valid.Name = "bt_valid";
            this.bt_valid.Size = new System.Drawing.Size(104, 55);
            this.bt_valid.TabIndex = 13;
            this.bt_valid.Text = "Valider";
            this.bt_valid.UseVisualStyleBackColor = true;
            this.bt_valid.Click += new System.EventHandler(this.bt_valid_Click);
            // 
            // lbl_prix
            // 
            this.lbl_prix.AutoSize = true;
            this.lbl_prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prix.ForeColor = System.Drawing.Color.Black;
            this.lbl_prix.Location = new System.Drawing.Point(112, 50);
            this.lbl_prix.Name = "lbl_prix";
            this.lbl_prix.Size = new System.Drawing.Size(66, 25);
            this.lbl_prix.TabIndex = 11;
            this.lbl_prix.Text = " 0.00€";
            // 
            // lbl_resultCotis
            // 
            this.lbl_resultCotis.AutoSize = true;
            this.lbl_resultCotis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultCotis.ForeColor = System.Drawing.Color.Black;
            this.lbl_resultCotis.Location = new System.Drawing.Point(222, 192);
            this.lbl_resultCotis.Name = "lbl_resultCotis";
            this.lbl_resultCotis.Size = new System.Drawing.Size(42, 25);
            this.lbl_resultCotis.TabIndex = 5;
            this.lbl_resultCotis.Text = "lbl2";
            // 
            // bt_calcul
            // 
            this.bt_calcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calcul.ForeColor = System.Drawing.Color.Blue;
            this.bt_calcul.Location = new System.Drawing.Point(39, 83);
            this.bt_calcul.Name = "bt_calcul";
            this.bt_calcul.Size = new System.Drawing.Size(104, 55);
            this.bt_calcul.TabIndex = 12;
            this.bt_calcul.Text = "Calcul";
            this.bt_calcul.UseVisualStyleBackColor = true;
            this.bt_calcul.Click += new System.EventHandler(this.bt_calcul_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(10, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "Montant ";
            // 
            // gb_typeReglement
            // 
            this.gb_typeReglement.Controls.Add(this.rb_cb);
            this.gb_typeReglement.Controls.Add(this.rb_cheque);
            this.gb_typeReglement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_typeReglement.Location = new System.Drawing.Point(630, 39);
            this.gb_typeReglement.Name = "gb_typeReglement";
            this.gb_typeReglement.Size = new System.Drawing.Size(347, 137);
            this.gb_typeReglement.TabIndex = 1;
            this.gb_typeReglement.TabStop = false;
            this.gb_typeReglement.Text = "Type règlement";
            // 
            // rb_cb
            // 
            this.rb_cb.AutoSize = true;
            this.rb_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_cb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rb_cb.Location = new System.Drawing.Point(152, 59);
            this.rb_cb.Name = "rb_cb";
            this.rb_cb.Size = new System.Drawing.Size(154, 24);
            this.rb_cb.TabIndex = 21;
            this.rb_cb.TabStop = true;
            this.rb_cb.Text = "Carte bancaire";
            this.rb_cb.UseVisualStyleBackColor = true;
            // 
            // rb_cheque
            // 
            this.rb_cheque.AutoSize = true;
            this.rb_cheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_cheque.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rb_cheque.Location = new System.Drawing.Point(23, 55);
            this.rb_cheque.Name = "rb_cheque";
            this.rb_cheque.Size = new System.Drawing.Size(93, 24);
            this.rb_cheque.TabIndex = 20;
            this.rb_cheque.TabStop = true;
            this.rb_cheque.Text = "Chèque";
            this.rb_cheque.UseVisualStyleBackColor = true;
            // 
            // gb_Periode
            // 
            this.gb_Periode.Controls.Add(this.lbl_date_fin);
            this.gb_Periode.Controls.Add(this.dtp_debut);
            this.gb_Periode.Controls.Add(this.label14);
            this.gb_Periode.Controls.Add(this.label13);
            this.gb_Periode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Periode.Location = new System.Drawing.Point(211, 39);
            this.gb_Periode.Name = "gb_Periode";
            this.gb_Periode.Size = new System.Drawing.Size(324, 137);
            this.gb_Periode.TabIndex = 0;
            this.gb_Periode.TabStop = false;
            this.gb_Periode.Text = "Période";
            // 
            // lbl_date_fin
            // 
            this.lbl_date_fin.AutoSize = true;
            this.lbl_date_fin.Location = new System.Drawing.Point(81, 89);
            this.lbl_date_fin.Name = "lbl_date_fin";
            this.lbl_date_fin.Size = new System.Drawing.Size(42, 25);
            this.lbl_date_fin.TabIndex = 12;
            this.lbl_date_fin.Text = "lbl1";
            // 
            // dtp_debut
            // 
            this.dtp_debut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_debut.Location = new System.Drawing.Point(86, 44);
            this.dtp_debut.Name = "dtp_debut";
            this.dtp_debut.Size = new System.Drawing.Size(191, 30);
            this.dtp_debut.TabIndex = 12;
            this.dtp_debut.Value = new System.DateTime(2020, 10, 26, 17, 54, 44, 0);
            this.dtp_debut.ValueChanged += new System.EventHandler(this.dtp_debut_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(23, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 25);
            this.label14.TabIndex = 11;
            this.label14.Text = "au :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(23, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 25);
            this.label13.TabIndex = 10;
            this.label13.Text = "du :";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(1015, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 29);
            this.label15.TabIndex = 3;
            this.label15.Text = "27/10/2020";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cbo_inscrip
            // 
            this.cbo_inscrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_inscrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_inscrip.FormattingEnabled = true;
            this.cbo_inscrip.Location = new System.Drawing.Point(372, 82);
            this.cbo_inscrip.Name = "cbo_inscrip";
            this.cbo_inscrip.Size = new System.Drawing.Size(510, 30);
            this.cbo_inscrip.TabIndex = 5;
            this.cbo_inscrip.SelectedIndexChanged += new System.EventHandler(this.cbo_inscrip_SelectedIndexChanged);
            // 
            // FrmInscrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.cbo_inscrip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gb_Cotisation);
            this.Controls.Add(this.gb_etatCivil);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInscrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Office des Sports - Formulaire d\'inscription";
            this.Load += new System.EventHandler(this.FrmAbo_Load);
            this.gb_etatCivil.ResumeLayout(false);
            this.gb_etatCivil.PerformLayout();
            this.gb_Cotisation.ResumeLayout(false);
            this.gb_Cotisation.PerformLayout();
            this.gb_typeReglement.ResumeLayout(false);
            this.gb_typeReglement.PerformLayout();
            this.gb_Periode.ResumeLayout(false);
            this.gb_Periode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_etatCivil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_Cotisation;
        private System.Windows.Forms.GroupBox gb_typeReglement;
        private System.Windows.Forms.GroupBox gb_Periode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_dateNaissance;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_rue;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_telPort;
        private System.Windows.Forms.TextBox txt_telFixe;
        private System.Windows.Forms.TextBox txt_ville;
        private System.Windows.Forms.RadioButton rb_masculin;
        private System.Windows.Forms.RadioButton rb_feminin;
        private System.Windows.Forms.RadioButton rb_cb;
        private System.Windows.Forms.RadioButton rb_cheque;
        private System.Windows.Forms.Button bt_calcul;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_resultCotis;
        private System.Windows.Forms.Label lbl_prix;
        private System.Windows.Forms.DateTimePicker dtp_debut;
        private System.Windows.Forms.Label lbl_date_fin;
        private System.Windows.Forms.Button bt_inscrip_valid;
        private System.Windows.Forms.Button bt_valid;
        private System.Windows.Forms.ComboBox cbo_inscrip;
    }
}

