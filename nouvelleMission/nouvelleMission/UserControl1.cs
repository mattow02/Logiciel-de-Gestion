using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data.Common;
using System.Security.Cryptography;

namespace nouvelleMission
{
    public partial class UCnouvelleMission: UserControl
    {
        static DataSet dsGlobal;
        public event EventHandler MissionAjouter;
        public DataTable dtPompier { get; private set; } = new DataTable();
        public DataTable dtEngins { get; private set; } = new DataTable();
        public bool enginsDispo { get; private set; }



        public UCnouvelleMission(DataSet ds)
        {
            InitializeComponent();
            dsGlobal = ds;

            dtEngins = dsGlobal.Tables["Engin"].Clone();
            dtPompier = dsGlobal.Tables["Pompier"].Clone();
            enginsDispo = true;
        }


        private void UCnouvelleMission_Load(object sender, EventArgs e)
        {
            //remplissage des cbo Casernes et Nature du sinistre
            
            
            DataTable dt = dsGlobal.Tables["NatureSinistre"];
            
            cboNature.DataSource = dt;
            cboNature.DisplayMember = "libelle";
            cboNature.ValueMember = "id";



            dt = dsGlobal.Tables["Caserne"];

            cboCaserne.DataSource = dt;
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";

            //changement libellé n° mission et date de déclenchement
            int nbr = dsGlobal.Tables["Mission"].Rows.Count + 1;

            lblMission.Text = "Mission n°" + nbr.ToString();

            lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");

            
        }

        private void grpInfoUsager_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtVille_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grpDecisions_Enter(object sender, EventArgs e)
        {

        }

        private void lblCaserne_Click(object sender, EventArgs e)
        {

        }

        private void lblMission_Click(object sender, EventArgs e)
        {

        }

        private void lblNumMission_Click(object sender, EventArgs e)
        {

        }

        private void btnConstituer_Click(object sender, EventArgs e)
        {
            int id = dsGlobal.Tables["Mission"].Rows.Count + 1;

            

            //Récuperation des engins nécessaires

            dtEngins = dsGlobal.Tables["Engin"].Clone();

            int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);


            int idSinistre = Convert.ToInt32(cboNature.SelectedValue);

            DataRow[] besoinsEngins = dsGlobal.Tables["Necessiter"].Select($"idNatureSinistre = '{idSinistre}'");

            foreach (DataRow besoin in besoinsEngins)
            {
                string codeTypeEngin = besoin["codeTypeEngin"].ToString();
                int nombre = Convert.ToInt32(besoin["nombre"]);

                string filtre = $"enPanne = 0 AND enMission = 0 AND idCaserne = {idCaserne} AND codeTypeEngin = '{codeTypeEngin}'";
                DataRow[] enginsDisponibles = dsGlobal.Tables["Engin"].Select(filtre);

                if(enginsDisponibles.Length < nombre)
                {
                    enginsDispo = false;
                    break;
                }

                int max = Math.Min(nombre, enginsDisponibles.Length);
                for (int i = 0; i < max; i++)
                {
                    enginsDisponibles[i]["enMission"] = 1; //marque l'engin en mission

                    dtEngins.ImportRow(enginsDisponibles[i]);
                }
            }
            
            //TO-DO, lister les pompier a envoyer en mission
            dtPompier = dsGlobal.Tables["Pompier"].Clone();


            foreach (DataRow engin in dtEngins.Rows)
            {
                string codeTypeEngin = engin["codeTypeEngin"].ToString();

                foreach (DataRow besoin in dsGlobal.Tables["Embarquer"].Select($"codeTypeEngin = '{codeTypeEngin}'"))
                {
                    int idHabilitation = Convert.ToInt32(besoin["idHabilitation"]);
                    int nombre = Convert.ToInt32(besoin["nombre"]);

                    // Tous les pompiers affectés à la caserne
                    foreach (DataRow aff in dsGlobal.Tables["Affectation"].Select($"idCaserne = {idCaserne}"))
                    {
                        string matricule = aff["matriculePompier"].ToString();

                        // Vérifie si ce pompier a cette habilitation (via Passer)
                        bool habilite = dsGlobal.Tables["Passer"].Select($"matriculePompier = '{matricule}' AND idHabilitation = {idHabilitation}").Length > 0;

                        if (!habilite) continue;

                        // Vérifie si ce pompier est disponible
                        DataRow[] pompiers = dsGlobal.Tables["Pompier"].Select($"matricule = '{matricule}' AND enMission = 0 AND enConge = 0");

                        if (pompiers.Length > 0 && nombre > 0)
                        {
                            DataRow pompier = pompiers[0];

                            dtPompier.ImportRow(pompier);
                            pompier["enMission"] = 1; // marquer comme mobilisé
                            nombre--;
                        }

                        if (nombre <= 0)
                            break;
                    }
                }
            }


            if (!enginsDispo)
            {
                MessageBox.Show("Pas assez d'engins dispo ! ");
            }

            else
            {
                //Ajout de la mission dans le dsGlobal de la classe mesDatas.cs
                DataRow drMission = dsGlobal.Tables["Mission"].NewRow();

                drMission["id"] = id;
                drMission["dateHeureDepart"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                /*dr["dateHeureRetour"] = null;*/
                drMission["motifAppel"] = txtMotif.Text;
                drMission["adresse"] = txtRue.Text;
                drMission["cp"] = txtCodePostal.Text;
                drMission["ville"] = txtVille.Text;
                drMission["terminee"] = 0;
                drMission["compteRendu"] = null;
                drMission["idNatureSinistre"] = cboNature.SelectedValue;
                drMission["idCaserne"] = cboCaserne.SelectedValue;

                dsGlobal.Tables["Mission"].Rows.Add(drMission);

                MissionAjouter?.Invoke(this, EventArgs.Empty);
            }

            
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e) 
        {
            this.Parent.Controls.Remove(this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
