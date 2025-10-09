using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Statistiques
{
    public partial class UCStats: UserControl
    {
        SQLiteConnection cx;
        public UCStats()
        {
            InitializeComponent();

            /*string chcon = @"Data Source = SDIS67.db";

            try
            {
                cx = new SQLiteConnection(chcon);
                cx.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cx.Close();*/
        }

        public UCStats(SQLiteConnection connec)
        {
            InitializeComponent();
            cx = connec;


        }
        private void UCStats_Load(object sender, EventArgs e)
        {

            string qry = "SELECT id, nom FROM Caserne";
            SQLiteDataAdapter da = new SQLiteDataAdapter(qry, cx);
            DataTable dt = new DataTable();
            da.Fill(dt);

            
            DataRow newRow = dt.NewRow();
            newRow["id"] = -1; 
            newRow["nom"] = "Toutes les casernes";
            dt.Rows.InsertAt(newRow, 0);

            cboCaserne.DataSource = dt;
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";

            
            cboCaserne.SelectedIndex = -1;

            rdbNbIntervention.Text = "Nombre d'interventions par\n type de sinistre";
            rdbPompierHabil.Text = "Liste des pompiers par\n habilitation";

        }

        private void rdbEnginUtil_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);
            ChargerEnginsLesPlusUtilises(idCaserne);
        }

        private void ChargerEnginsLesPlusUtilises(int x)
        {
            try
            {
                string requete = "SELECT Te.nom, p.numeroEngin, COUNT(*) AS nb_utilisations FROM PartirAvec p JOIN TypeEngin Te ON Te.code = p.codeTypeEngin WHERE p.idCaserne = " + x.ToString() + " GROUP BY p.numeroEngin ORDER BY nb_utilisations DESC;";

                SQLiteCommand cmd = new SQLiteCommand(requete, cx);
                SQLiteDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbCumul_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);
            ChargerCumulUtilisationEngins(idCaserne);
        }

        private void ChargerCumulUtilisationEngins(int x)
        {
            try
            {
                string requete = "SELECT Te.nom, p.numeroEngin, ROUND(SUM(julianday(M.dateHeureRetour) - julianday(M.dateHeureDepart)), 3) * 24 AS nbHeureUtilisation FROM PartirAvec p JOIN TypeEngin Te ON Te.code = p.codeTypeEngin JOIN Mission m ON m.id = p.idMission WHERE p.idCaserne = " + x.ToString() + " GROUP BY p.numeroEngin ORDER BY nbHeureUtilisation DESC;";

                SQLiteCommand cmd = new SQLiteCommand(requete, cx);
                SQLiteDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbNbIntervention_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            ChargerNbInterventions();
        }

        private void ChargerNbInterventions()
        {
            try
            {
                string requete = "SELECT NS.libelle AS type_sinistre, COUNT(*) AS nb_interventions " +
                                "FROM Mission M " +
                                "JOIN NatureSinistre NS ON M.idNatureSinistre = NS.id " +
                                "GROUP BY NS.libelle " +
                                "ORDER BY nb_interventions DESC";

                SQLiteCommand cmd = new SQLiteCommand(requete, cx);
                SQLiteDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbHabilitations_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            ChargerHabilitations();
        }

        private void ChargerHabilitations()
        {
            try
            {
                string requete = "SELECT H.libelle, COUNT(*) AS nb_gens_habilités " +
                    "FROM Mobiliser MO " +
                    "JOIN Habilitation H ON MO.idHabilitation = H.id " +
                    "GROUP BY H.libelle " +
                    "ORDER BY nb_gens_habilités DESC;";

                SQLiteCommand cmd = new SQLiteCommand(requete, cx);
                SQLiteDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbPompierHabil_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            ChargerListePompiers();
        }

        private void ChargerListePompiers()
        {
            try
            {
                string requete = "SELECT H.libelle, P.nom, P.prenom FROM Habilitation H LEFT JOIN Passer PA ON H.id = PA.idHabilitation LEFT JOIN Pompier P ON PA.matriculePompier = P.matricule ORDER BY H.libelle, P.nom, P.prenom;";

                SQLiteDataAdapter da = new SQLiteDataAdapter(requete, cx);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            if (cboCaserne.SelectedIndex == -1 || cboCaserne.SelectedValue == null)
                return;

            // Évite l’erreur DataRowView
            if (cboCaserne.SelectedValue is DataRowView)
                return;

            if (Convert.ToInt32(cboCaserne.SelectedValue)==-1)
            {
                pnlToutesLesC.Visible = true;
                pnl1Caserne.Visible = false;
            }
            else
            {
                lblNomCaserne.Text = cboCaserne.Text;
                pnlToutesLesC.Visible = false;
                pnl1Caserne.Visible = true;
            }

            rdbCumul.Checked = false;
            rdbEnginUtil.Checked = false;
            rdbNbIntervention.Checked = false;
            rdbHabilitations.Checked = false;
            rdbPompierHabil.Checked = false;
        }

        private void pbStat_Click(object sender, EventArgs e)
        {

        }
    }
}
