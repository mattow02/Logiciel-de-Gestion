namespace nouvelleMission
{
    partial class UCnouvelleMission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCnouvelleMission));
            this.lblMission = new System.Windows.Forms.Label();
            this.lblDeclenchéLe = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.cboNature = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConstituer = new System.Windows.Forms.Button();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblGestion = new System.Windows.Forms.Label();
            this.picCloche = new System.Windows.Forms.PictureBox();
            this.lblDecision = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCloche)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMission.ForeColor = System.Drawing.Color.Black;
            this.lblMission.Location = new System.Drawing.Point(76, 48);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(104, 25);
            this.lblMission.TabIndex = 0;
            this.lblMission.Text = "Mission n°";
            this.lblMission.Click += new System.EventHandler(this.lblMission_Click);
            // 
            // lblDeclenchéLe
            // 
            this.lblDeclenchéLe.AutoSize = true;
            this.lblDeclenchéLe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDeclenchéLe.ForeColor = System.Drawing.Color.Black;
            this.lblDeclenchéLe.Location = new System.Drawing.Point(186, 48);
            this.lblDeclenchéLe.Name = "lblDeclenchéLe";
            this.lblDeclenchéLe.Size = new System.Drawing.Size(155, 25);
            this.lblDeclenchéLe.TabIndex = 2;
            this.lblDeclenchéLe.Text = "- Déclenchée le :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(339, 48);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(170, 25);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "2025-12-05 16:00";
            // 
            // txtVille
            // 
            this.txtVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVille.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtVille.Location = new System.Drawing.Point(728, 156);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(200, 33);
            this.txtVille.TabIndex = 10;
            this.txtVille.TextChanged += new System.EventHandler(this.txtVille_TextChanged);
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodePostal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtCodePostal.Location = new System.Drawing.Point(282, 156);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(321, 33);
            this.txtCodePostal.TabIndex = 9;
            // 
            // txtRue
            // 
            this.txtRue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtRue.Location = new System.Drawing.Point(282, 110);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(646, 33);
            this.txtRue.TabIndex = 8;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblVille.ForeColor = System.Drawing.Color.Black;
            this.lblVille.Location = new System.Drawing.Point(227, 158);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(49, 25);
            this.lblVille.TabIndex = 6;
            this.lblVille.Text = "Ville";
            this.lblVille.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCodePostal.ForeColor = System.Drawing.Color.Black;
            this.lblCodePostal.Location = new System.Drawing.Point(609, 158);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(113, 25);
            this.lblCodePostal.TabIndex = 7;
            this.lblCodePostal.Text = "Code postal";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRue.ForeColor = System.Drawing.Color.Black;
            this.lblRue.Location = new System.Drawing.Point(231, 112);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(45, 25);
            this.lblRue.TabIndex = 7;
            this.lblRue.Text = "Rue";
            // 
            // txtMotif
            // 
            this.txtMotif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotif.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtMotif.Location = new System.Drawing.Point(282, 68);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(646, 33);
            this.txtMotif.TabIndex = 6;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMotif.ForeColor = System.Drawing.Color.Black;
            this.lblMotif.Location = new System.Drawing.Point(216, 70);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(60, 25);
            this.lblMotif.TabIndex = 5;
            this.lblMotif.Text = "Motif";
            // 
            // cboCaserne
            // 
            this.cboCaserne.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(521, 366);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(217, 33);
            this.cboCaserne.TabIndex = 19;
            // 
            // cboNature
            // 
            this.cboNature.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboNature.FormattingEnabled = true;
            this.cboNature.Location = new System.Drawing.Point(203, 366);
            this.cboNature.Name = "cboNature";
            this.cboNature.Size = new System.Drawing.Size(312, 33);
            this.cboNature.TabIndex = 18;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnnuler.Location = new System.Drawing.Point(31, 422);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(179, 37);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConstituer
            // 
            this.btnConstituer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConstituer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConstituer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConstituer.ForeColor = System.Drawing.Color.White;
            this.btnConstituer.Location = new System.Drawing.Point(549, 422);
            this.btnConstituer.Name = "btnConstituer";
            this.btnConstituer.Size = new System.Drawing.Size(189, 37);
            this.btnConstituer.TabIndex = 16;
            this.btnConstituer.Text = "Constituer équipe";
            this.btnConstituer.UseVisualStyleBackColor = false;
            this.btnConstituer.Click += new System.EventHandler(this.btnConstituer_Click);
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNature.ForeColor = System.Drawing.Color.Black;
            this.lblNature.Location = new System.Drawing.Point(26, 369);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(165, 25);
            this.lblNature.TabIndex = 6;
            this.lblNature.Text = "Nature du sinistre";
            this.lblNature.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestion.ForeColor = System.Drawing.Color.Black;
            this.lblGestion.Location = new System.Drawing.Point(76, 18);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(321, 30);
            this.lblGestion.TabIndex = 20;
            this.lblGestion.Text = "Gestion d\'une nouvelle mission";
            // 
            // picCloche
            // 
            this.picCloche.Image = global::nouvelleMission.Properties.Resources.ClocheMission;
            this.picCloche.Location = new System.Drawing.Point(12, 9);
            this.picCloche.Name = "picCloche";
            this.picCloche.Size = new System.Drawing.Size(58, 48);
            this.picCloche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCloche.TabIndex = 21;
            this.picCloche.TabStop = false;
            // 
            // lblDecision
            // 
            this.lblDecision.AutoSize = true;
            this.lblDecision.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecision.Location = new System.Drawing.Point(26, 323);
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.Size = new System.Drawing.Size(223, 25);
            this.lblDecision.TabIndex = 22;
            this.lblDecision.Text = "Décisions du régulateur";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(216, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(193, 25);
            this.lblInfo.TabIndex = 23;
            this.lblInfo.Text = "Informations usager";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVille);
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.lblMotif);
            this.groupBox1.Controls.Add(this.txtMotif);
            this.groupBox1.Controls.Add(this.lblRue);
            this.groupBox1.Controls.Add(this.lblCodePostal);
            this.groupBox1.Controls.Add(this.lblVille);
            this.groupBox1.Controls.Add(this.txtRue);
            this.groupBox1.Controls.Add(this.txtCodePostal);
            this.groupBox1.Location = new System.Drawing.Point(-190, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1456, 218);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(508, -1);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(255, 86);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 25;
            this.pbLogo.TabStop = false;
            // 
            // UCnouvelleMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDecision);
            this.Controls.Add(this.picCloche);
            this.Controls.Add(this.lblGestion);
            this.Controls.Add(this.cboCaserne);
            this.Controls.Add(this.lblMission);
            this.Controls.Add(this.cboNature);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.lblNature);
            this.Controls.Add(this.btnConstituer);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDeclenchéLe);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UCnouvelleMission";
            this.Size = new System.Drawing.Size(762, 483);
            this.Load += new System.EventHandler(this.UCnouvelleMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCloche)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Label lblDeclenchéLe;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConstituer;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.ComboBox cboNature;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.PictureBox picCloche;
        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}
