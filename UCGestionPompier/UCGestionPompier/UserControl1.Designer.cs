namespace UCGestionPompier
{
    partial class UCgestionPompier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCgestionPompier));
            this.grpEste = new System.Windows.Forms.GroupBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cboPompier = new System.Windows.Forms.ComboBox();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.lblFiche = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblNumMatricule = new System.Windows.Forms.Label();
            this.picGrade = new System.Windows.Forms.PictureBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNaissance = new System.Windows.Forms.TextBox();
            this.txtDateEmbauche = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtBip = new System.Windows.Forms.TextBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.chklstHabilitations = new System.Windows.Forms.CheckedListBox();
            this.lbHabilitions = new System.Windows.Forms.ListBox();
            this.lblConger = new System.Windows.Forms.Label();
            this.lbAncienneAffectation = new System.Windows.Forms.ListBox();
            this.pnlLog = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnConfirmerModif = new System.Windows.Forms.Button();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.pnlNouveauPompier = new System.Windows.Forms.Panel();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.pnlSexe = new System.Windows.Forms.Panel();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbH = new System.Windows.Forms.RadioButton();
            this.pnlType = new System.Windows.Forms.Panel();
            this.rdbVolontaire = new System.Windows.Forms.RadioButton();
            this.rdbPro = new System.Windows.Forms.RadioButton();
            this.dateNaissance = new System.Windows.Forms.DateTimePicker();
            this.picLogoAjout = new System.Windows.Forms.PictureBox();
            this.txtPrenomAjout = new System.Windows.Forms.TextBox();
            this.cboGradeAjout = new System.Windows.Forms.ComboBox();
            this.grpInfoAjout = new System.Windows.Forms.GroupBox();
            this.chkLsAjout = new System.Windows.Forms.CheckedListBox();
            this.txtTelAjout = new System.Windows.Forms.TextBox();
            this.txtNomAjout = new System.Windows.Forms.TextBox();
            this.picGradeAjout = new System.Windows.Forms.PictureBox();
            this.lblnumMatriculeAjout = new System.Windows.Forms.Label();
            this.lblMatriculeAjout = new System.Windows.Forms.Label();
            this.lblFicheAjout = new System.Windows.Forms.Label();
            this.btnAjouterPompier = new System.Windows.Forms.Button();
            this.lblAffecterA = new System.Windows.Forms.Label();
            this.cboCaserneAjout = new System.Windows.Forms.ComboBox();
            this.btnfermer = new System.Windows.Forms.Button();
            this.grpEste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrade)).BeginInit();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlNouveauPompier.SuspendLayout();
            this.pnlSexe.SuspendLayout();
            this.pnlType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoAjout)).BeginInit();
            this.grpInfoAjout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGradeAjout)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEste
            // 
            this.grpEste.Controls.Add(this.btnModif);
            this.grpEste.Controls.Add(this.btnLogin);
            this.grpEste.Controls.Add(this.cboPompier);
            this.grpEste.Controls.Add(this.cboCaserne);
            this.grpEste.Location = new System.Drawing.Point(-32, -19);
            this.grpEste.Name = "grpEste";
            this.grpEste.Size = new System.Drawing.Size(1140, 95);
            this.grpEste.TabIndex = 0;
            this.grpEste.TabStop = false;
            this.grpEste.Text = "groupBox1";
            // 
            // btnModif
            // 
            this.btnModif.AutoSize = true;
            this.btnModif.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModif.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnModif.ForeColor = System.Drawing.Color.White;
            this.btnModif.Location = new System.Drawing.Point(760, 39);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(198, 31);
            this.btnModif.TabIndex = 3;
            this.btnModif.Text = "Ajouter pompier";
            this.btnModif.UseVisualStyleBackColor = false;
            this.btnModif.Visible = false;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(760, 39);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(198, 31);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Connexion Admin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboPompier
            // 
            this.cboPompier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPompier.FormattingEnabled = true;
            this.cboPompier.Location = new System.Drawing.Point(429, 41);
            this.cboPompier.Name = "cboPompier";
            this.cboPompier.Size = new System.Drawing.Size(280, 29);
            this.cboPompier.TabIndex = 1;
            this.cboPompier.SelectedIndexChanged += new System.EventHandler(this.cboPompier_SelectedIndexChanged);
            this.cboPompier.SelectionChangeCommitted += new System.EventHandler(this.cboPompier_SelectionChangeCommitted);
            this.cboPompier.SelectedValueChanged += new System.EventHandler(this.cboPompier_SelectedValueChanged);
            // 
            // cboCaserne
            // 
            this.cboCaserne.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(94, 41);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(280, 29);
            this.cboCaserne.TabIndex = 0;
            this.cboCaserne.SelectedIndexChanged += new System.EventHandler(this.cboCaserne_SelectedIndexChanged);
            this.cboCaserne.SelectionChangeCommitted += new System.EventHandler(this.cboCaserne_SelectionChangeCommitted);
            // 
            // lblFiche
            // 
            this.lblFiche.AutoSize = true;
            this.lblFiche.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiche.Location = new System.Drawing.Point(85, 103);
            this.lblFiche.Name = "lblFiche";
            this.lblFiche.Size = new System.Drawing.Size(153, 30);
            this.lblFiche.TabIndex = 1;
            this.lblFiche.Text = "Fiche pompier";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.Location = new System.Drawing.Point(85, 147);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(104, 25);
            this.lblMatricule.TabIndex = 2;
            this.lblMatricule.Text = "Matricule :";
            this.lblMatricule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumMatricule
            // 
            this.lblNumMatricule.AutoSize = true;
            this.lblNumMatricule.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMatricule.Location = new System.Drawing.Point(183, 147);
            this.lblNumMatricule.Name = "lblNumMatricule";
            this.lblNumMatricule.Size = new System.Drawing.Size(53, 25);
            this.lblNumMatricule.TabIndex = 3;
            this.lblNumMatricule.Text = "3108";
            this.lblNumMatricule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picGrade
            // 
            this.picGrade.Location = new System.Drawing.Point(90, 175);
            this.picGrade.Name = "picGrade";
            this.picGrade.Size = new System.Drawing.Size(146, 146);
            this.picGrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGrade.TabIndex = 4;
            this.picGrade.TabStop = false;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNom.Location = new System.Drawing.Point(285, 175);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(288, 33);
            this.txtNom.TabIndex = 5;
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPrenom.Location = new System.Drawing.Point(625, 175);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(288, 33);
            this.txtPrenom.TabIndex = 6;
            this.txtPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNaissance
            // 
            this.txtNaissance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNaissance.Location = new System.Drawing.Point(285, 231);
            this.txtNaissance.Name = "txtNaissance";
            this.txtNaissance.ReadOnly = true;
            this.txtNaissance.Size = new System.Drawing.Size(288, 33);
            this.txtNaissance.TabIndex = 7;
            this.txtNaissance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDateEmbauche
            // 
            this.txtDateEmbauche.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDateEmbauche.Location = new System.Drawing.Point(625, 231);
            this.txtDateEmbauche.Name = "txtDateEmbauche";
            this.txtDateEmbauche.ReadOnly = true;
            this.txtDateEmbauche.Size = new System.Drawing.Size(288, 33);
            this.txtDateEmbauche.TabIndex = 8;
            this.txtDateEmbauche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtTel.Location = new System.Drawing.Point(285, 288);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(288, 33);
            this.txtTel.TabIndex = 9;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBip
            // 
            this.txtBip.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtBip.Location = new System.Drawing.Point(625, 288);
            this.txtBip.Name = "txtBip";
            this.txtBip.ReadOnly = true;
            this.txtBip.Size = new System.Drawing.Size(288, 33);
            this.txtBip.TabIndex = 10;
            this.txtBip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.chklstHabilitations);
            this.grpInfo.Controls.Add(this.lbHabilitions);
            this.grpInfo.Controls.Add(this.lblConger);
            this.grpInfo.Controls.Add(this.lbAncienneAffectation);
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.grpInfo.Location = new System.Drawing.Point(285, 347);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(641, 212);
            this.grpInfo.TabIndex = 11;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informations carrière";
            // 
            // chklstHabilitations
            // 
            this.chklstHabilitations.BackColor = System.Drawing.Color.FloralWhite;
            this.chklstHabilitations.CheckOnClick = true;
            this.chklstHabilitations.FormattingEnabled = true;
            this.chklstHabilitations.Location = new System.Drawing.Point(17, 113);
            this.chklstHabilitations.Name = "chklstHabilitations";
            this.chklstHabilitations.Size = new System.Drawing.Size(601, 88);
            this.chklstHabilitations.TabIndex = 3;
            this.chklstHabilitations.Visible = false;
            this.chklstHabilitations.SelectedValueChanged += new System.EventHandler(this.chklstHabilitations_SelectedValueChanged);
            // 
            // lbHabilitions
            // 
            this.lbHabilitions.BackColor = System.Drawing.Color.FloralWhite;
            this.lbHabilitions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHabilitions.FormattingEnabled = true;
            this.lbHabilitions.ItemHeight = 25;
            this.lbHabilitions.Location = new System.Drawing.Point(17, 113);
            this.lbHabilitions.Name = "lbHabilitions";
            this.lbHabilitions.Size = new System.Drawing.Size(601, 77);
            this.lbHabilitions.TabIndex = 2;
            // 
            // lblConger
            // 
            this.lblConger.AutoSize = true;
            this.lblConger.Location = new System.Drawing.Point(438, 45);
            this.lblConger.Name = "lblConger";
            this.lblConger.Size = new System.Drawing.Size(142, 25);
            this.lblConger.TabIndex = 1;
            this.lblConger.Text = "EnCongé/dispo";
            // 
            // lbAncienneAffectation
            // 
            this.lbAncienneAffectation.BackColor = System.Drawing.Color.FloralWhite;
            this.lbAncienneAffectation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAncienneAffectation.FormattingEnabled = true;
            this.lbAncienneAffectation.ItemHeight = 25;
            this.lbAncienneAffectation.Location = new System.Drawing.Point(17, 45);
            this.lbAncienneAffectation.Name = "lbAncienneAffectation";
            this.lbAncienneAffectation.Size = new System.Drawing.Size(318, 50);
            this.lbAncienneAffectation.TabIndex = 0;
            // 
            // pnlLog
            // 
            this.pnlLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLog.Location = new System.Drawing.Point(328, 190);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.Size = new System.Drawing.Size(375, 227);
            this.pnlLog.TabIndex = 12;
            this.pnlLog.Visible = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(717, 103);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(196, 63);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 14;
            this.picLogo.TabStop = false;
            // 
            // btnConfirmerModif
            // 
            this.btnConfirmerModif.AutoSize = true;
            this.btnConfirmerModif.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirmerModif.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmerModif.ForeColor = System.Drawing.Color.White;
            this.btnConfirmerModif.Location = new System.Drawing.Point(728, 588);
            this.btnConfirmerModif.Name = "btnConfirmerModif";
            this.btnConfirmerModif.Size = new System.Drawing.Size(198, 31);
            this.btnConfirmerModif.TabIndex = 4;
            this.btnConfirmerModif.Text = "Confirmer modifications";
            this.btnConfirmerModif.UseVisualStyleBackColor = false;
            this.btnConfirmerModif.Visible = false;
            this.btnConfirmerModif.Click += new System.EventHandler(this.btnConfirmerModif_Click);
            // 
            // cboGrade
            // 
            this.cboGrade.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(90, 366);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(146, 33);
            this.cboGrade.TabIndex = 15;
            this.cboGrade.Visible = false;
            this.cboGrade.SelectionChangeCommitted += new System.EventHandler(this.cboGrade_SelectionChangeCommitted);
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtGrade.Location = new System.Drawing.Point(90, 327);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(146, 33);
            this.txtGrade.TabIndex = 16;
            this.txtGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlNouveauPompier
            // 
            this.pnlNouveauPompier.Controls.Add(this.btnfermer);
            this.pnlNouveauPompier.Controls.Add(this.cboCaserneAjout);
            this.pnlNouveauPompier.Controls.Add(this.lblAffecterA);
            this.pnlNouveauPompier.Controls.Add(this.btnAjouterPompier);
            this.pnlNouveauPompier.Controls.Add(this.lblDateNaissance);
            this.pnlNouveauPompier.Controls.Add(this.lblTel);
            this.pnlNouveauPompier.Controls.Add(this.lblPrenom);
            this.pnlNouveauPompier.Controls.Add(this.lblNom);
            this.pnlNouveauPompier.Controls.Add(this.pnlSexe);
            this.pnlNouveauPompier.Controls.Add(this.pnlType);
            this.pnlNouveauPompier.Controls.Add(this.dateNaissance);
            this.pnlNouveauPompier.Controls.Add(this.picLogoAjout);
            this.pnlNouveauPompier.Controls.Add(this.txtPrenomAjout);
            this.pnlNouveauPompier.Controls.Add(this.cboGradeAjout);
            this.pnlNouveauPompier.Controls.Add(this.grpInfoAjout);
            this.pnlNouveauPompier.Controls.Add(this.txtTelAjout);
            this.pnlNouveauPompier.Controls.Add(this.txtNomAjout);
            this.pnlNouveauPompier.Controls.Add(this.picGradeAjout);
            this.pnlNouveauPompier.Controls.Add(this.lblnumMatriculeAjout);
            this.pnlNouveauPompier.Controls.Add(this.lblMatriculeAjout);
            this.pnlNouveauPompier.Controls.Add(this.lblFicheAjout);
            this.pnlNouveauPompier.Location = new System.Drawing.Point(0, 0);
            this.pnlNouveauPompier.Name = "pnlNouveauPompier";
            this.pnlNouveauPompier.Size = new System.Drawing.Size(1000, 649);
            this.pnlNouveauPompier.TabIndex = 17;
            this.pnlNouveauPompier.Visible = false;
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDateNaissance.Location = new System.Drawing.Point(619, 181);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(166, 25);
            this.lblDateNaissance.TabIndex = 38;
            this.lblDateNaissance.Text = "Date de naissance";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTel.Location = new System.Drawing.Point(278, 181);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(87, 25);
            this.lblTel.TabIndex = 37;
            this.lblTel.Text = "N° de tel";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPrenom.Location = new System.Drawing.Point(619, 106);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(79, 25);
            this.lblPrenom.TabIndex = 36;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNom.Location = new System.Drawing.Point(278, 106);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(55, 25);
            this.lblNom.TabIndex = 35;
            this.lblNom.Text = "Nom";
            // 
            // pnlSexe
            // 
            this.pnlSexe.Controls.Add(this.rdbF);
            this.pnlSexe.Controls.Add(this.rdbH);
            this.pnlSexe.Location = new System.Drawing.Point(613, 268);
            this.pnlSexe.Name = "pnlSexe";
            this.pnlSexe.Size = new System.Drawing.Size(286, 71);
            this.pnlSexe.TabIndex = 34;
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdbF.Location = new System.Drawing.Point(158, 19);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(94, 29);
            this.rdbF.TabIndex = 3;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "Femme";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // rdbH
            // 
            this.rdbH.AutoSize = true;
            this.rdbH.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdbH.Location = new System.Drawing.Point(25, 19);
            this.rdbH.Name = "rdbH";
            this.rdbH.Size = new System.Drawing.Size(99, 29);
            this.rdbH.TabIndex = 2;
            this.rdbH.TabStop = true;
            this.rdbH.Text = "Homme";
            this.rdbH.UseVisualStyleBackColor = true;
            // 
            // pnlType
            // 
            this.pnlType.Controls.Add(this.rdbVolontaire);
            this.pnlType.Controls.Add(this.rdbPro);
            this.pnlType.Location = new System.Drawing.Point(271, 268);
            this.pnlType.Name = "pnlType";
            this.pnlType.Size = new System.Drawing.Size(288, 71);
            this.pnlType.TabIndex = 33;
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdbVolontaire.Location = new System.Drawing.Point(160, 18);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(118, 29);
            this.rdbVolontaire.TabIndex = 1;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // rdbPro
            // 
            this.rdbPro.AutoSize = true;
            this.rdbPro.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdbPro.Location = new System.Drawing.Point(20, 19);
            this.rdbPro.Name = "rdbPro";
            this.rdbPro.Size = new System.Drawing.Size(134, 29);
            this.rdbPro.TabIndex = 0;
            this.rdbPro.TabStop = true;
            this.rdbPro.Text = "Professionel";
            this.rdbPro.UseVisualStyleBackColor = true;
            // 
            // dateNaissance
            // 
            this.dateNaissance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.dateNaissance.Location = new System.Drawing.Point(613, 212);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(286, 33);
            this.dateNaissance.TabIndex = 32;
            // 
            // picLogoAjout
            // 
            this.picLogoAjout.Image = ((System.Drawing.Image)(resources.GetObject("picLogoAjout.Image")));
            this.picLogoAjout.Location = new System.Drawing.Point(703, 32);
            this.picLogoAjout.Name = "picLogoAjout";
            this.picLogoAjout.Size = new System.Drawing.Size(196, 63);
            this.picLogoAjout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoAjout.TabIndex = 30;
            this.picLogoAjout.TabStop = false;
            // 
            // txtPrenomAjout
            // 
            this.txtPrenomAjout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPrenomAjout.Location = new System.Drawing.Point(611, 134);
            this.txtPrenomAjout.Name = "txtPrenomAjout";
            this.txtPrenomAjout.Size = new System.Drawing.Size(288, 33);
            this.txtPrenomAjout.TabIndex = 24;
            this.txtPrenomAjout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboGradeAjout
            // 
            this.cboGradeAjout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboGradeAjout.FormattingEnabled = true;
            this.cboGradeAjout.Location = new System.Drawing.Point(62, 253);
            this.cboGradeAjout.Name = "cboGradeAjout";
            this.cboGradeAjout.Size = new System.Drawing.Size(146, 33);
            this.cboGradeAjout.TabIndex = 31;
            this.cboGradeAjout.SelectionChangeCommitted += new System.EventHandler(this.cboGradeAjout_SelectionChangeCommitted);
            // 
            // grpInfoAjout
            // 
            this.grpInfoAjout.Controls.Add(this.chkLsAjout);
            this.grpInfoAjout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.grpInfoAjout.Location = new System.Drawing.Point(276, 345);
            this.grpInfoAjout.Name = "grpInfoAjout";
            this.grpInfoAjout.Size = new System.Drawing.Size(641, 218);
            this.grpInfoAjout.TabIndex = 29;
            this.grpInfoAjout.TabStop = false;
            this.grpInfoAjout.Text = "Informations carrière";
            // 
            // chkLsAjout
            // 
            this.chkLsAjout.BackColor = System.Drawing.Color.FloralWhite;
            this.chkLsAjout.CheckOnClick = true;
            this.chkLsAjout.FormattingEnabled = true;
            this.chkLsAjout.Location = new System.Drawing.Point(17, 32);
            this.chkLsAjout.Name = "chkLsAjout";
            this.chkLsAjout.Size = new System.Drawing.Size(601, 172);
            this.chkLsAjout.TabIndex = 3;
            // 
            // txtTelAjout
            // 
            this.txtTelAjout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtTelAjout.Location = new System.Drawing.Point(271, 212);
            this.txtTelAjout.Name = "txtTelAjout";
            this.txtTelAjout.Size = new System.Drawing.Size(288, 33);
            this.txtTelAjout.TabIndex = 25;
            this.txtTelAjout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomAjout
            // 
            this.txtNomAjout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNomAjout.Location = new System.Drawing.Point(271, 134);
            this.txtNomAjout.Name = "txtNomAjout";
            this.txtNomAjout.Size = new System.Drawing.Size(288, 33);
            this.txtNomAjout.TabIndex = 23;
            this.txtNomAjout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picGradeAjout
            // 
            this.picGradeAjout.Location = new System.Drawing.Point(62, 92);
            this.picGradeAjout.Name = "picGradeAjout";
            this.picGradeAjout.Size = new System.Drawing.Size(146, 146);
            this.picGradeAjout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGradeAjout.TabIndex = 22;
            this.picGradeAjout.TabStop = false;
            // 
            // lblnumMatriculeAjout
            // 
            this.lblnumMatriculeAjout.AutoSize = true;
            this.lblnumMatriculeAjout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumMatriculeAjout.Location = new System.Drawing.Point(155, 64);
            this.lblnumMatriculeAjout.Name = "lblnumMatriculeAjout";
            this.lblnumMatriculeAjout.Size = new System.Drawing.Size(53, 25);
            this.lblnumMatriculeAjout.TabIndex = 20;
            this.lblnumMatriculeAjout.Text = "3108";
            this.lblnumMatriculeAjout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatriculeAjout
            // 
            this.lblMatriculeAjout.AutoSize = true;
            this.lblMatriculeAjout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriculeAjout.Location = new System.Drawing.Point(57, 64);
            this.lblMatriculeAjout.Name = "lblMatriculeAjout";
            this.lblMatriculeAjout.Size = new System.Drawing.Size(104, 25);
            this.lblMatriculeAjout.TabIndex = 19;
            this.lblMatriculeAjout.Text = "Matricule :";
            this.lblMatriculeAjout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFicheAjout
            // 
            this.lblFicheAjout.AutoSize = true;
            this.lblFicheAjout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFicheAjout.Location = new System.Drawing.Point(57, 20);
            this.lblFicheAjout.Name = "lblFicheAjout";
            this.lblFicheAjout.Size = new System.Drawing.Size(153, 30);
            this.lblFicheAjout.TabIndex = 18;
            this.lblFicheAjout.Text = "Fiche pompier";
            // 
            // btnAjouterPompier
            // 
            this.btnAjouterPompier.AutoSize = true;
            this.btnAjouterPompier.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAjouterPompier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAjouterPompier.ForeColor = System.Drawing.Color.White;
            this.btnAjouterPompier.Location = new System.Drawing.Point(728, 588);
            this.btnAjouterPompier.Name = "btnAjouterPompier";
            this.btnAjouterPompier.Size = new System.Drawing.Size(198, 31);
            this.btnAjouterPompier.TabIndex = 39;
            this.btnAjouterPompier.Text = "Ajouter pompier";
            this.btnAjouterPompier.UseVisualStyleBackColor = false;
            this.btnAjouterPompier.Click += new System.EventHandler(this.btnAjouterPompier_Click);
            // 
            // lblAffecterA
            // 
            this.lblAffecterA.AutoSize = true;
            this.lblAffecterA.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAffecterA.Location = new System.Drawing.Point(57, 299);
            this.lblAffecterA.Name = "lblAffecterA";
            this.lblAffecterA.Size = new System.Drawing.Size(97, 25);
            this.lblAffecterA.TabIndex = 40;
            this.lblAffecterA.Text = "Affecter à";
            // 
            // cboCaserneAjout
            // 
            this.cboCaserneAjout.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaserneAjout.FormattingEnabled = true;
            this.cboCaserneAjout.Location = new System.Drawing.Point(62, 327);
            this.cboCaserneAjout.Name = "cboCaserneAjout";
            this.cboCaserneAjout.Size = new System.Drawing.Size(146, 28);
            this.cboCaserneAjout.TabIndex = 41;
            // 
            // btnfermer
            // 
            this.btnfermer.AutoSize = true;
            this.btnfermer.BackColor = System.Drawing.Color.White;
            this.btnfermer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnfermer.ForeColor = System.Drawing.Color.Black;
            this.btnfermer.Location = new System.Drawing.Point(38, 588);
            this.btnfermer.Name = "btnfermer";
            this.btnfermer.Size = new System.Drawing.Size(198, 31);
            this.btnfermer.TabIndex = 42;
            this.btnfermer.Text = "Fermer";
            this.btnfermer.UseVisualStyleBackColor = false;
            this.btnfermer.Click += new System.EventHandler(this.btnfermer_Click);
            // 
            // UCgestionPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.pnlNouveauPompier);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.cboGrade);
            this.Controls.Add(this.btnConfirmerModif);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnlLog);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.txtBip);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtDateEmbauche);
            this.Controls.Add(this.txtNaissance);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.picGrade);
            this.Controls.Add(this.lblNumMatricule);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.lblFiche);
            this.Controls.Add(this.grpEste);
            this.Name = "UCgestionPompier";
            this.Size = new System.Drawing.Size(1000, 649);
            this.Load += new System.EventHandler(this.UCgestionPompier_Load);
            this.grpEste.ResumeLayout(false);
            this.grpEste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrade)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlNouveauPompier.ResumeLayout(false);
            this.pnlNouveauPompier.PerformLayout();
            this.pnlSexe.ResumeLayout(false);
            this.pnlSexe.PerformLayout();
            this.pnlType.ResumeLayout(false);
            this.pnlType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoAjout)).EndInit();
            this.grpInfoAjout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGradeAjout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEste;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cboPompier;
        private System.Windows.Forms.Label lblFiche;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblNumMatricule;
        private System.Windows.Forms.PictureBox picGrade;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNaissance;
        private System.Windows.Forms.TextBox txtDateEmbauche;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtBip;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.ListBox lbAncienneAffectation;
        private System.Windows.Forms.Label lblConger;
        private System.Windows.Forms.ListBox lbHabilitions;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Panel pnlLog;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnConfirmerModif;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.CheckedListBox chklstHabilitations;
        private System.Windows.Forms.Panel pnlNouveauPompier;
        private System.Windows.Forms.PictureBox picLogoAjout;
        private System.Windows.Forms.TextBox txtPrenomAjout;
        private System.Windows.Forms.ComboBox cboGradeAjout;
        private System.Windows.Forms.GroupBox grpInfoAjout;
        private System.Windows.Forms.CheckedListBox chkLsAjout;
        private System.Windows.Forms.TextBox txtTelAjout;
        private System.Windows.Forms.TextBox txtNomAjout;
        private System.Windows.Forms.PictureBox picGradeAjout;
        private System.Windows.Forms.Label lblnumMatriculeAjout;
        private System.Windows.Forms.Label lblMatriculeAjout;
        private System.Windows.Forms.Label lblFicheAjout;
        private System.Windows.Forms.DateTimePicker dateNaissance;
        private System.Windows.Forms.Panel pnlSexe;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbH;
        private System.Windows.Forms.Panel pnlType;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.RadioButton rdbPro;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.ComboBox cboCaserneAjout;
        private System.Windows.Forms.Label lblAffecterA;
        private System.Windows.Forms.Button btnAjouterPompier;
        private System.Windows.Forms.Button btnfermer;
    }
}
