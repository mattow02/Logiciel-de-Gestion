using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using System.IO;
using iText.Layout.Borders;
using System.Data;

namespace UC_Tableau_de_bord
{
    public partial class UserControl1 : UserControl
    {
        private List<Probleme> toutesLesMissions;
        private static DataSet DsGlobal = new DataSet();
        public UserControl1()
        {
            InitializeComponent();

            // CheckBox "En cours"
            CheckBox chkEnCours = new CheckBox();
            chkEnCours.Text = "Mission en cours ";
            chkEnCours.AutoSize = true;
            chkEnCours.Location = new System.Drawing.Point(10, 10);
            chkEnCours.CheckedChanged += ChkEnCours_CheckedChanged;
            this.Controls.Add(chkEnCours);

            // Charger les missions depuis la base
            toutesLesMissions = ChargerProblemesDepuisBase(DsGlobal);
            AfficherTableauDeBord(toutesLesMissions);

            //Pour tester le UC en local sans les fichiers de connexion et mesDatas
            
            string chcon = @"Data Source = SDIS67.db";
            SQLiteConnection cx = new SQLiteConnection(chcon);
            string[] tables = { "Admin", "Affectation", "Caserne", "Embarquer", "Engin", "Grade", "Habilitation", "Mission", "Mobiliser", "NatureSinistre", "Necessiter", "PartirAvec", "Passer", "Pompier", "TypeEngin", "sqlite_sequence" };

            DsGlobal.Tables.Clear();

            foreach (string table in tables)
            {
                string qry = "select * from " + table;
                SQLiteDataAdapter da = new SQLiteDataAdapter(qry, cx);
                DataTable dt = new DataTable(table);
                da.Fill(dt);
                dsGlobal.Tables.Add(dt);
            }
        }

        public UserControl1(DataSet ds)
        {
            InitializeComponent();

            DsGlobal = ds;

            // CheckBox "En cours"
            CheckBox chkEnCours = new CheckBox();
            chkEnCours.Text = "Mission en cours ";
            chkEnCours.AutoSize = true;
            chkEnCours.Location = new System.Drawing.Point(10, 10);
            chkEnCours.CheckedChanged += ChkEnCours_CheckedChanged;
            this.Controls.Add(chkEnCours);

            // Charger les missions depuis la base
            toutesLesMissions = ChargerProblemesDepuisBase(DsGlobal);
            AfficherTableauDeBord(toutesLesMissions);
        }

        private void ChkEnCours_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            var liste = chk.Checked
                ? toutesLesMissions.Where(p => !p.DateRetour.HasValue).ToList()
                : toutesLesMissions;

            AfficherTableauDeBord(liste);
        }

