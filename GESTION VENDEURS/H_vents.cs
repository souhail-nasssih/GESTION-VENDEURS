using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_VENDEURS
{
    public partial class H_vents : Form
    {
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
                string nomClient = Convert.ToString(row.Cells["Nom clients"].Value);
                string cinClient = Convert.ToString(row.Cells["CIN"].Value);
                string dateVent = Convert.ToString(row.Cells["Date vente"].Value);
                string factureId = Convert.ToString(row.Cells["ID facture"].Value);

                // Remplissez les TextBox avec les données récupérées
                txtncc.Text = nomClient;
                txtcinc.Text = cinClient;
                txtdcc.Text = dateVent;
                txtnf.Text = factureId;
            }

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

