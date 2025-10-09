namespace Caubert_Stroher_KlausnitzerSae24
{
    partial class frmSoldatFeu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoldatFeu));
            this.grpbtnVolet = new System.Windows.Forms.GroupBox();
            this.picIndicator = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.btnEngins = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnTDB = new System.Windows.Forms.Button();
            this.pnlUC = new System.Windows.Forms.Panel();
            this.btnMission = new System.Windows.Forms.Button();
            this.timeIndicator = new System.Windows.Forms.Timer(this.components);
            this.grpbtnVolet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbtnVolet
            // 
            this.grpbtnVolet.BackColor = System.Drawing.Color.FloralWhite;
            this.grpbtnVolet.Controls.Add(this.picIndicator);
            this.grpbtnVolet.Controls.Add(this.picLogo);
            this.grpbtnVolet.Controls.Add(this.btnPersonnel);
            this.grpbtnVolet.Controls.Add(this.btnEngins);
            this.grpbtnVolet.Controls.Add(this.btnStats);
            this.grpbtnVolet.Controls.Add(this.btnQuitter);
            this.grpbtnVolet.Controls.Add(this.btnTDB);
            this.grpbtnVolet.Location = new System.Drawing.Point(1, 1);
            this.grpbtnVolet.Name = "grpbtnVolet";
            this.grpbtnVolet.Size = new System.Drawing.Size(218, 512);
            this.grpbtnVolet.TabIndex = 0;
            this.grpbtnVolet.TabStop = false;
            this.grpbtnVolet.Enter += new System.EventHandler(this.grpbtnVolet_Enter);
            // 
            // picIndicator
            // 
            this.picIndicator.Image = global::Caubert_Stroher_KlausnitzerSae24.Properties.Resources.flammeLogo;
            this.picIndicator.Location = new System.Drawing.Point(5, 43);
            this.picIndicator.Name = "picIndicator";
            this.picIndicator.Size = new System.Drawing.Size(38, 37);
            this.picIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIndicator.TabIndex = 7;
            this.picIndicator.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Caubert_Stroher_KlausnitzerSae24.Properties.Resources.logoFireBaseHQ;
            this.picLogo.Location = new System.Drawing.Point(11, 377);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(196, 63);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPersonnel.Location = new System.Drawing.Point(43, 199);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(169, 83);
            this.btnPersonnel.TabIndex = 3;
            this.btnPersonnel.Text = "Gestion du personnel";
            this.btnPersonnel.UseVisualStyleBackColor = true;
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click);
            // 
            // btnEngins
            // 
            this.btnEngins.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEngins.Location = new System.Drawing.Point(43, 110);
            this.btnEngins.Name = "btnEngins";
            this.btnEngins.Size = new System.Drawing.Size(169, 83);
            this.btnEngins.TabIndex = 2;
            this.btnEngins.Text = "Gestion des engins";
            this.btnEngins.UseVisualStyleBackColor = true;
            this.btnEngins.Click += new System.EventHandler(this.btnEngins_Click);
            // 
            // btnStats
            // 
            this.btnStats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnStats.Location = new System.Drawing.Point(43, 288);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(169, 83);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "Statistiques";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(11, 446);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(196, 60);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnTDB
            // 
            this.btnTDB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTDB.Location = new System.Drawing.Point(43, 21);
            this.btnTDB.Name = "btnTDB";
            this.btnTDB.Size = new System.Drawing.Size(169, 83);
            this.btnTDB.TabIndex = 0;
            this.btnTDB.Text = "Tableau de bord";
            this.btnTDB.UseVisualStyleBackColor = true;
            this.btnTDB.Click += new System.EventHandler(this.btnTDB_Click);
            // 
            // pnlUC
            // 
            this.pnlUC.Location = new System.Drawing.Point(225, 1);
            this.pnlUC.Name = "pnlUC";
            this.pnlUC.Size = new System.Drawing.Size(1000, 700);
            this.pnlUC.TabIndex = 3;
            this.pnlUC.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnMission
            // 
            this.btnMission.BackColor = System.Drawing.Color.FloralWhite;
            this.btnMission.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMission.BackgroundImage")));
            this.btnMission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMission.Location = new System.Drawing.Point(1, 519);
            this.btnMission.Name = "btnMission";
            this.btnMission.Size = new System.Drawing.Size(218, 182);
            this.btnMission.TabIndex = 1;
            this.btnMission.UseVisualStyleBackColor = false;
            this.btnMission.Click += new System.EventHandler(this.btnMission_Click);
            // 
            // timeIndicator
            // 
            this.timeIndicator.Interval = 15;
            this.timeIndicator.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSoldatFeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 705);
            this.Controls.Add(this.pnlUC);
            this.Controls.Add(this.grpbtnVolet);
            this.Controls.Add(this.btnMission);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSoldatFeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FireBase HQ";
            this.Load += new System.EventHandler(this.frmSoldatFeu_Load);
            this.grpbtnVolet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbtnVolet;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnPersonnel;
        private System.Windows.Forms.Button btnEngins;
        private System.Windows.Forms.Button btnMission;
        private System.Windows.Forms.Button btnTDB;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel pnlUC;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picIndicator;
        private System.Windows.Forms.Timer timeIndicator;
    }
}

