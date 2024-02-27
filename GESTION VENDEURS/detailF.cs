using MySql.Data.MySqlClient;
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
    public partial class detailF : Form
    {
        public int FactureId { get; set; }
        public string NomClient { get; set; }
        public string CinClient { get; set; }
        public string DateVente { get; set; }
       // private BindingSource bindingSource = new BindingSource();



        public detailF()
        {
            InitializeComponent();
           // tablevp.DataSource = bindingSource;


        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void detailF_Load_1(object sender, EventArgs e)
        {
            txtcinc.Text = CinClient;
            txtncc.Text = NomClient;
            txtnf.Text =Convert.ToString(FactureId);
            txtdcc.Text = DateVente;
            AfficherVentesFacture();




            // Appeler la méthode pour afficher les ventes de la facture
        }

        public void AfficherVentesFacture()
        {
            try
            {
                const string query = @"
            SELECT 
                p.NomProduit AS 'Nom Produit',
                v.qte AS 'Quantité',
                Prix AS 'Prix (Kg) /DH',
                v.prixtotal AS 'Prix Total /DH'
            FROM 
                ventes v
            JOIN 
                produits p ON p.IDProduit = v.produit_id
            WHERE 
                v.facture_id = @factureId";

                using (MySqlConnection connection = new MySqlConnection(connexion.cnx.ConnectionString))
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@factureId", FactureId);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Liaison du DataTable au DataGridView
                        tablevp.DataSource = dataTable;
                    }

                    // Maintenant, récupérons le prix net
                    string queryPrixNet = "SELECT SUM(prixtotal) FROM ventes WHERE facture_id = @factureId";
                    using (MySqlCommand cmd = new MySqlCommand(queryPrixNet, connection))
                    {
                        cmd.Parameters.AddWithValue("@factureId", FactureId);
                        object prixNetResult = cmd.ExecuteScalar();
                        if (prixNetResult != null)
                        {
                            txtpn.Text = prixNetResult.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des données des ventes de facture : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void tablevf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablevp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_consulter_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtncc_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtdcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnf_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtcinc_TextChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
