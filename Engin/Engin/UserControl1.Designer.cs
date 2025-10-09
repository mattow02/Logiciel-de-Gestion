namespace Engin
{
    partial class Engin
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Engin));
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.btnPrem = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnApres = new System.Windows.Forms.Button();
            this.btnAvant = new System.Windows.Forms.Button();
            this.pnlCaserne = new System.Windows.Forms.Panel();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPanne = new System.Windows.Forms.Label();
            this.chkPanne = new System.Windows.Forms.CheckBox();
            this.chkMission = new System.Windows.Forms.CheckBox();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.pnlEngins = new System.Windows.Forms.Panel();
            this.lblStatut = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlCaserne.SuspendLayout();
            this.pnlEngins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCaserne
            // 
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(118, 0);
            this.cboCaserne.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(691, 33);
            this.cboCaserne.TabIndex = 1;
            this.cboCaserne.SelectedIndexChanged += new System.EventHandler(this.cboCaserne_SelectedIndexChanged);
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.ForeColor = System.Drawing.Color.Black;
            this.lblCaserne.Location = new System.Drawing.Point(7, 2);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(109, 31);
            this.lblCaserne.TabIndex = 0;
            this.lblCaserne.Text = "Caserne :";
            // 
            // btnPrem
            // 
            this.btnPrem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrem.Location = new System.Drawing.Point(355, 576);
            this.btnPrem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPrem.Name = "btnPrem";
            this.btnPrem.Size = new System.Drawing.Size(56, 52);
            this.btnPrem.TabIndex = 2;
            this.btnPrem.UseVisualStyleBackColor = false;
            this.btnPrem.Click += new System.EventHandler(this.btnPrem_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDernier.Location = new System.Drawing.Point(538, 576);
            this.btnDernier.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(56, 52);
            this.btnDernier.TabIndex = 3;
            this.btnDernier.UseVisualStyleBackColor = false;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnApres
            // 
            this.btnApres.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApres.Location = new System.Drawing.Point(477, 576);
            this.btnApres.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnApres.Name = "btnApres";
            this.btnApres.Size = new System.Drawing.Size(56, 52);
            this.btnApres.TabIndex = 4;
            this.btnApres.UseVisualStyleBackColor = false;
            this.btnApres.Click += new System.EventHandler(this.btnApres_Click);
            // 
            // btnAvant
            // 
            this.btnAvant.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAvant.Location = new System.Drawing.Point(416, 576);
            this.btnAvant.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAvant.Name = "btnAvant";
            this.btnAvant.Size = new System.Drawing.Size(56, 52);
            this.btnAvant.TabIndex = 5;
            this.btnAvant.UseVisualStyleBackColor = false;
            this.btnAvant.Click += new System.EventHandler(this.btnAvant_Click);
            // 
            // pnlCaserne
            // 
            this.pnlCaserne.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCaserne.Controls.Add(this.lblCaserne);
            this.pnlCaserne.Controls.Add(this.cboCaserne);
            this.pnlCaserne.ForeColor = System.Drawing.Color.IndianRed;
            this.pnlCaserne.Location = new System.Drawing.Point(76, 113);
            this.pnlCaserne.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlCaserne.Name = "pnlCaserne";
            this.pnlCaserne.Size = new System.Drawing.Size(809, 35);
            this.pnlCaserne.TabIndex = 6;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(8, 42);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(108, 31);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Numéro :";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNum2.Location = new System.Drawing.Point(122, 47);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(0, 31);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.TextChanged += new System.EventHandler(this.lblNum2_TextChanged);
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMission.Location = new System.Drawing.Point(21, 258);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(123, 31);
            this.lblMission.TabIndex = 2;
            this.lblMission.Text = "En mission";
            this.lblMission.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(8, 99);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(208, 31);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date de réception :";
            // 
            // lblPanne
            // 
            this.lblPanne.AutoSize = true;
            this.lblPanne.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanne.Location = new System.Drawing.Point(21, 258);
            this.lblPanne.Name = "lblPanne";
            this.lblPanne.Size = new System.Drawing.Size(109, 31);
            this.lblPanne.TabIndex = 4;
            this.lblPanne.Text = "En panne";
            this.lblPanne.Visible = false;
            // 
            // chkPanne
            // 
            this.chkPanne.AutoCheck = false;
            this.chkPanne.AutoSize = true;
            this.chkPanne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkPanne.Location = new System.Drawing.Point(792, 0);
            this.chkPanne.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkPanne.Name = "chkPanne";
            this.chkPanne.Size = new System.Drawing.Size(18, 17);
            this.chkPanne.TabIndex = 5;
            this.chkPanne.UseVisualStyleBackColor = true;
            this.chkPanne.CheckedChanged += new System.EventHandler(this.chkPanne_CheckedChanged);
            // 
            // chkMission
            // 
            this.chkMission.AutoCheck = false;
            this.chkMission.AutoSize = true;
            this.chkMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkMission.Location = new System.Drawing.Point(891, 88);
            this.chkMission.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkMission.Name = "chkMission";
            this.chkMission.Size = new System.Drawing.Size(18, 17);
            this.chkMission.TabIndex = 6;
            this.chkMission.UseVisualStyleBackColor = true;
            this.chkMission.CheckedChanged += new System.EventHandler(this.chkMission_CheckedChanged);
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDate2.Location = new System.Drawing.Point(222, 99);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(0, 31);
            this.lblDate2.TabIndex = 7;
            // 
            // pnlEngins
            // 
            this.pnlEngins.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlEngins.Controls.Add(this.lblStatut);
            this.pnlEngins.Controls.Add(this.pb1);
            this.pnlEngins.Controls.Add(this.lblNum);
            this.pnlEngins.Controls.Add(this.lblDate2);
            this.pnlEngins.Controls.Add(this.lblNum2);
            this.pnlEngins.Controls.Add(this.lblMission);
            this.pnlEngins.Controls.Add(this.lblDate);
            this.pnlEngins.Controls.Add(this.lblPanne);
            this.pnlEngins.Location = new System.Drawing.Point(76, 158);
            this.pnlEngins.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlEngins.Name = "pnlEngins";
            this.pnlEngins.Size = new System.Drawing.Size(809, 408);
            this.pnlEngins.TabIndex = 9;
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatut.Location = new System.Drawing.Point(8, 213);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(204, 31);
            this.lblStatut.TabIndex = 9;
            this.lblStatut.Text = "Statut de l\'engin :";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(511, 117);
            this.pb1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(201, 150);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 8;
            this.pb1.TabStop = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(70, 36);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(274, 41);
            this.lblTitre.TabIndex = 10;
            this.lblTitre.Text = "Engins enregistrés";
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(745, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(255, 105);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // Engin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pnlEngins);
            this.Controls.Add(this.pnlCaserne);
            this.Controls.Add(this.btnAvant);
            this.Controls.Add(this.btnApres);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnPrem);
            this.Controls.Add(this.chkPanne);
            this.Controls.Add(this.chkMission);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Engin";
            this.Size = new System.Drawing.Size(1000, 649);
            this.Load += new System.EventHandler(this.Engin_Load);
            this.pnlCaserne.ResumeLayout(false);
            this.pnlCaserne.PerformLayout();
            this.pnlEngins.ResumeLayout(false);
            this.pnlEngins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Button btnPrem;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnApres;
        private System.Windows.Forms.Button btnAvant;
        private System.Windows.Forms.Panel pnlCaserne;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPanne;
        private System.Windows.Forms.CheckBox chkPanne;
        private System.Windows.Forms.CheckBox chkMission;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Panel pnlEngins;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblStatut;
    }
}
