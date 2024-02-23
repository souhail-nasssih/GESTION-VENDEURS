using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace GESTION_VENDEURS.classe
{
    internal class Profil
    {
        private string nomPlace;
        private GESTION_VENDEURS.Profil formProfil;
        public Profil(string nomPlace, GESTION_VENDEURS.Profil formProfil) // Ajoutez les arguments nécessaires
        {
            this.nomPlace = nomPlace;
            this.formProfil = formProfil;
        }

        public List<string> Info()
        {
            List<string> informationsVendeurs = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(connexion.cnx.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT c.NomClient, c.AdresseClient, c.tel, c.N_identif, pr.NomProduit, f.QuantiteEntrer
                            FROM fromentrer f
                            JOIN clients c ON f.IDClient = c.IDClient
                            JOIN produits pr ON f.IDProduit = pr.IDProduit
                            JOIN places p ON f.IDPlace = p.IDPlace
                            WHERE p.NomPlace = @NomPlace
                            AND p.EtatPlace = 'Occupee'
                            AND c.IDClient = (
                                SELECT IDClient 
                                FROM fromentrer 
                                WHERE IDPlace = p.IDPlace 
                                ORDER BY IDEntrer DESC 
                                LIMIT 1
                            );";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NomPlace", nomPlace);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nomVendeur = reader["NomClient"].ToString();
                                string adresseVendeur = reader["AdresseClient"].ToString();
                                string telVendeur = reader["tel"].ToString();
                                string cinVendeur = reader["N_identif"].ToString();
                                string nomprouit = reader["NomProduit"].ToString();
                                string qte = reader["QuantiteEntrer"].ToString();

                                string infoVendeur = $"Nom vendeur: {nomVendeur}, Adresse: {adresseVendeur}, Tel: {telVendeur},CIN : {cinVendeur},Nom Produit : {nomprouit},Qte : {qte} ";
                                informationsVendeurs.Add(infoVendeur);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des informations des vendeurs : " + ex.Message);
                }
            }

            return informationsVendeurs;
        }



        // Modifier la fonction Info pour qu'elle retourne une liste de tuples

    }
}
/*public void RemplirTableau(List<string> informationsProduits, DataGridView dataGridView)
                {
                    // Création d'une DataTable pour les données à afficher
                    DataTable dataTable = new DataTable();
                    // Ajout des colonnes à la DataTable
                    dataTable.Columns.Add("NomProduit", typeof(string));
                    dataTable.Columns.Add("QuantiteEntrer", typeof(string));

                    // Ajout des données à la DataTable
                    foreach (string infoProduit in informationsProduits)
                    {
                        string[] infos = infoProduit.Split(':');
                        if (infos.Length >= 2)
                        {
                            DataRow row = dataTable.NewRow();
                            row["NomProduit"] = infos[0].Trim();
                            row["QuantiteEntrer"] = infos[1].Trim();
                            dataTable.Rows.Add(row);
                        }
                    }

                    // Liaison de la DataTable à la DataGridView
                    dataGridView.DataSource = dataTable;
                }*/