        private void AfficherTableauDeBord(List<Probleme> listeProblemes)
        {
            // Supprimer l'ancien panel d'affichage
            Control scrollable = this.Controls.Find("panelScrollable", true).FirstOrDefault();
            if (scrollable != null)
                this.Controls.Remove(scrollable);

            // Supprimer l'ancien titre s'il existe
            Control ancienTitre = this.Controls.Find("labelTitreTableau", true).FirstOrDefault();
            if (ancienTitre != null)
                this.Controls.Remove(ancienTitre);

            // Supprimer l'ancienne barre de séparation si elle existe
            Control ancienneBarre = this.Controls.Find("barreSeparation", true).FirstOrDefault();
            if (ancienneBarre != null)
                this.Controls.Remove(ancienneBarre);

            // Titre
            Label titre = new Label();
            titre.Name = "labelTitreTableau";
            titre.Text = "Tableau de bord";
            titre.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            titre.Location = new System.Drawing.Point(this.Width / 2 - 120, 10);
            titre.AutoSize = true;
            this.Controls.Add(titre);

            // Ligne séparation
            Panel barreSeparation = new Panel();
            barreSeparation.Name = "barreSeparation";
            barreSeparation.Height = 2;
            barreSeparation.Width = this.Width - 20;
            barreSeparation.BackColor = Color.Gray;
            barreSeparation.Location = new System.Drawing.Point(10, 50);
            this.Controls.Add(barreSeparation);

            // Panel scrollable
            FlowLayoutPanel panelScrollable = new FlowLayoutPanel();
            panelScrollable.Location = new System.Drawing.Point(0, 60);
            panelScrollable.Size = new Size(this.Width, this.Height - 60);
            panelScrollable.AutoScroll = true;
            panelScrollable.Name = "panelScrollable";
            panelScrollable.FlowDirection = FlowDirection.TopDown;
            panelScrollable.WrapContents = false;
            this.Controls.Add(panelScrollable);

            if (listeProblemes.Count == 0)
            {
                Label lblVide = new Label();
                lblVide.Text = "Aucune mission à afficher";
                lblVide.Font = new Font("Segoe UI", 12, FontStyle.Italic);
                lblVide.ForeColor = Color.Gray;
                lblVide.AutoSize = true;
                panelScrollable.Controls.Add(lblVide);
            }
            else
            {
                foreach (var probleme in listeProblemes)
                {
                    Panel ligne = new Panel();
                    ligne.Width = panelScrollable.ClientSize.Width - 20;
                    ligne.Height = 120;
                    ligne.Margin = new Padding(5); // Ajout d'un espacement entre les lignes

                    Panel carte = new Panel();
                    carte.Width = ligne.Width - 120;
                    carte.Height = 100;
                    carte.Location = new System.Drawing.Point(0, 10);
                    carte.BackColor = Color.WhiteSmoke;
                    carte.BorderStyle = BorderStyle.FixedSingle;

                    PictureBox icone = new PictureBox();
                    icone.Image = Properties.Resources.alarme;
                    icone.Size = new Size(60, 60);
                    icone.Location = new System.Drawing.Point(10, 20);
                    icone.SizeMode = PictureBoxSizeMode.Zoom;

                    Label infos = new Label();
                    infos.Text = $"Id mission : {probleme.Id}    Début : {probleme.DateSignalement.ToShortDateString()}    Caserne : {probleme.Caserne}";
                    infos.Font = new Font("Segoe UI", 9);
                    infos.Location = new System.Drawing.Point(80, 10);
                    infos.AutoSize = true;

                    Label titreProblème = new Label();
                    titreProblème.Text = probleme.Titre;
                    titreProblème.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    titreProblème.Location = new System.Drawing.Point(80, 35);
                    titreProblème.AutoSize = true;

                    Label desc = new Label();
                    desc.Text = "--> " + probleme.Description;
                    desc.Font = new Font("Segoe UI", 9);
                    desc.Location = new System.Drawing.Point(250, 35);
                    desc.AutoSize = true;

                    carte.Controls.Add(icone);
                    carte.Controls.Add(infos);
                    carte.Controls.Add(titreProblème);
                    carte.Controls.Add(desc);

                    Panel panelBoutons = new Panel();
                    panelBoutons.Width = 110;
                    panelBoutons.Height = 100;
                    panelBoutons.Location = new System.Drawing.Point(carte.Width + 10, 10);

                    Button btnPDF = new Button();
                    btnPDF.Size = new Size(40, 40);
                    btnPDF.Location = new System.Drawing.Point(0, 5);
                    btnPDF.BackColor = Color.LightBlue;
                    btnPDF.BackgroundImage = Properties.Resources.pdf;
                    btnPDF.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPDF.FlatStyle = FlatStyle.Flat;
                    btnPDF.FlatAppearance.BorderSize = 0;
                    btnPDF.Cursor = Cursors.Hand;
                    btnPDF.MouseEnter += (s, e) => btnPDF.BackColor = Color.DodgerBlue;
                    btnPDF.MouseLeave += (s, e) => btnPDF.BackColor = Color.LightBlue;

                    btnPDF.Click += (s, e) =>
                    {
                        var mission = GetMissionParId(probleme.Id, DsGlobal);
                        GenererPDF(mission);
                    };

                    Button btnSupprimer = new Button();
                    btnSupprimer.Size = new Size(40, 40);
                    btnSupprimer.Location = new System.Drawing.Point(0, 50);
                    btnSupprimer.BackColor = Color.IndianRed;
                    btnSupprimer.BackgroundImage = Properties.Resources.croix_rouge;
                    btnSupprimer.BackgroundImageLayout = ImageLayout.Stretch;
                    btnSupprimer.FlatStyle = FlatStyle.Flat;
                    btnSupprimer.FlatAppearance.BorderSize = 0;
                    btnSupprimer.Cursor = Cursors.Hand;
                    btnSupprimer.MouseEnter += (s, e) => btnSupprimer.BackColor = Color.Firebrick;
                    btnSupprimer.MouseLeave += (s, e) => btnSupprimer.BackColor = Color.IndianRed;
                    btnSupprimer.Click += (s, e) =>
                    {
                        panelScrollable.Controls.Remove(ligne);
                    };

                    panelBoutons.Controls.Add(btnPDF);
                    panelBoutons.Controls.Add(btnSupprimer);

                    ligne.Controls.Add(carte);
                    ligne.Controls.Add(panelBoutons);
                    panelScrollable.Controls.Add(ligne);
                }
            }
        }



        private void GenererPDF(MissionComplete mission)
        {
            string chemin = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                $"Rapport_Mission_{mission.Id}.pdf"
            );

