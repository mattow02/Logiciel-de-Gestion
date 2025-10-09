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

namespace Engin
{
    public partial class Engin: UserControl
    {
        private static DataSet dsGlobal = new DataSet();


        public Engin()
        {
            InitializeComponent();

            //Pour tester le UC en local sans les fichiers de connexion et mesDatas
            /*string chcon = @"Data Source = SDIS67.db";
            cx = new SQLiteConnection(chcon);
            string[] tables = { "Admin", "Affectation", "Caserne", "Embarquer", "Engin", "Grade", "Habilitation", "Mission", "Mobiliser", "NatureSinistre", "Necessiter", "PartirAvec", "Passer", "Pompier", "TypeEngin", "sqlite_sequence" };

            dsGlobal.Tables.Clear();

            foreach (string table in tables)
            {
                string qry = "select * from " + table;
                SQLiteDataAdapter da = new SQLiteDataAdapter(qry, cx);
                DataTable dt = new DataTable(table);
                da.Fill(dt);
                dsGlobal.Tables.Add(dt);
            }*/
        }

        public Engin(DataSet ds)
        {
            InitializeComponent();
            dsGlobal = ds;

        }



        BindingSource bs = new BindingSource();

        private void Engin_Load(object sender, EventArgs e)
        {
            string texteStatut = lblStatut.Text;

            cboCaserne.DataSource = dsGlobal.Tables["Caserne"];
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";


            // Ne déclenche pas SelectedIndexChanged ici (on l’ignore au chargement)
            cboCaserne.SelectedIndexChanged -= cboCaserne_SelectedIndexChanged;
            cboCaserne.SelectedIndex = -1;
            cboCaserne.SelectedIndexChanged += cboCaserne_SelectedIndexChanged;

            btnPrem.Image = Properties.Resources.boutonEngin1R;
            btnAvant.Image = Properties.Resources.boutonEngin2_removebg_preview;
            btnApres.Image = Properties.Resources.boutonEngin2R;
            btnDernier.Image = Properties.Resources.boutonEngin_removebg_preview__1_;
            /*pbLogo.Image = Properties.Resources.Logo_FireBase_HQ_removebg_preview;*/

        }

        private void btnPrem_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btnAvant_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnApres_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void cboCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCaserne.SelectedIndex == -1 || cboCaserne.SelectedValue == null)
                return;

            // Évite l’erreur DataRowView
            if (cboCaserne.SelectedValue is DataRowView)
                return;

            int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);

            DataRow[] enginsFiltres = dsGlobal.Tables["Engin"]
                .Select("idCaserne = " + idCaserne);

            DataTable dtEnginsFiltres = dsGlobal.Tables["Engin"].Clone();
            foreach (DataRow row in enginsFiltres)
                dtEnginsFiltres.ImportRow(row);

            dtEnginsFiltres.Columns.Add("numeroid", typeof(string));
            foreach (DataRow row in dtEnginsFiltres.Rows)
            {
                row["numeroid"] = row["idCaserne"] + "-" + row["codeTypeEngin"] + "-" + row["numero"];
            }

            bs.DataSource = dtEnginsFiltres;

            lblStatut.Text = "Statut de l'engin : Disponible";

            lblNum2.DataBindings.Clear();
            lblDate2.DataBindings.Clear();
            chkMission.DataBindings.Clear();
            chkPanne.DataBindings.Clear();

            lblNum2.DataBindings.Add("Text", bs, "numeroid");
            lblDate2.DataBindings.Add("Text", bs, "dateReception");
            chkMission.DataBindings.Add("Checked", bs, "enMission");
            chkPanne.DataBindings.Add("Checked", bs, "enPanne");

            bs.MoveFirst();
        }
        
        

        private void chkPanne_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPanne.Checked)
            {
                lblPanne.Visible = true;
                lblStatut.Text = "Statut de l'engin : Non disponible";
            }
            else
            {
                lblPanne.Visible = false;
                lblStatut.Text = "Statut de l'engin : Disponible";
            }
        }

        private void lblNum2_TextChanged(object sender, EventArgs e)
        {
            string code = lblNum2.Text;

            if (code.Contains("BRS"))
            {
                pb1.Image = Properties.Resources.BRS;
            }
            else if (code.Contains("CCF"))
            {
                pb1.Image = Properties.Resources.CCF;
            }
            else if (code.Contains("EPA"))
            {
                pb1.Image = Properties.Resources.EPA;
            }
            else if (code.Contains("FCYN"))
            {
                pb1.Image = Properties.Resources.FCYN;
            }
            else if (code.Contains("FPT"))
            {
                pb1.Image = Properties.Resources.FPT;
            }
            else if (code.Contains("VID"))
            {
                pb1.Image = Properties.Resources.VID;
            }
            else if (code.Contains("VPC"))
            {
                pb1.Image = Properties.Resources.VPC;
            }
            else if (code.Contains("VSAV"))
            {
                pb1.Image = Properties.Resources.VSAV;
            }
            else if (code.Contains("VSR"))
            {
                pb1.Image = Properties.Resources.VSR;
            }
            else if (code.Contains("VSS"))
            {
                pb1.Image = Properties.Resources.VSS;
            }
            else
            {
                pb1.Image = null;
            }
        }

        private void chkMission_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMission.Checked)
            {
                lblMission.Visible = true;
                lblStatut.Text = "Statut de l'engin : Non disponible";
            }
            else
            {
                lblMission.Visible = false;
                lblStatut.Text = "Statut de l'engin : Disponible";
            }
        }
    }
}
