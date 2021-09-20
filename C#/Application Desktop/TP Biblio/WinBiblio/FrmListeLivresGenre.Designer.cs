namespace WinBiblio
{
    partial class FrmListeLivresGenre
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboListeGenre = new System.Windows.Forms.ComboBox();
            this.dgvListeLivresGenre = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeLivresGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(216, 24);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(269, 38);
            this.lbl_titre.TabIndex = 1;
            this.lbl_titre.Text = "Livres par genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Genre :";
            // 
            // cboListeGenre
            // 
            this.cboListeGenre.FormattingEnabled = true;
            this.cboListeGenre.Location = new System.Drawing.Point(289, 123);
            this.cboListeGenre.Name = "cboListeGenre";
            this.cboListeGenre.Size = new System.Drawing.Size(213, 24);
            this.cboListeGenre.TabIndex = 3;
            this.cboListeGenre.SelectedIndexChanged += new System.EventHandler(this.cboListeGenre_SelectedIndexChanged);
            // 
            // dgvListeLivresGenre
            // 
            this.dgvListeLivresGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListeLivresGenre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListeLivresGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeLivresGenre.Location = new System.Drawing.Point(27, 189);
            this.dgvListeLivresGenre.Name = "dgvListeLivresGenre";
            this.dgvListeLivresGenre.RowHeadersWidth = 51;
            this.dgvListeLivresGenre.RowTemplate.Height = 24;
            this.dgvListeLivresGenre.Size = new System.Drawing.Size(660, 282);
            this.dgvListeLivresGenre.TabIndex = 4;
            // 
            // FrmListeLivresGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(710, 506);
            this.Controls.Add(this.dgvListeLivresGenre);
            this.Controls.Add(this.cboListeGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_titre);
            this.Name = "FrmListeLivresGenre";
            this.Text = "FrmListeLivresGenre";
            this.Load += new System.EventHandler(this.FrmListeLivresGenre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeLivresGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboListeGenre;
        private System.Windows.Forms.DataGridView dgvListeLivresGenre;
    }
}