            using (PdfWriter writer = new PdfWriter(chemin))
            using (PdfDocument pdf = new PdfDocument(writer))
            {
                Document doc = new Document(pdf, PageSize.A4);
                doc.SetMargins(30, 30, 30, 30);

                PdfFont fontTitre = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                PdfFont fontItalique = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_OBLIQUE);

                // Titre principal
                doc.Add(new Paragraph("Rapport de mission").SetFont(fontTitre).SetFontSize(16));

                // Table à deux colonnes
                Table table = new Table(UnitValue.CreatePercentArray(new float[] { 50, 50 })).UseAllAvailableWidth();

                // Colonne gauche : Informations générales
                var colGauche = new Paragraph()
                    .Add($"Déclenchée le {mission.DateDebut:dd-MM-yyyy à HH\\hmm}\n")
                    .Add($"Retour le {(mission.DateRetour.HasValue ? mission.DateRetour.Value.ToString("dd-MM-yyyy à HH\\hmm") : "N/A")}\n\n")
                    .Add(new Text("Type de sinistre : ").SetFont(fontTitre)).Add($"{mission.Titre}\n")
                    .Add(new Text("Motif : ").SetFont(fontTitre)).Add($"{mission.Description}\n")
                    .Add(new Text("Adresse : ").SetFont(fontTitre)).Add($"{mission.Adresse}\n")
                    .Add(new Text("Compte-rendu : ").SetFont(fontTitre)).Add($"{mission.CompteRendu}\n\n")
                    .Add(new Text("Caserne : ").SetFont(fontTitre)).Add($"{mission.Caserne}\n\n")
                    .Add(new Text("Pompiers affectés :\n").SetFont(fontTitre));

                if (mission.Pompiers.Any())
                    mission.Pompiers.ForEach(p => colGauche.Add(new Paragraph("→ " + p).SetFont(fontItalique).SetMargin(0)));
                else
                    colGauche.Add(new Paragraph("Aucun pompier enregistré.").SetFont(fontItalique));

                table.AddCell(new Cell().Add(colGauche).SetBorder(Border.NO_BORDER));

                // Colonne droite : Engins
                var colDroite = new Paragraph()
                    .Add(new Text("Engins utilisés :\n").SetFont(fontTitre));

                if (mission.Engins.Any())
                    mission.Engins.ForEach(e => colDroite.Add(new Paragraph("→ " + e).SetFont(fontNormal).SetMargin(0)));
                else
                    colDroite.Add(new Paragraph("Aucun engin enregistré.").SetFont(fontItalique));

                table.AddCell(new Cell().Add(colDroite).SetBorder(Border.NO_BORDER));

