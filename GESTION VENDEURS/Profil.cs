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
    public partial class Profil : Form
    {
        public Profil(string nomPlace)
        {
            InitializeComponent();
            placen.Text = nomPlace.ToUpper();

            // Créer une instance de la classe Profil avec le nom de place
            GESTION_VENDEURS.classe.Profil profilVendeur = new GESTION_VENDEURS.classe.Profil(nomPlace, this);

            // Récupérer les informations des vendeurs
            List<string> informationsVendeurs = profilVendeur.Info();

            // Vérifier s'il y a au moins un vendeur associé à cette place
            if (informationsVendeurs.Count > 0)
            {
                // Afficher les informations du premier vendeur dans les TextBox et le contrôle de texte appropriés
                AfficherInfosVendeur(informationsVendeurs[0]);

                // Parcourir les informations des vendeurs pour afficher les produits dans le DataGridView
                foreach (string info in informationsVendeurs)
                {
                    AjouterProduitDansTableau(info);
                }
            }
            else
            {
                MessageBox.Show("Aucune information sur les vendeurs pour cette place.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AfficherInfosVendeur(string info)
        {
            // Diviser les informations du vendeur en parties séparées
            string[] infos = info.Split(',');

            // Extraire le nom, l'adresse, le statut du vendeur, le produit et la quantité de la première ligne d'informations
            string nomVendeur = infos[0].Split(':')[1].Trim();
            string adresseVendeur = infos[1].Split(':')[1].Trim();
            string telVendeur = infos[2].Split(':')[1].Trim();
            string cinVendeur = infos[3].Split(':')[1].Trim();

            // Afficher les informations du vendeur dans les TextBox et le contrôle de texte appropriés
            txtn.Text = nomVendeur;
            txta.Text = adresseVendeur;
            txtt.Text = telVendeur;
            txtcin.Text = cinVendeur;
        }

        private void AjouterProduitDansTableau(string info)
        {
            // Diviser les informations du vendeur en parties séparées
            string[] infos = info.Split(',');

            // Extraire le produit et sa quantité
            string produit = infos[4].Split(':')[1].Trim();
            string qte = infos[5].Split(':')[1].Trim();

            // Ajouter le produit et sa quantité dans le DataGridView
            tableproduits.Rows.Add(produit, qte);
        }

    }
}
