namespace UCmobilisations
{
    partial class UCmobilisations
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlEngins = new System.Windows.Forms.Panel();
            this.lblEngins = new System.Windows.Forms.Label();
            this.tblEngins = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPompier = new System.Windows.Forms.Panel();
            this.lblPompier = new System.Windows.Forms.Label();
            this.tblPompier = new System.Windows.Forms.TableLayoutPanel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.pnlEngins.SuspendLayout();
            this.pnlPompier.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(18, 18);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(368, 25);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Mobilisation des engins et des pompiers";
            this.lblTitre.Click += new System.EventHandler(this.lblTitre_Click);
            this.lblTitre.MouseLeave += new System.EventHandler(this.lblTitre_MouseLeave);
            this.lblTitre.MouseHover += new System.EventHandler(this.lblTitre_MouseHover);
            this.lblTitre.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitre_MouseUp);
            // 
            // pnlEngins
            // 
            this.pnlEngins.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlEngins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEngins.Controls.Add(this.lblEngins);
            this.pnlEngins.Controls.Add(this.tblEngins);
            this.pnlEngins.Location = new System.Drawing.Point(23, 75);
            this.pnlEngins.Name = "pnlEngins";
            this.pnlEngins.Size = new System.Drawing.Size(307, 347);
            this.pnlEngins.TabIndex = 1;
            // 
            // lblEngins
            // 
            this.lblEngins.AutoSize = true;
            this.lblEngins.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngins.Location = new System.Drawing.Point(76, 0);
            this.lblEngins.Name = "lblEngins";
            this.lblEngins.Size = new System.Drawing.Size(158, 25);
            this.lblEngins.TabIndex = 1;
            this.lblEngins.Text = "Engins mobilisés";
            // 
            // tblEngins
            // 
            this.tblEngins.AutoScroll = true;
            this.tblEngins.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblEngins.ColumnCount = 3;
            this.tblEngins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblEngins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblEngins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblEngins.Location = new System.Drawing.Point(10, 33);
            this.tblEngins.Name = "tblEngins";
            this.tblEngins.RowCount = 1;
            this.tblEngins.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEngins.Size = new System.Drawing.Size(283, 300);
            this.tblEngins.TabIndex = 0;
            // 
            // pnlPompier
            // 
            this.pnlPompier.BackColor = System.Drawing.Color.White;
            this.pnlPompier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPompier.Controls.Add(this.lblPompier);
            this.pnlPompier.Controls.Add(this.tblPompier);
            this.pnlPompier.Location = new System.Drawing.Point(356, 76);
            this.pnlPompier.Name = "pnlPompier";
            this.pnlPompier.Size = new System.Drawing.Size(307, 347);
            this.pnlPompier.TabIndex = 2;
            // 
            // lblPompier
            // 
            this.lblPompier.AutoSize = true;
            this.lblPompier.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPompier.Location = new System.Drawing.Point(64, -1);
            this.lblPompier.Name = "lblPompier";
            this.lblPompier.Size = new System.Drawing.Size(182, 25);
            this.lblPompier.TabIndex = 2;
            this.lblPompier.Text = "Pompiers mobilisés";
            // 
            // tblPompier
            // 
            this.tblPompier.AutoScroll = true;
            this.tblPompier.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblPompier.ColumnCount = 3;
            this.tblPompier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPompier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPompier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPompier.Location = new System.Drawing.Point(11, 33);
            this.tblPompier.Name = "tblPompier";
            this.tblPompier.RowCount = 1;
            this.tblPompier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPompier.Size = new System.Drawing.Size(281, 300);
            this.tblPompier.TabIndex = 1;
            // 
            // btnFermer
            // 
            this.btnFermer.AutoSize = true;
            this.btnFermer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFermer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.Transparent;
            this.btnFermer.Location = new System.Drawing.Point(553, 447);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(133, 35);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // UCmobilisations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.pnlPompier);
            this.Controls.Add(this.pnlEngins);
            this.Controls.Add(this.lblTitre);
            this.Name = "UCmobilisations";
            this.Size = new System.Drawing.Size(689, 485);
            this.Load += new System.EventHandler(this.UCmobilisations_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UCmobilisations_MouseUp);
            this.pnlEngins.ResumeLayout(false);
            this.pnlEngins.PerformLayout();
            this.pnlPompier.ResumeLayout(false);
            this.pnlPompier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlEngins;
        private System.Windows.Forms.Panel pnlPompier;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.TableLayoutPanel tblEngins;
        private System.Windows.Forms.TableLayoutPanel tblPompier;
        private System.Windows.Forms.Label lblEngins;
        private System.Windows.Forms.Label lblPompier;
    }
}
