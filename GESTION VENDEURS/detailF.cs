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



        public detailF()
        {
            InitializeComponent();
           

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



            // Appeler la méthode pour afficher les ventes de la facture
        }

        public void AfficherVentesFacture()
        {
            try
            {
                const string query = @"
                    SELECT 
                        v.idvent,
                        v.date_vent AS 'Date',
                        v.qte AS 'Quantité',
                        Prix AS 'Prix (Kg) /DH',
                        v.prixtotal AS 'Prix Total /DH',
                        p.NomProduit AS 'Nom Produit',
                        (SELECT SUM(prixtotal) FROM ventes WHERE facture_id = @factureId) AS PrixNet
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

                        StringBuilder messageBuilder = new StringBuilder();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            foreach (var item in row.ItemArray)
                            {
                                messageBuilder.Append(item.ToString() + "\t");
                            }
                            messageBuilder.AppendLine();
                        }

                        MessageBox.Show(messageBuilder.ToString(), "Ventes de Facture");

                        tablevp.DataSource = dataTable;
                        tablevp.Refresh();
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
            AfficherVentesFacture();

        }
    }
}