                doc.Add(table);
                doc.Close();
            }

            MessageBox.Show("PDF généré avec succès sur le Bureau.", "PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void flowLayoutPanelProbleme_Paint(object sender, PaintEventArgs e)
        {
            // Laisser vide ou ajouter du code si nécessaire
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            // Laisser vide ou ajouter du code si nécessaire
        }

        public static List<Probleme> ChargerProblemesDepuisBase(DataSet DsGlobal)
        {
            List<Probleme> liste = new List<Probleme>();

            try
            {
                // Accéder à la table Mission dans le DataSet
                DataTable missionTable = DsGlobal.Tables["Mission"];

                // Vérifier si la table existe
                if (missionTable == null)
                {
                    Console.WriteLine("La table 'Mission' n'existe pas dans le DataSet.");
                    return liste; // Retourner une liste vide
                }

                // Utiliser LINQ to DataSet pour effectuer la requête
                var problemesQuery = from missionRow in missionTable.AsEnumerable()
                                     select new Probleme
                                     {
                                         Id = missionRow.Field<int>("Id"),
                                         Titre = missionRow.Field<string>("motifAppel"),
                                         Description = missionRow.Field<string>("compteRendu"),
                                         DateSignalement = missionRow.Field<DateTime>("DateHeureDepart"),
                                         NiveauUrgence = missionRow.Field<int>("idNatureSinistre").ToString(), // Convertir en string
                                         Caserne = missionRow.Field<int>("idCaserne").ToString(), // Convertir en string
                                         DateRetour = missionRow.Field<DateTime?>("DateHeureRetour")
                                     };

                liste = problemesQuery.ToList(); // Convertir le résultat en List<Probleme>
            }
            catch (Exception ex)
            {
                // Gérer l'exception ici
                Console.WriteLine("Une erreur s'est produite lors du chargement des problèmes : " + ex.Message);
                // Vous pouvez également enregistrer l'erreur dans un fichier journal ou afficher un message d'erreur à l'utilisateur
            }

            return liste;
        }




    public static MissionComplete GetMissionParId(int id, DataSet DsGlobal)
        {
            MissionComplete mission = new MissionComplete
            {
                Pompiers = new List<string>(),
                Engins = new List<string>()
            };

            // --- Requête principale avec jointures ---
            string requete = @"
                            SELECT 
                                M.dateHeureDepart, 
                                M.dateHeureRetour, 
                                M.motifAppel, 
                                M.adresse, 
                                M.cp, 
                                M.ville,
                                M.terminee, 
                                M.compteRendu, 
                                N.libelle AS nomSinistre,
                                C.nom AS nomCaserne
                            FROM Mission M
                            JOIN NatureSinistre N ON M.idNatureSinistre = N.id
                            JOIN Caserne C ON M.idCaserne = C.id
                            WHERE M.id = @id";

            // Accéder à la table Mission dans le DataSet
            DataTable missionTable = DsGlobal.Tables["Mission"];
            DataTable natureSinistreTable = DsGlobal.Tables["NatureSinistre"];
            DataTable caserneTable = DsGlobal.Tables["Caserne"];

            // Utiliser LINQ to DataSet pour effectuer la requête
            var missionQuery = from missionRow in missionTable.AsEnumerable()
                               join natureSinistreRow in natureSinistreTable.AsEnumerable()
                                   on missionRow.Field<int>("idNatureSinistre") equals natureSinistreRow.Field<int>("id")
                               join caserneRow in caserneTable.AsEnumerable()
                                   on missionRow.Field<int>("idCaserne") equals caserneRow.Field<int>("id")
                               where missionRow.Field<int>("id") == id
                               select new
                               {
                                   dateHeureDepart = missionRow.Field<DateTime>("dateHeureDepart"),
                                   dateHeureRetour = missionRow.Field<DateTime?>("dateHeureRetour"),
                                   motifAppel = missionRow.Field<string>("motifAppel"),
                                   adresse = missionRow.Field<string>("adresse"),
                                   cp = missionRow.Field<string>("cp"),
                                   ville = missionRow.Field<string>("ville"),
                                   terminee = missionRow.Field<bool>("terminee"),
                                   compteRendu = missionRow.Field<string>("compteRendu"),
                                   nomSinistre = natureSinistreRow.Field<string>("libelle"),
                                   nomCaserne = caserneRow.Field<string>("nom"),
                                   Id = missionRow.Field<int>("id")
                               };

            var missionResult = missionQuery.FirstOrDefault(); // Récupérer le premier résultat ou null

            if (missionResult != null)
            {
                mission.Id = missionResult.Id;
                mission.Titre = missionResult.nomSinistre;
                mission.Description = missionResult.motifAppel;
                mission.Adresse = missionResult.adresse;
                mission.DateDebut = missionResult.dateHeureDepart;
                mission.DateRetour = missionResult.dateHeureRetour;
                mission.Caserne = missionResult.nomCaserne;
                mission.CompteRendu = string.IsNullOrEmpty(missionResult.compteRendu) ? "Non renseigné." : missionResult.compteRendu;
            }

            // --- Récupération des pompiers associés à la mission via Mobiliser ---
            DataTable mobiliserTable = DsGlobal.Tables["Mobiliser"];
            DataTable pompierTable = DsGlobal.Tables["Pompier"];

            var pompiersQuery = from mobiliserRow in mobiliserTable.AsEnumerable()
                                join pompierRow in pompierTable.AsEnumerable()
                                    on mobiliserRow.Field<string>("matriculePompier") equals pompierRow.Field<string>("matricule")
                                where mobiliserRow.Field<int>("idMission") == id
                                select pompierRow.Field<string>("Nom");

            mission.Pompiers.AddRange(pompiersQuery);

            // --- Récupération des engins associés à la mission via PartirAvec et TypeEngin ---
            DataTable partirAvecTable = DsGlobal.Tables["PartirAvec"];
            DataTable enginTable = DsGlobal.Tables["Engin"];
            DataTable typeEnginTable = DsGlobal.Tables["TypeEngin"];

            var enginsQuery = from partirAvecRow in partirAvecTable.AsEnumerable()
                              join enginRow in enginTable.AsEnumerable()
                                  on new { codeTypeEngin = partirAvecRow.Field<string>("codeTypeEngin"), numeroEngin = partirAvecRow.Field<string>("numeroEngin") }
                                  equals new { codeTypeEngin = enginRow.Field<string>("codeTypeEngin"), numeroEngin = enginRow.Field<string>("numero") }
                              join typeEnginRow in typeEnginTable.AsEnumerable()
                                  on enginRow.Field<string>("codeTypeEngin") equals typeEnginRow.Field<string>("code")
                              where partirAvecRow.Field<int>("idMission") == id
                              select typeEnginRow.Field<string>("nom");

            mission.Engins.AddRange(enginsQuery);

            return mission;
        }
    }
}
