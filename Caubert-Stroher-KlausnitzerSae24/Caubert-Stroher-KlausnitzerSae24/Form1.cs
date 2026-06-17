using System;
using System.Drawing;
using System.Windows.Forms;
using Caubert_Stroher_KlausnitzerSae24;
using nouvelleMission;
using E = Engin;
using Statistiques;
using m = UCmobilisations;
using UCGestionPompier;
using UCTDB;

namespace Caubert_Stroher_KlausnitzerSae24
{
    /// <summary>
    /// Main application form. Hosts a navigation sidebar with animated indicator
    /// and a content panel that swaps between different UserControls.
    /// </summary>
    public partial class frmSoldatFeu : Form
    {
        private int _animStartTop;
        private int _animEndTop;
        private double _animDuration = 400; // milliseconds
        private DateTime _animStartTime;

        public frmSoldatFeu()
        {
            InitializeComponent();
            MesDatas.initDs();
        }

        /// <summary>
        /// Loads the dashboard view on startup.
        /// </summary>
        private void frmSoldatFeu_Load(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        // --- Navigation handlers ---

        private void btnTDB_Click(object sender, EventArgs e)
        {
            MoveFlameSmooth(btnTDB);
            ShowDashboard();
        }

        private void btnMission_Click(object sender, EventArgs e)
        {
            MoveFlameSmooth(btnTDB);
            pnlUC.Controls.Clear();

            UCnouvelleMission mission = new UCnouvelleMission(MesDatas.DsGlobal);
            mission.MissionAjouter += OnMissionCreated;
            pnlUC.Controls.Add(mission);
            mission.Show();
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            MoveFlameSmooth(btnPersonnel);
            pnlUC.Controls.Clear();

            UCgestionPompier staff = new UCgestionPompier(MesDatas.DsGlobal, Connexion.Connec);
            pnlUC.Controls.Add(staff);
            staff.Show();
        }

        private void btnEngins_Click(object sender, EventArgs e)
        {
            MoveFlameSmooth(btnEngins);
            pnlUC.Controls.Clear();

            E.Engin vehicles = new E.Engin(MesDatas.DsGlobal);
            pnlUC.Controls.Add(vehicles);
            vehicles.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            MoveFlameSmooth(btnStats);
            pnlUC.Controls.Clear();

            UCStats stats = new UCStats(Connexion.Connec);
            pnlUC.Controls.Add(stats);
            stats.Dock = DockStyle.Fill;
            stats.Show();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --- Helpers ---

        private void ShowDashboard()
        {
            pnlUC.Controls.Clear();
            TableauDeBord dashboard = new TableauDeBord(MesDatas.DsGlobal);
            pnlUC.Controls.Add(dashboard);
            dashboard.Show();
        }

        /// <summary>
        /// Called when a new mission is created. Transitions to the mobilization view
        /// if vehicles are available for dispatch.
        /// </summary>
        private void OnMissionCreated(object sender, EventArgs e)
        {
            var mission = sender as UCnouvelleMission;
            if (mission?.enginsDispo == true)
            {
                m.UCmobilisations mobilization = new m.UCmobilisations(mission.dtEngins, mission.dtPompier);
                pnlUC.Controls.Clear();
                pnlUC.Controls.Add(mobilization);
                mobilization.Show();
            }
        }

        /// <summary>
        /// Smoothly animates the sidebar flame indicator to the target button's position.
        /// Uses cosine easing for a natural feel.
        /// </summary>
        private void MoveFlameSmooth(Button targetButton)
        {
            _animStartTop = picIndicator.Top;
            _animEndTop = targetButton.Top + (targetButton.Height - picIndicator.Height) / 2;
            _animStartTime = DateTime.Now;
            timeIndicator.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double elapsed = (DateTime.Now - _animStartTime).TotalMilliseconds;
            double t = Math.Min(elapsed / _animDuration, 1.0);

            if (t >= 1) timeIndicator.Stop();

            double eased = (1 - Math.Cos(t * Math.PI)) / 2;
            picIndicator.Top = (int)(_animStartTop + (_animEndTop - _animStartTop) * eased);
        }
    }
}
