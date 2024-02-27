using System;
using System.Data;
using System.Windows.Forms;
using GESTION_VENDEURS.classe;
using MySql.Data.MySqlClient;

namespace GESTION_VENDEURS
{

    internal class Clients
    {

      

        public Clients(string nom_client, string tel, string cin, string cinVendeur)
        {
            this.nom_client = nom_client;
            this.tel = tel;
            this.cin = cin;
        }


        public Clients(string nom_client, string tel, string cin, string cinVendeur, int idClient) 
        {
            this.idClient = idClient;
        }






        private int idClient = Global.TxtIdValue;


        private string nom_client;
        private string tel;
        private string cin;


        public Clients(string nom_client, string tel, string cin)
        {
            this.nom_client = nom_client;
            this.tel = tel;
            this.cin = cin;
        }

        public Clients()
        {

        }

        public void AjouterClient(string nom_client, string tel, string cin, int idClient)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connexion.cnx.ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO clients_vendeur (nom_client, tel, cin, id_client) VALUES (@nom_client, @tel, @cin, @idClient)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nom_client", nom_client);
                        command.Parameters.AddWithValue("@tel", tel);
                        command.Parameters.AddWithValue("@cin", cin);
                        command.Parameters.AddWithValue("@idClient", idClient); // Utilisez le paramètre idClient passé en argument
                        command.ExecuteNonQuery();

                        MessageBox.Show("Client ajouté avec succès");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du client : " + ex.Message);
            }
        }

        public DataTable AfficherClients()
        {
            MessageBox.Show("Valeur de Global.cinVendeur : " + Global.cinVendeur);

            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connexion.cnx.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT c.nom_client, c.cin,c.tel,id_CV FROM clients_vendeur c JOIN clients cv ON cv.IDClient = c.id_client WHERE cv.N_identif = @cinVendeur ";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cinVendeur", Global.cinVendeur);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des données des clients : " + ex.Message);
            }

            return dataTable;
        }

        public void SupprimerClient(int idClient)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connexion.cnx.ConnectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM clients_vendeur WHERE id_CV = @id_CV";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_CV", idClient);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Client supprimé avec succès");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression du client : " + ex.Message);
            }
        }

        public void ModifierClient(int id_CV, string nom, string tel, string cin)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connexion.cnx.ConnectionString))
                {
                    connection.Open();
                    string query = "UPDATE clients_vendeur SET nom_client = @nom_client, tel = @tel, cin = @cin WHERE id_CV = @id_CV";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_CV", id_CV);
                        command.Parameters.AddWithValue("@nom_client", nom);
                        command.Parameters.AddWithValue("@tel", tel);
                        command.Parameters.AddWithValue("@cin", cin);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Client modifié avec succès");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification du client : " + ex.Message);
            }
        }
        public bool ClientExiste(string cin)
        {
            bool existe = false;

            try
            {
                string query = "SELECT COUNT(*) FROM clients_vendeur WHERE cin = @cin";
                using (MySqlCommand command = new MySqlCommand(query, connexion.cnx))
                {
                    command.Parameters.AddWithValue("@cin", cin);
                    connexion.OpenConnection();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    existe = count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la vérification de l'existence du client : " + ex.Message);
            }
            finally
            {
                connexion.CloseConnection();
            }

            return existe;
        }

    }
}
