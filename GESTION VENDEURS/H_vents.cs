using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GESTION_VENDEURS.Form2;

namespace GESTION_VENDEURS
{
    public partial class H_vents : Form
    {
        private string nomClient;
        private string cinClient;
        private string dateVent;
        private int factureId;


        public H_vents()
        {
            InitializeComponent();
        }

        private void H_vents_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTableVentes = Facture.Affichpro();

                // Assurez-vous que AutoGenerateColumns est défini sur true
                tablevents.AutoGenerateColumns = true;
                tablevents.DataSource = dataTableVentes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'affichage des données des ventes : " + ex.Message);
            }
            tablevents.CellClick += tablevents_CellContentClick;


        }

        private void tablevents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = tablevents.Rows[e.RowIndex];

                // Récupérez les données de la ligne sélectionnée
                nomClient = Convert.ToString(row.Cells["Nom clients"].Value);
                cinClient = Convert.ToString(row.Cells["CIN"].Value);
                dateVent = Convert.ToString(row.Cells["Date vente"].Value);
                factureId = Convert.ToInt32(row.Cells["ID facture"].Value);

                // Remplissez les TextBox avec les données récupérées
                txtncc.Text = nomClient;
                txtcinc.Text = cinClient;
                txtdcc.Text = dateVent;
                txtnf.Text = Convert.ToString(factureId);
            }

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_consulter_Click(object sender, EventArgs e)
        {
            // Créer une instance de detailF
            // Créer une instance de detailF
            detailF p = new detailF();

            // Passer les valeurs stockées dans les variables globales à l'instance de detailF
            p.FactureId = factureId;
            p.NomClient = txtncc.Text;
            p.CinClient = txtcinc.Text;
            p.DateVente = txtdcc.Text;

            // Afficher le formulaire 
            p.TopLevel = false;
            this.Controls.Add(p);
            p.BringToFront();
            p.Show();

        }
    }
}

