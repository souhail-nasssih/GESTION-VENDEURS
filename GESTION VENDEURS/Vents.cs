using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GESTION_VENDEURS.classe;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using static GESTION_VENDEURS.Form2;

namespace GESTION_VENDEURS
{
    internal class Vents
    {
        public int IDProduit { get; set; }
        public string NomProduit { get; set; }

        public Vents(string nomPlace)
        {
            PlaceManager.NomPlace = nomPlace;
        }

        private int IDClient;
        public int id_CV;
        private DateTime date;
        private float qte;

        public Vents(int IDProduit, int IDClient, int id_CV, DateTime date, float qte)
        {
            this.IDProduit = IDProduit;
            this.IDClient = IDClient;
            this.id_CV = id_CV;
            this.date = date;
            this.qte = qte;
        }
        public Vents()
        {

        }

        public DataTable AfficherProduits(string nomPlace)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connexion.cnx.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT pr.NomProduit, pr.IDProduit
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
                             )";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NomPlace", nomPlace);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération des données des clients : " + ex.Message);
            }

            return dataTable;
        }

        public void AjouterVent(int IDProduit, int IDClient, int id_CV, DateTime date, float qte , int numeroFacture, float prix, float prixtotal)
        {
            using (MySqlConnection connection = new MySqlConnection(connexion.cnx.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO ventes (produit_id, client_id, CV_id, date_vent, qte, facture_id, prix ,prixtotal) VALUES (@IDProduit, @IDClient, @id_CV, @date, @qte, @facture_id,@prix,@prixtotal)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDProduit", IDProduit);
                        command.Parameters.AddWithValue("@IDClient", IDClient);
                        command.Parameters.AddWithValue("@id_CV", id_CV);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@qte", qte);
                        command.Parameters.AddWithValue("@facture_id", numeroFacture);
                        command.Parameters.AddWithValue("@prix", prix);
                        command.Parameters.AddWithValue("@prixtotal", prixtotal);   
                        command.ExecuteNonQuery();

                        MessageBox.Show("Produits ajouté avec succès");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout du client : " + ex.Message);
                }
            }
        }
        public DataTable AfficherVent(int CV_id, int facture_id)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connexion.cnx.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT v.idvent, v.date_vent as 'Date', v.qte as 'QTE',Prix as 'Prix (Kg) /DH',v.prixtotal as 'Prix /DH', p.NomProduit as 'Nom Produit' FROM ventes v JOIN produits p ON p.IDProduit = v.produit_id WHERE CV_id = @CV_id and facture_id = @facture_id";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CV_id", CV_id);
                        command.Parameters.AddWithValue("@facture_id", facture_id); // Ajout du paramètre facture_id
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des données des ventes : " + ex.Message);
            }

            return dataTable;
        }
        public void SupprimerVente(int idVente)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connexion.cnx.ConnectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM ventes WHERE idvent = @idVente";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idVente", idVente);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("La vente a été supprimée avec succès.");
                        }
                        else
                        {
                            MessageBox.Show("Aucune vente n'a été supprimée.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression de la vente : " + ex.Message);
            }
        }

        public void ModifierVente(int idVente, int IDProduit, int IDClient, int id_CV, DateTime date, float qte, float prix)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connexion.cnx.ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE ventes 
                             SET produit_id = @IDProduit, 
                                 client_id = @IDClient, 
                                 CV_id = @id_CV, 
                                 date_vent = @date, 
                                 qte = @qte, 
                                 prix = @prix
                             WHERE idvent = @idVente";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDProduit", IDProduit);
                        command.Parameters.AddWithValue("@IDClient", IDClient);
                        command.Parameters.AddWithValue("@id_CV", id_CV);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@qte", qte);
                        command.Parameters.AddWithValue("@prix", prix);
                        command.Parameters.AddWithValue("@idVente", idVente);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("La vente a été modifiée avec succès.");
                        }
                        else
                        {
                            MessageBox.Show("Aucune vente n'a été modifiée.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification de la vente : " + ex.Message);
            }
        }





    }
}
