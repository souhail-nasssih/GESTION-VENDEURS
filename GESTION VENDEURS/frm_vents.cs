using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GESTION_VENDEURS.Form2;

namespace GESTION_VENDEURS
{


    public partial class frm_vents : Form
    {
        private static int NumeroActuel = 1;

        private int id_cv;
        private string nom;
        private string tel;
        private string cin;
        private int idClient;
        private int idCV;
        private int numeroFacture;
        private float prixTotal;
        private float prixNet;


        public int lastInvoiceId { get; private set; }



        public int IDProduit { get; set; }
        public string NomProduit { get; set; }
        public static class Place
        {
            public static int id { get; set; }

        }


        public frm_vents(int idCV, string nom, string tel, string cin)


        {
            InitializeComponent();
            this.nom = nom;
            this.tel = tel;
            this.cin = cin;
            txtnv.Text = nom;
            txttv.Text = tel;
            txtcinv.Text = cin;
            this.idCV = idCV;
            txtidv.Text = NumeroActuel.ToString();



            // Incrémenter le numéro actuel pour la prochaine entrée
            NumeroActuel = GetLastInvoiceIdFromDatabase() + 1;

            txtidv.Text = NumeroActuel.ToString();

            RemplirComboBoxProduits();

            RemplirComboBoxProduits();// Appel de la méthode pour remplir le ComboBox avec les produits



        }


