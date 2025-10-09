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

namespace UCLogin
{
    public partial class UcLogin: UserControl
    {
        public SQLiteConnection cx;
        public event EventHandler connexionReussi;
        public event EventHandler btnAnnulClick;

        public UcLogin()
        {
            InitializeComponent();
        }

        public UcLogin(SQLiteConnection conn)
        {
            InitializeComponent();
            cx = conn;
        }

        private void UCLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text.Length == 0 || txtMdp.Text.Length == 0) 
            {
                MessageBox.Show("Veuillez renseigner tout les champs");
            }

            else
            {
                string qry = @"select * from admin where login = '" + txtLogin.Text + "'";

                SQLiteDataAdapter da = new SQLiteDataAdapter(qry, cx);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count > 0 )
                {
                    if (dt.Rows[0]["mdp"].ToString() == txtMdp.Text)
                    {
                        connexionReussi?.Invoke(this, EventArgs.Empty);
                    }

                    else
                    {
                        MessageBox.Show("Mot de passe incorrect");
                    }
                }

                else
                {
                    MessageBox.Show("Login incorrect");
                }
            }
        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            btnAnnulClick?.Invoke(this, EventArgs.Empty);
        } 
    }
}
