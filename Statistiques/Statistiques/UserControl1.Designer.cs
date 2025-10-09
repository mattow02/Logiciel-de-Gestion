namespace Statistiques
{
    partial class UCStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCStats));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblStat = new System.Windows.Forms.Label();
            this.pnlCaserne = new System.Windows.Forms.Panel();
            this.pbStat = new System.Windows.Forms.PictureBox();
            this.pnlToutesLesC = new System.Windows.Forms.Panel();
            this.rdbPompierHabil = new System.Windows.Forms.RadioButton();
            this.rdbHabilitations = new System.Windows.Forms.RadioButton();
            this.rdbNbIntervention = new System.Windows.Forms.RadioButton();
            this.lblTC = new System.Windows.Forms.Label();
            this.pnl1Caserne = new System.Windows.Forms.Panel();
            this.rdbCumul = new System.Windows.Forms.RadioButton();
            this.rdbEnginUtil = new System.Windows.Forms.RadioButton();
            this.lblNomCaserne = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblChoix = new System.Windows.Forms.Label();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblChoixStats = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlCaserne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStat)).BeginInit();
            this.pnlToutesLesC.SuspendLayout();
            this.pnl1Caserne.SuspendLayout();
            this.pnlStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(745, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(255, 105);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat.Location = new System.Drawing.Point(70, 36);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(146, 32);
            this.lblStat.TabIndex = 1;
            this.lblStat.Text = "Statistiques";
            // 
            // pnlCaserne
            // 
            this.pnlCaserne.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCaserne.Controls.Add(this.pbStat);
            this.pnlCaserne.Controls.Add(this.pnlToutesLesC);
            this.pnlCaserne.Controls.Add(this.pnl1Caserne);
            this.pnlCaserne.Controls.Add(this.lblCaserne);
            this.pnlCaserne.Controls.Add(this.lblChoix);
            this.pnlCaserne.Controls.Add(this.cboCaserne);
            this.pnlCaserne.Location = new System.Drawing.Point(3, 129);
            this.pnlCaserne.Name = "pnlCaserne";
            this.pnlCaserne.Size = new System.Drawing.Size(292, 506);
            this.pnlCaserne.TabIndex = 2;
            // 
            // pbStat
            // 
            this.pbStat.Image = global::Statistiques.Properties.Resources.stats_removebg_preview;
            this.pbStat.Location = new System.Drawing.Point(0, 328);
            this.pbStat.Name = "pbStat";
            this.pbStat.Size = new System.Drawing.Size(291, 177);
            this.pbStat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStat.TabIndex = 5;
            this.pbStat.TabStop = false;
            this.pbStat.Click += new System.EventHandler(this.pbStat_Click);
            // 
            // pnlToutesLesC
            // 
            this.pnlToutesLesC.BackColor = System.Drawing.Color.DarkGray;
            this.pnlToutesLesC.Controls.Add(this.rdbPompierHabil);
            this.pnlToutesLesC.Controls.Add(this.rdbHabilitations);
            this.pnlToutesLesC.Controls.Add(this.rdbNbIntervention);
            this.pnlToutesLesC.Controls.Add(this.lblTC);
            this.pnlToutesLesC.Location = new System.Drawing.Point(12, 131);
            this.pnlToutesLesC.Name = "pnlToutesLesC";
            this.pnlToutesLesC.Size = new System.Drawing.Size(257, 191);
            this.pnlToutesLesC.TabIndex = 4;
            this.pnlToutesLesC.Visible = false;
            // 
            // rdbPompierHabil
            // 
            this.rdbPompierHabil.AutoSize = true;
            this.rdbPompierHabil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPompierHabil.Location = new System.Drawing.Point(7, 142);
            this.rdbPompierHabil.Name = "rdbPompierHabil";
            this.rdbPompierHabil.Size = new System.Drawing.Size(14, 13);
            this.rdbPompierHabil.TabIndex = 3;
            this.rdbPompierHabil.TabStop = true;
            this.rdbPompierHabil.UseVisualStyleBackColor = true;
            this.rdbPompierHabil.CheckedChanged += new System.EventHandler(this.rdbPompierHabil_CheckedChanged);
            // 
            // rdbHabilitations
            // 
            this.rdbHabilitations.AutoSize = true;
            this.rdbHabilitations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHabilitations.Location = new System.Drawing.Point(7, 92);
            this.rdbHabilitations.Name = "rdbHabilitations";
            this.rdbHabilitations.Size = new System.Drawing.Size(242, 25);
            this.rdbHabilitations.TabIndex = 4;
            this.rdbHabilitations.TabStop = true;
            this.rdbHabilitations.Text = "Habilitations les plus sollicitées";
            this.rdbHabilitations.UseVisualStyleBackColor = true;
            this.rdbHabilitations.CheckedChanged += new System.EventHandler(this.rdbHabilitations_CheckedChanged);
            // 
            // rdbNbIntervention
            // 
            this.rdbNbIntervention.AllowDrop = true;
            this.rdbNbIntervention.AutoSize = true;
            this.rdbNbIntervention.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNbIntervention.Location = new System.Drawing.Point(7, 42);
            this.rdbNbIntervention.Name = "rdbNbIntervention";
            this.rdbNbIntervention.Size = new System.Drawing.Size(14, 13);
            this.rdbNbIntervention.TabIndex = 5;
            this.rdbNbIntervention.TabStop = true;
            this.rdbNbIntervention.UseVisualStyleBackColor = true;
            this.rdbNbIntervention.CheckedChanged += new System.EventHandler(this.rdbNbIntervention_CheckedChanged);
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTC.Location = new System.Drawing.Point(3, 0);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(148, 21);
            this.lblTC.TabIndex = 3;
            this.lblTC.Text = "Toutes les casernes :";
            // 
            // pnl1Caserne
            // 
            this.pnl1Caserne.BackColor = System.Drawing.Color.DarkGray;
            this.pnl1Caserne.Controls.Add(this.rdbCumul);
            this.pnl1Caserne.Controls.Add(this.rdbEnginUtil);
            this.pnl1Caserne.Controls.Add(this.lblNomCaserne);
            this.pnl1Caserne.Location = new System.Drawing.Point(18, 151);
            this.pnl1Caserne.Name = "pnl1Caserne";
            this.pnl1Caserne.Size = new System.Drawing.Size(257, 114);
            this.pnl1Caserne.TabIndex = 3;
            this.pnl1Caserne.Visible = false;
            // 
            // rdbCumul
            // 
            this.rdbCumul.AutoSize = true;
            this.rdbCumul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCumul.Location = new System.Drawing.Point(7, 62);
            this.rdbCumul.Name = "rdbCumul";
            this.rdbCumul.Size = new System.Drawing.Size(237, 25);
            this.rdbCumul.TabIndex = 2;
            this.rdbCumul.TabStop = true;
            this.rdbCumul.Text = "Cumul d\'utilisation des engins";
            this.rdbCumul.UseVisualStyleBackColor = true;
            this.rdbCumul.CheckedChanged += new System.EventHandler(this.rdbCumul_CheckedChanged);
            // 
            // rdbEnginUtil
            // 
            this.rdbEnginUtil.AutoSize = true;
            this.rdbEnginUtil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEnginUtil.Location = new System.Drawing.Point(7, 32);
            this.rdbEnginUtil.Name = "rdbEnginUtil";
            this.rdbEnginUtil.Size = new System.Drawing.Size(182, 25);
            this.rdbEnginUtil.TabIndex = 1;
            this.rdbEnginUtil.TabStop = true;
            this.rdbEnginUtil.Text = "Engins les plus utilisés";
            this.rdbEnginUtil.UseVisualStyleBackColor = true;
            this.rdbEnginUtil.CheckedChanged += new System.EventHandler(this.rdbEnginUtil_CheckedChanged);
            // 
            // lblNomCaserne
            // 
            this.lblNomCaserne.AutoSize = true;
            this.lblNomCaserne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCaserne.Location = new System.Drawing.Point(3, 0);
            this.lblNomCaserne.Name = "lblNomCaserne";
            this.lblNomCaserne.Size = new System.Drawing.Size(0, 21);
            this.lblNomCaserne.TabIndex = 0;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.Location = new System.Drawing.Point(13, 18);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(187, 25);
            this.lblCaserne.TabIndex = 2;
            this.lblCaserne.Text = "Choix de la caserne :";
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoix.Location = new System.Drawing.Point(0, 80);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(89, 25);
            this.lblChoix.TabIndex = 1;
            this.lblChoix.Text = "Caserne :";
            // 
            // cboCaserne
            // 
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(105, 80);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(184, 27);
            this.cboCaserne.TabIndex = 0;
            this.cboCaserne.SelectedIndexChanged += new System.EventHandler(this.cboCaserne_SelectedIndexChanged);
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlStats.Controls.Add(this.lblChoixStats);
            this.pnlStats.Controls.Add(this.dataGridView1);
            this.pnlStats.Location = new System.Drawing.Point(301, 129);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(696, 505);
            this.pnlStats.TabIndex = 3;
            // 
            // lblChoixStats
            // 
            this.lblChoixStats.AutoSize = true;
            this.lblChoixStats.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixStats.Location = new System.Drawing.Point(18, 17);
            this.lblChoixStats.Name = "lblChoixStats";
            this.lblChoixStats.Size = new System.Drawing.Size(318, 25);
            this.lblChoixStats.TabIndex = 1;
            this.lblChoixStats.Text = "Statistiques que vous avez choisies :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(694, 455);
            this.dataGridView1.TabIndex = 0;
            // 
            // UCStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlCaserne);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "UCStats";
            this.Size = new System.Drawing.Size(1000, 649);
            this.Load += new System.EventHandler(this.UCStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlCaserne.ResumeLayout(false);
            this.pnlCaserne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStat)).EndInit();
            this.pnlToutesLesC.ResumeLayout(false);
            this.pnlToutesLesC.PerformLayout();
            this.pnl1Caserne.ResumeLayout(false);
            this.pnl1Caserne.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Panel pnlCaserne;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblChoix;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlToutesLesC;
        private System.Windows.Forms.Panel pnl1Caserne;
        private System.Windows.Forms.Label lblChoixStats;
        private System.Windows.Forms.RadioButton rdbCumul;
        private System.Windows.Forms.RadioButton rdbEnginUtil;
        private System.Windows.Forms.Label lblNomCaserne;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.RadioButton rdbPompierHabil;
        private System.Windows.Forms.RadioButton rdbHabilitations;
        private System.Windows.Forms.RadioButton rdbNbIntervention;
        private System.Windows.Forms.PictureBox pbStat;
    }
}
