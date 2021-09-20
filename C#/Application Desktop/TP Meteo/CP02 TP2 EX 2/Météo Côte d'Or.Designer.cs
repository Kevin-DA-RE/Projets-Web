namespace CP02_TP2_EX_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMeteo = new System.Windows.Forms.DataGridView();
            this.cboVille = new System.Windows.Forms.ComboBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblReponse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeteo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMeteo
            // 
            this.dgvMeteo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeteo.Location = new System.Drawing.Point(-27, 64);
            this.dgvMeteo.Name = "dgvMeteo";
            this.dgvMeteo.RowHeadersWidth = 51;
            this.dgvMeteo.Size = new System.Drawing.Size(1328, 218);
            this.dgvMeteo.TabIndex = 0;
            this.dgvMeteo.Text = "dataGridView1";
            this.dgvMeteo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMeteo_CellContentClick);
            // 
            // cboVille
            // 
            this.cboVille.FormattingEnabled = true;
            this.cboVille.Location = new System.Drawing.Point(185, 331);
            this.cboVille.Name = "cboVille";
            this.cboVille.Size = new System.Drawing.Size(151, 28);
            this.cboVille.TabIndex = 1;
            this.cboVille.SelectedIndexChanged += new System.EventHandler(this.cboVille_SelectedIndexChanged);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(51, 329);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(113, 20);
            this.lblVille.TabIndex = 2;
            this.lblVille.Text = "Choisir une ville";
            // 
            // lblReponse
            // 
            this.lblReponse.AutoSize = true;
            this.lblReponse.Location = new System.Drawing.Point(468, 319);
            this.lblReponse.Name = "lblReponse";
            this.lblReponse.Size = new System.Drawing.Size(204, 20);
            this.lblReponse.TabIndex = 3;
            this.lblReponse.Text = "8 jours de pluies dans le mois";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 572);
            this.Controls.Add(this.lblReponse);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.cboVille);
            this.Controls.Add(this.dgvMeteo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeteo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMeteo;
        private System.Windows.Forms.ComboBox cboVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblReponse;
    }
}

