namespace AppWindoBanque
{
    partial class FrmBanque
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
            this.tab_OngletsApplications = new System.Windows.Forms.TabControl();
            this.tabAcceuil = new System.Windows.Forms.TabPage();
            this.dgv_ListeComptes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ac_Titre = new System.Windows.Forms.Label();
            this.tabConsultation = new System.Windows.Forms.TabPage();
            this.txt_co_SoldeActuel = new System.Windows.Forms.TextBox();
            this.txt_co_Titulaire = new System.Windows.Forms.TextBox();
            this.txt_co_Numero = new System.Windows.Forms.TextBox();
            this.cbo_co_ChoixCompte = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabCreation = new System.Windows.Forms.TabPage();
            this.btn_cr_Annuler = new System.Windows.Forms.Button();
            this.btn_cr_Creer = new System.Windows.Forms.Button();
            this.txt_cr_SoldeInitial = new System.Windows.Forms.TextBox();
            this.txt_cr_Titulaire = new System.Windows.Forms.TextBox();
            this.txt_cr_Numero = new System.Windows.Forms.TextBox();
            this.lbl_cr_Message = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabVersement = new System.Windows.Forms.TabPage();
            this.btn_ve_Annuler = new System.Windows.Forms.Button();
            this.btn_ve_Enregistrer = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_ve_Montant_A_Crediter = new System.Windows.Forms.TextBox();
            this.cbo_ve_ChoixCompte = new System.Windows.Forms.ComboBox();
            this.lbl_ve_Message = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabRetrait = new System.Windows.Forms.TabPage();
            this.tabVirement = new System.Windows.Forms.TabPage();
            this.tab_OngletsApplications.SuspendLayout();
            this.tabAcceuil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeComptes)).BeginInit();
            this.tabConsultation.SuspendLayout();
            this.tabCreation.SuspendLayout();
            this.tabVersement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_OngletsApplications
            // 
            this.tab_OngletsApplications.Controls.Add(this.tabAcceuil);
            this.tab_OngletsApplications.Controls.Add(this.tabConsultation);
            this.tab_OngletsApplications.Controls.Add(this.tabCreation);
            this.tab_OngletsApplications.Controls.Add(this.tabVersement);
            this.tab_OngletsApplications.Controls.Add(this.tabRetrait);
            this.tab_OngletsApplications.Controls.Add(this.tabVirement);
            this.tab_OngletsApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_OngletsApplications.Location = new System.Drawing.Point(0, 0);
            this.tab_OngletsApplications.Name = "tab_OngletsApplications";
            this.tab_OngletsApplications.SelectedIndex = 0;
            this.tab_OngletsApplications.Size = new System.Drawing.Size(800, 450);
            this.tab_OngletsApplications.TabIndex = 0;
            // 
            // tabAcceuil
            // 
            this.tabAcceuil.Controls.Add(this.dgv_ListeComptes);
            this.tabAcceuil.Controls.Add(this.label1);
            this.tabAcceuil.Controls.Add(this.lbl_ac_Titre);
            this.tabAcceuil.Location = new System.Drawing.Point(4, 25);
            this.tabAcceuil.Name = "tabAcceuil";
            this.tabAcceuil.Padding = new System.Windows.Forms.Padding(3);
            this.tabAcceuil.Size = new System.Drawing.Size(792, 421);
            this.tabAcceuil.TabIndex = 0;
            this.tabAcceuil.Text = "Acceuil";
            this.tabAcceuil.UseVisualStyleBackColor = true;
            this.tabAcceuil.Enter += new System.EventHandler(this.tabAcceuil_Enter);
            // 
            // dgv_ListeComptes
            // 
            this.dgv_ListeComptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeComptes.Location = new System.Drawing.Point(8, 204);
            this.dgv_ListeComptes.Name = "dgv_ListeComptes";
            this.dgv_ListeComptes.RowHeadersWidth = 51;
            this.dgv_ListeComptes.RowTemplate.Height = 24;
            this.dgv_ListeComptes.Size = new System.Drawing.Size(765, 171);
            this.dgv_ListeComptes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(48, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des comptes de l\'agence";
            // 
            // lbl_ac_Titre
            // 
            this.lbl_ac_Titre.AutoSize = true;
            this.lbl_ac_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ac_Titre.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_ac_Titre.Location = new System.Drawing.Point(202, 46);
            this.lbl_ac_Titre.Name = "lbl_ac_Titre";
            this.lbl_ac_Titre.Size = new System.Drawing.Size(396, 46);
            this.lbl_ac_Titre.TabIndex = 0;
            this.lbl_ac_Titre.Text = "AGENCE de MENTA";
            // 
            // tabConsultation
            // 
            this.tabConsultation.Controls.Add(this.txt_co_SoldeActuel);
            this.tabConsultation.Controls.Add(this.txt_co_Titulaire);
            this.tabConsultation.Controls.Add(this.txt_co_Numero);
            this.tabConsultation.Controls.Add(this.cbo_co_ChoixCompte);
            this.tabConsultation.Controls.Add(this.label6);
            this.tabConsultation.Controls.Add(this.label5);
            this.tabConsultation.Controls.Add(this.label4);
            this.tabConsultation.Controls.Add(this.label3);
            this.tabConsultation.Controls.Add(this.label2);
            this.tabConsultation.Location = new System.Drawing.Point(4, 25);
            this.tabConsultation.Name = "tabConsultation";
            this.tabConsultation.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultation.Size = new System.Drawing.Size(792, 421);
            this.tabConsultation.TabIndex = 1;
            this.tabConsultation.Text = "Consultation";
            this.tabConsultation.UseVisualStyleBackColor = true;
            this.tabConsultation.Enter += new System.EventHandler(this.tabConsultation_Enter);
            // 
            // txt_co_SoldeActuel
            // 
            this.txt_co_SoldeActuel.Location = new System.Drawing.Point(340, 296);
            this.txt_co_SoldeActuel.Name = "txt_co_SoldeActuel";
            this.txt_co_SoldeActuel.Size = new System.Drawing.Size(314, 22);
            this.txt_co_SoldeActuel.TabIndex = 8;
            // 
            // txt_co_Titulaire
            // 
            this.txt_co_Titulaire.Location = new System.Drawing.Point(340, 216);
            this.txt_co_Titulaire.Name = "txt_co_Titulaire";
            this.txt_co_Titulaire.Size = new System.Drawing.Size(314, 22);
            this.txt_co_Titulaire.TabIndex = 7;
            // 
            // txt_co_Numero
            // 
            this.txt_co_Numero.Location = new System.Drawing.Point(340, 170);
            this.txt_co_Numero.Name = "txt_co_Numero";
            this.txt_co_Numero.Size = new System.Drawing.Size(314, 22);
            this.txt_co_Numero.TabIndex = 6;
            // 
            // cbo_co_ChoixCompte
            // 
            this.cbo_co_ChoixCompte.FormattingEnabled = true;
            this.cbo_co_ChoixCompte.Location = new System.Drawing.Point(340, 120);
            this.cbo_co_ChoixCompte.Name = "cbo_co_ChoixCompte";
            this.cbo_co_ChoixCompte.Size = new System.Drawing.Size(314, 24);
            this.cbo_co_ChoixCompte.TabIndex = 5;
            this.cbo_co_ChoixCompte.SelectedIndexChanged += new System.EventHandler(this.cbo_co_ChoixCompte_SelectedIndexChanged);
            this.cbo_co_ChoixCompte.Enter += new System.EventHandler(this.cbo_co_ChoixCompte_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(44, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Solde actuel du compte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(44, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Titulaire du compte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(44, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero de compte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(44, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Choisir un compte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(139, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(581, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "CONSULTATION DE COMPTE";
            // 
            // tabCreation
            // 
            this.tabCreation.Controls.Add(this.btn_cr_Annuler);
            this.tabCreation.Controls.Add(this.btn_cr_Creer);
            this.tabCreation.Controls.Add(this.txt_cr_SoldeInitial);
            this.tabCreation.Controls.Add(this.txt_cr_Titulaire);
            this.tabCreation.Controls.Add(this.txt_cr_Numero);
            this.tabCreation.Controls.Add(this.lbl_cr_Message);
            this.tabCreation.Controls.Add(this.label10);
            this.tabCreation.Controls.Add(this.label9);
            this.tabCreation.Controls.Add(this.label8);
            this.tabCreation.Controls.Add(this.label7);
            this.tabCreation.Location = new System.Drawing.Point(4, 25);
            this.tabCreation.Name = "tabCreation";
            this.tabCreation.Size = new System.Drawing.Size(792, 421);
            this.tabCreation.TabIndex = 2;
            this.tabCreation.Text = "Creation";
            this.tabCreation.UseVisualStyleBackColor = true;
            // 
            // btn_cr_Annuler
            // 
            this.btn_cr_Annuler.BackColor = System.Drawing.Color.Red;
            this.btn_cr_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cr_Annuler.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_cr_Annuler.Location = new System.Drawing.Point(543, 361);
            this.btn_cr_Annuler.Name = "btn_cr_Annuler";
            this.btn_cr_Annuler.Size = new System.Drawing.Size(186, 52);
            this.btn_cr_Annuler.TabIndex = 9;
            this.btn_cr_Annuler.Text = "Annuler";
            this.btn_cr_Annuler.UseVisualStyleBackColor = false;
            this.btn_cr_Annuler.Click += new System.EventHandler(this.btn_cr_Annuler_Click);
            // 
            // btn_cr_Creer
            // 
            this.btn_cr_Creer.BackColor = System.Drawing.Color.Lime;
            this.btn_cr_Creer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cr_Creer.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_cr_Creer.Location = new System.Drawing.Point(543, 284);
            this.btn_cr_Creer.Name = "btn_cr_Creer";
            this.btn_cr_Creer.Size = new System.Drawing.Size(186, 51);
            this.btn_cr_Creer.TabIndex = 8;
            this.btn_cr_Creer.Text = "Créer";
            this.btn_cr_Creer.UseVisualStyleBackColor = false;
            this.btn_cr_Creer.Click += new System.EventHandler(this.btn_cr_Creer_Click);
            // 
            // txt_cr_SoldeInitial
            // 
            this.txt_cr_SoldeInitial.Location = new System.Drawing.Point(359, 241);
            this.txt_cr_SoldeInitial.Name = "txt_cr_SoldeInitial";
            this.txt_cr_SoldeInitial.Size = new System.Drawing.Size(337, 22);
            this.txt_cr_SoldeInitial.TabIndex = 7;
            // 
            // txt_cr_Titulaire
            // 
            this.txt_cr_Titulaire.Location = new System.Drawing.Point(359, 180);
            this.txt_cr_Titulaire.Name = "txt_cr_Titulaire";
            this.txt_cr_Titulaire.Size = new System.Drawing.Size(337, 22);
            this.txt_cr_Titulaire.TabIndex = 6;
            // 
            // txt_cr_Numero
            // 
            this.txt_cr_Numero.Location = new System.Drawing.Point(359, 127);
            this.txt_cr_Numero.Name = "txt_cr_Numero";
            this.txt_cr_Numero.Size = new System.Drawing.Size(337, 22);
            this.txt_cr_Numero.TabIndex = 5;
            // 
            // lbl_cr_Message
            // 
            this.lbl_cr_Message.AutoSize = true;
            this.lbl_cr_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_Message.ForeColor = System.Drawing.Color.Red;
            this.lbl_cr_Message.Location = new System.Drawing.Point(118, 327);
            this.lbl_cr_Message.Name = "lbl_cr_Message";
            this.lbl_cr_Message.Size = new System.Drawing.Size(325, 24);
            this.lbl_cr_Message.TabIndex = 4;
            this.lbl_cr_Message.Text = "Valeur incorrecte pour le solde initial !";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(23, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Solde initial du compte";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(23, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Titulaire du compte";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(23, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Numero de compte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(148, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(515, 46);
            this.label7.TabIndex = 0;
            this.label7.Text = "CREATION D\'UN COMPTE";
            // 
            // tabVersement
            // 
            this.tabVersement.Controls.Add(this.btn_ve_Annuler);
            this.tabVersement.Controls.Add(this.btn_ve_Enregistrer);
            this.tabVersement.Controls.Add(this.label14);
            this.tabVersement.Controls.Add(this.txt_ve_Montant_A_Crediter);
            this.tabVersement.Controls.Add(this.cbo_ve_ChoixCompte);
            this.tabVersement.Controls.Add(this.lbl_ve_Message);
            this.tabVersement.Controls.Add(this.label13);
            this.tabVersement.Controls.Add(this.label12);
            this.tabVersement.Controls.Add(this.label11);
            this.tabVersement.Location = new System.Drawing.Point(4, 25);
            this.tabVersement.Name = "tabVersement";
            this.tabVersement.Size = new System.Drawing.Size(792, 421);
            this.tabVersement.TabIndex = 3;
            this.tabVersement.Text = "Versement";
            this.tabVersement.UseVisualStyleBackColor = true;
            this.tabVersement.Enter += new System.EventHandler(this.tabAcceuil_Enter);
            // 
            // btn_ve_Annuler
            // 
            this.btn_ve_Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_ve_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ve_Annuler.Location = new System.Drawing.Point(641, 287);
            this.btn_ve_Annuler.Name = "btn_ve_Annuler";
            this.btn_ve_Annuler.Size = new System.Drawing.Size(123, 51);
            this.btn_ve_Annuler.TabIndex = 8;
            this.btn_ve_Annuler.Text = "Annuler";
            this.btn_ve_Annuler.UseVisualStyleBackColor = false;
            // 
            // btn_ve_Enregistrer
            // 
            this.btn_ve_Enregistrer.BackColor = System.Drawing.Color.Lime;
            this.btn_ve_Enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ve_Enregistrer.ForeColor = System.Drawing.Color.Black;
            this.btn_ve_Enregistrer.Location = new System.Drawing.Point(641, 199);
            this.btn_ve_Enregistrer.Name = "btn_ve_Enregistrer";
            this.btn_ve_Enregistrer.Size = new System.Drawing.Size(123, 57);
            this.btn_ve_Enregistrer.TabIndex = 7;
            this.btn_ve_Enregistrer.Text = "Enregistrer";
            this.btn_ve_Enregistrer.UseVisualStyleBackColor = false;
            this.btn_ve_Enregistrer.Click += new System.EventHandler(this.btn_ve_Enregistrer_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(553, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "C#";
            // 
            // txt_ve_Montant_A_Crediter
            // 
            this.txt_ve_Montant_A_Crediter.Location = new System.Drawing.Point(367, 222);
            this.txt_ve_Montant_A_Crediter.Name = "txt_ve_Montant_A_Crediter";
            this.txt_ve_Montant_A_Crediter.Size = new System.Drawing.Size(168, 22);
            this.txt_ve_Montant_A_Crediter.TabIndex = 5;
            // 
            // cbo_ve_ChoixCompte
            // 
            this.cbo_ve_ChoixCompte.FormattingEnabled = true;
            this.cbo_ve_ChoixCompte.Location = new System.Drawing.Point(367, 121);
            this.cbo_ve_ChoixCompte.Name = "cbo_ve_ChoixCompte";
            this.cbo_ve_ChoixCompte.Size = new System.Drawing.Size(377, 24);
            this.cbo_ve_ChoixCompte.TabIndex = 4;
            this.cbo_ve_ChoixCompte.SelectedIndexChanged += new System.EventHandler(this.cbo_ve_ChoixCompte_SelectedIndexChanged);
            this.cbo_ve_ChoixCompte.EnabledChanged += new System.EventHandler(this.tabAcceuil_Enter);
            this.cbo_ve_ChoixCompte.Enter += new System.EventHandler(this.tabAcceuil_Enter);
            // 
            // lbl_ve_Message
            // 
            this.lbl_ve_Message.AutoSize = true;
            this.lbl_ve_Message.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ve_Message.ForeColor = System.Drawing.Color.Red;
            this.lbl_ve_Message.Location = new System.Drawing.Point(37, 307);
            this.lbl_ve_Message.Name = "lbl_ve_Message";
            this.lbl_ve_Message.Size = new System.Drawing.Size(408, 44);
            this.lbl_ve_Message.TabIndex = 3;
            this.lbl_ve_Message.Text = "Le virement n\'a pas pu être effectué car\r\n vous n\'avez pas selectionner le compte" +
    " a crediter !";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(32, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Montant à créditer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(32, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(254, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Choisir un compte à créditer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(24, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(740, 46);
            this.label11.TabIndex = 0;
            this.label11.Text = "ENREGISTREMENT d\'un VERSEMENT";
            // 
            // tabRetrait
            // 
            this.tabRetrait.Location = new System.Drawing.Point(4, 25);
            this.tabRetrait.Name = "tabRetrait";
            this.tabRetrait.Size = new System.Drawing.Size(792, 421);
            this.tabRetrait.TabIndex = 4;
            this.tabRetrait.Text = "Retrait";
            this.tabRetrait.UseVisualStyleBackColor = true;
            // 
            // tabVirement
            // 
            this.tabVirement.Location = new System.Drawing.Point(4, 25);
            this.tabVirement.Name = "tabVirement";
            this.tabVirement.Size = new System.Drawing.Size(792, 421);
            this.tabVirement.TabIndex = 5;
            this.tabVirement.Text = "Virement";
            this.tabVirement.UseVisualStyleBackColor = true;
            // 
            // FrmBanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_OngletsApplications);
            this.Name = "FrmBanque";
            this.Text = "Form1";
            this.tab_OngletsApplications.ResumeLayout(false);
            this.tabAcceuil.ResumeLayout(false);
            this.tabAcceuil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeComptes)).EndInit();
            this.tabConsultation.ResumeLayout(false);
            this.tabConsultation.PerformLayout();
            this.tabCreation.ResumeLayout(false);
            this.tabCreation.PerformLayout();
            this.tabVersement.ResumeLayout(false);
            this.tabVersement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_OngletsApplications;
        private System.Windows.Forms.TabPage tabAcceuil;
        private System.Windows.Forms.TabPage tabConsultation;
        private System.Windows.Forms.TabPage tabCreation;
        private System.Windows.Forms.TabPage tabVersement;
        private System.Windows.Forms.TabPage tabRetrait;
        private System.Windows.Forms.TabPage tabVirement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ac_Titre;
        private System.Windows.Forms.DataGridView dgv_ListeComptes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_co_SoldeActuel;
        private System.Windows.Forms.TextBox txt_co_Titulaire;
        private System.Windows.Forms.TextBox txt_co_Numero;
        private System.Windows.Forms.ComboBox cbo_co_ChoixCompte;
        private System.Windows.Forms.Button btn_cr_Annuler;
        private System.Windows.Forms.Button btn_cr_Creer;
        private System.Windows.Forms.TextBox txt_cr_SoldeInitial;
        private System.Windows.Forms.TextBox txt_cr_Titulaire;
        private System.Windows.Forms.TextBox txt_cr_Numero;
        private System.Windows.Forms.Label lbl_cr_Message;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_ve_ChoixCompte;
        private System.Windows.Forms.Label lbl_ve_Message;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_ve_Annuler;
        private System.Windows.Forms.Button btn_ve_Enregistrer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_ve_Montant_A_Crediter;
    }
}