        private int GetLastInvoiceIdFromDatabase()
        {
            int lastInvoiceId = 0;
            try
            {
                string query = "SELECT MAX(facture_id) FROM ventes";
                using (MySqlConnection connection = new MySqlConnection(connexion.cnx.ConnectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        var result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            lastInvoiceId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération du dernier numéro de facture depuis la base de données : " + ex.Message);
            }
            return lastInvoiceId;
        }



        public frm_vents(string nomPlace)
        {
            PlaceManager.NomPlace = nomPlace;
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AfficherDonneesVent()
        {
            try
            {
                // Créez une instance de la classe Vents
                Vents vents = new Vents();

                // Appelez la méthode AfficherVent à partir de l'instance vents pour récupérer les données des ventes pour un client spécifique
                DataTable dataTableVentes = vents.AfficherVent(this.idCV, numeroFacture);

                // Liez le DataTable à votre contrôle DataGridView pour afficher les données des ventes
                tableproduits.DataSource = dataTableVentes;

                // Vérifiez si la colonne "idvent" existe dans votre DataGridView
                if (tableproduits.Columns.Contains("idvent"))
                {
                    // Rendez la colonne "idvent" invisible dans votre DataGridView
                    tableproduits.Columns["idvent"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'affichage des données des ventes : " + ex.Message);
            }
        }






        private void RemplirComboBoxProduits()
        {
            Vents vents = new Vents();
            DataTable produits = vents.AfficherProduits(PlaceManager.NomPlace);

            // Vérifier si le DataTable contient des données
            if (produits.Rows.Count > 0)
            {
                // Créer une liste de produits
                List<Produit> listeProduits = new List<Produit>();

                // Parcourir les lignes du DataTable et ajouter des produits à la liste
                foreach (DataRow row in produits.Rows)
                {
                    int idProduit = Convert.ToInt32(row["IDProduit"]);
                    string nomProduit = row["NomProduit"].ToString();
                    Produit produit = new Produit(idProduit, nomProduit);
                    listeProduits.Add(produit);
                }

                // Lier la liste de produits au ComboBox
                boxpro.DataSource = listeProduits;
                boxpro.DisplayMember = "NomProduit";
                boxpro.ValueMember = "IDProduit"; // Si vous avez besoin d'accéder à l'ID du produit sélectionné
            }
            else
            {
                MessageBox.Show("Aucun produit trouvé.");
            }
        }
        public class Produit
        {
            public int IDProduit { get; set; }
            public string NomProduit { get; set; }

            public Produit(int idProduit, string nomProduit)
            {
                IDProduit = idProduit;
                NomProduit = nomProduit;
            }

            public override string ToString()
            {
                return NomProduit;
            }
        }



        private void AjouteVents_Click(object sender, EventArgs e)
        {

            try
            {
                // Récupérer l'ID du produit sélectionné dans le ComboBox
                int idProduit = (int)boxpro.SelectedValue;

                // Récupérer l'ID du client depuis la classe statique place
                int idClient = Global.TxtIdValue;

                // Utiliser la date actuelle
                DateTime date = DateTime.Now;

                // Récupérer la quantité depuis le champ txtQuantite
                float quantite;
                if (float.TryParse(txtqv.Text, out quantite))
                {
                    // Récupérer le prix unitaire de KG depuis le champ txtprix
                    float prixUnitaire;
                    if (float.TryParse(txtprix.Text, out prixUnitaire))
                    {
                        // Calculer le prix total
                         prixTotal = quantite * prixUnitaire;

                        // Récupérer le numéro actuel depuis le champ txtidv
                        numeroFacture = int.Parse(txtidv.Text);

                        // Instancier un objet Vents et appeler la méthode AjouterVent avec les valeurs récupérées
                        Vents vents = new Vents();
                        vents.AjouterVent(idProduit, idClient, this.idCV, date, quantite, numeroFacture, prixUnitaire, prixTotal);
                    }
                    else
                    {
                        MessageBox.Show("Veuillez entrer un prix valide.");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez entrer une quantité valide.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la vente : " + ex.Message);
            }
            ActualiserTableauVent(this.idCV, numeroFacture); // Utilisez la même valeur de numeroFacture
            vider();
            CalculateAndDisplayPriceNet();


        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_vents_Load(object sender, EventArgs e)
        {
            // Supposons que vous avez une variable ou une propriété contenant l'IDClient à afficher
            idClient = Global.TxtIdValue; // Obtenez l'IDClient à partir de quelque part

            // Appelez la méthode AfficherDonneesVent avec l'IDClient approprié
            AfficherDonneesVent();


            // Appelez la méthode ActualiserTableauVent avec l'ID_CV approprié
            ActualiserTableauVent(this.idCV, numeroFacture);
        }
        private void ActualiserTableauVent(int idCV, int numeroFacture) // Ajoutez numeroFacture en paramètre
        {
            Vents vents = new Vents();

            DataTable dataTableVentes = vents.AfficherVent(this.idCV, numeroFacture); // Utilisez la même valeur de numeroFacture

            tableproduits.DataSource = dataTableVentes;
        }

        private void tableproduits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifiez si la ligne sélectionnée est valide et qu'elle n'est pas l'en-tête de colonne
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = tableproduits.Rows[e.RowIndex];

                // Récupérez les données de la ligne sélectionnée
                int idProduit = Convert.ToInt32(row.Cells["idvent"].Value);
                string nomProduit = Convert.ToString(row.Cells["Nom Produit"].Value);
                float prix = Convert.ToSingle(row.Cells["Prix (Kg) /DH"].Value);
                float quantite = Convert.ToSingle(row.Cells["qte"].Value);

                // Remplissez les champs de texte et le ComboBox avec les données récupérées
                boxpro.Text = nomProduit; // Sélectionnez le produit dans le ComboBox
                txtprix.Text = prix.ToString();
                txtqv.Text = quantite.ToString();
            }
        }
    
        

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            // Vérifiez si une ligne est sélectionnée
            if (tableproduits.SelectedRows.Count > 0)
            {
                // Récupérez l'ID de la vente associée à la ligne sélectionnée
                int idVente = Convert.ToInt32(tableproduits.SelectedRows[0].Cells["idvent"].Value);

                // Appelez une méthode pour supprimer la vente de la base de données
                Vents vents = new Vents();
                vents.SupprimerVente(idVente);

                // Actualisez le DataGridView après la suppression
                ActualiserTableauVent(this.idCV, numeroFacture);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
            }
            vider();
            CalculateAndDisplayPriceNet();

        }

        private void modifier_Click(object sender, EventArgs e)
        {
            // Vérifiez si une ligne est sélectionnée dans le DataGridView
            if (tableproduits.SelectedRows.Count > 0)
            {
                // Récupérez l'ID de la vente associée à la ligne sélectionnée
                int idVente = Convert.ToInt32(tableproduits.SelectedRows[0].Cells["idvent"].Value);

                // Récupérez les nouvelles valeurs des champs de texte et du ComboBox
                int idProduit = (int)boxpro.SelectedValue;
                float prix = float.Parse(txtprix.Text);
                float quantite = float.Parse(txtqv.Text);

                // Calculer le prix total en multipliant le prix par la quantité
                float prixTotal = prix * quantite;

                // Mettez à jour les valeurs de la ligne sélectionnée dans le DataGridView
                tableproduits.SelectedRows[0].Cells["Nom Produit"].Value = boxpro.Text;
                tableproduits.SelectedRows[0].Cells["Prix /DH"].Value = prix;
                tableproduits.SelectedRows[0].Cells["qte"].Value = quantite;

                // Appelez la méthode ModifierVente pour mettre à jour les données dans la base de données
                Vents vents = new Vents();
                vents.ModifierVente(idVente, idProduit, idClient, idCV, DateTime.Now, quantite, prixTotal);

                MessageBox.Show("Vente modifiée avec succès.");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à modifier.");
            }
            vider();
            CalculateAndDisplayPriceNet();

        }
        private void vider()
        {
            txtprix.Text = "";
            txtqv.Text = "";
        }
        private void txtpn_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void CalculateAndDisplayPriceNet()
        {
            prixNet = 0;

            // Parcourir toutes les lignes du DataGridView pour calculer le prix total
            foreach (DataGridViewRow row in tableproduits.Rows)
            {
                float prixLigne;
                string prixCell = row.Cells["Prix (Kg) /DH"].Value?.ToString(); // Vérifier si la valeur de la cellule est null
                if (!string.IsNullOrEmpty(prixCell) && float.TryParse(prixCell, out prixLigne))
                {
                    // Ajouter le prix de chaque ligne à prixNet
                    float quantite;
                    if (float.TryParse(row.Cells["qte"].Value.ToString(), out quantite))
                    {
                        prixNet += prixLigne * quantite;
                    }
                }
            }
            txtpn.Text = prixNet.ToString();
        }
        private void btn_paye_Click(object sender, EventArgs e)
        {
            AfficherRapportVentes(idCV,numeroFacture);
        }
        private void AfficherRapportVentes(int CV_id, int facture_id)
        {
            // Récupérer les données des ventes en utilisant la méthode AfficherVent
            Vents v=new Vents();
            DataTable dataTableVentes = v.AfficherVent(CV_id, facture_id); // Appeler la méthode AfficherVent depuis l'instance vents

            // Vérifier si le DataTable contient des lignes
            if (dataTableVentes.Rows.Count == 0)
            {
                MessageBox.Show("Veuillez ajouter des ventes avant de générer le rapport.", "Aucune vente à afficher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Créer le contenu du rapport
            StringBuilder rapportBuilder = new StringBuilder();
            rapportBuilder.AppendLine("Rapport des ventes :");
            rapportBuilder.AppendLine("-----------------------");

            // Parcourir toutes les lignes du DataTable pour ajouter les données de chaque vente dans le rapport
            foreach (DataRow row in dataTableVentes.Rows)
            {
                // Vérifier si la colonne "Nom Produit" existe et si sa valeur n'est pas null
                if (dataTableVentes.Columns.Contains("Nom Produit") && row["Nom Produit"] != DBNull.Value)
                {
                    // Récupérer les valeurs des autres colonnes nécessaires pour le rapport
                    string nomProduit = row["Nom Produit"].ToString();
                    float prix = Convert.ToSingle(row["Prix (Kg) /DH"]);
                    float quantite = Convert.ToSingle(row["QTE"]);
                    float prixTotal = Convert.ToSingle(row["Prix /DH"]);

                    // Ajouter les données de la vente dans le rapport
                    rapportBuilder.AppendLine($"Produit : {nomProduit} | Prix : {prix} DH | Quantité : {quantite} | Prix Total : {prixTotal} DH");
                }
                else
                {
                    MessageBox.Show("La ligne sélectionnée ne contient pas de valeur pour la colonne 'Nom Produit'.", "Erreur de données", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Ajouter le prix total à la fin du rapport
            rapportBuilder.AppendLine("-----------------------");
            rapportBuilder.AppendLine($"Prix total : {prixNet} DH");

            // Afficher le rapport dans une nouvelle fenêtre
            MessageBox.Show(rapportBuilder.ToString(), "Rapport des ventes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtqv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtprix_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprix_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifier si la touche pressée n'est pas un chiffre et n'est pas une touche de contrôle
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Annuler la pression de la touche
                e.Handled = true;
            }
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}