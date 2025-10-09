using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Xml.Linq;
using System.Data.SQLite;
using iText;

namespace UCTDB
{
    public partial class TableauDeBord: UserControl
    {
        private List<Probleme> toutesLesMissions;
        private static DataSet DsGlobal = new DataSet();

        public TableauDeBord()
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
            /*
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
                DsGlobal.Tables.Add(dt);
            }

            // Ajout de code de débogage
            MessageBox.Show("Nombre de tables dans DsGlobal : " + DsGlobal.Tables.Count);
            if (DsGlobal.Tables.Contains("Mission"))
            {
                MessageBox.Show("La table 'Mission' existe.");
                MessageBox.Show("Nombre de lignes dans la table 'Mission' : " + DsGlobal.Tables["Mission"].Rows.Count);
            }
            else
            {
                MessageBox.Show("La table 'Mission' n'existe pas.");
            }
            toutesLesMissions = ChargerProblemesDepuisBase(DsGlobal);
            MessageBox.Show("Nombre de missions chargées : " + toutesLesMissions.Count);
            AfficherTableauDeBord(toutesLesMissions);*/
        }

        public TableauDeBord(DataSet ds)
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

        private void TableauDeBord_Load(object sender, EventArgs e)
        {

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
                        //GenererPDF(mission);
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

        private static string SafeGetString(DataRow row, string columnName)
        {
            if (row.Table.Columns.Contains(columnName) && row[columnName] != DBNull.Value)
            {
                return row[columnName].ToString();
            }
            return string.Empty; // Ou une autre valeur par défaut
        }

        private static int SafeGetInt(DataRow row, string columnName)
        {
            if (row.Table.Columns.Contains(columnName) && row[columnName] != DBNull.Value)
            {
                return Convert.ToInt32(row[columnName]);
            }
            return 0; // Ou une autre valeur par défaut
        }

        private static DateTime SafeGetDateTime(DataRow row, string columnName)
        {
            if (row.Table.Columns.Contains(columnName) && row[columnName] != DBNull.Value)
            {
                return Convert.ToDateTime(row[columnName]);
            }
            return DateTime.MinValue; // Ou une autre valeur par défaut
        }

        private static DateTime? SafeGetDateTimeNullable(DataRow row, string columnName)
        {
            if (row.Table.Columns.Contains(columnName) && row[columnName] != DBNull.Value)
            {
                return Convert.ToDateTime(row[columnName]);
            }
            return null;
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
                                         Id = SafeGetInt(missionRow, "Id"),
                                         Titre = SafeGetString(missionRow, "motifAppel"),
                                         Description = SafeGetString(missionRow, "compteRendu"),
                                         DateSignalement = SafeGetDateTime(missionRow, "DateHeureDepart"),
                                         NiveauUrgence = SafeGetInt(missionRow, "idNatureSinistre").ToString(), // Convertir en string
                                         Caserne = SafeGetInt(missionRow, "idCaserne").ToString(), // Convertir en string
                                         DateRetour = SafeGetDateTimeNullable(missionRow, "DateHeureRetour")
                                     };
                /*MessageBox.Show("Début de la requête LINQ...");
                int count = 0;
                foreach (DataRow row in missionTable.Rows)
                {
                    count++;
                    MessageBox.Show($"Ligne {count}:");
                    MessageBox.Show($"  Id: {row["Id"]}");
                    MessageBox.Show($"  motifAppel: {row["motifAppel"]}");
                    MessageBox.Show($"  compteRendu: {row["compteRendu"]}");
                    MessageBox.Show($"  DateHeureDepart: {row["DateHeureDepart"]}");
                    MessageBox.Show($"  idNatureSinistre: {row["idNatureSinistre"]}");
                    MessageBox.Show($"  idCaserne: {row["idCaserne"]}");
                    MessageBox.Show($"  DateHeureRetour: {row["DateHeureRetour"]}");
                }
                MessageBox.Show("Fin de la requête LINQ.");*/

                liste = problemesQuery.ToList(); // Convertir le résultat en List<Probleme>
            }
            catch (Exception ex)
            {
                // Gérer l'exception ici
                MessageBox.Show("Une erreur s'est produite lors du chargement des problèmes : " + ex.Message);
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
