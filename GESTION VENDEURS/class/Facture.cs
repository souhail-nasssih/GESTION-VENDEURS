using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GESTION_VENDEURS
{
    internal static class Facture
    {
        public static DataTable Affichpro()
        {

            DataTable dataTable = new DataTable();

            try
            {
                string query = @"
                   SELECT 
                       c.nom_client AS 'Nom clients', 
                       c.cin AS 'CIN', 
                       v.date_vent AS 'Date vente', 
                       v.facture_id AS 'ID facture', 
                        
                       pc.nomplace AS 'Nom place' 
                   FROM 
                       clients_vendeur c
                   JOIN 
                       ventes v ON v.CV_id = c.id_CV
                   JOIN 
                       historiqueplaces p ON p.IDClient = v.client_id
                   JOIN 
                       places pc ON pc.IDPlace = p.IDPlace
                   JOIN 
                       clients vc ON v.client_id = vc.idclient 
                   WHERE 
                       vc.N_identif = @cinVendeur
                   GROUP BY 
                       c.nom_client, c.cin, v.date_vent, v.facture_id, vc.idclient, pc.nomplace
";

                using (MySqlConnection connection = new MySqlConnection(connexion.cnx.ConnectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open(); // Ouvrir la connexion
                        command.Parameters.AddWithValue("@cinVendeur", Global.cinVendeur);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Ajouter des colonnes au DataTable
                            dataTable.Columns.Add("Nom clients");
                            dataTable.Columns.Add("CIN");
                            dataTable.Columns.Add("Date vente");
                            dataTable.Columns.Add("ID facture");
                          //  dataTable.Columns.Add("ID client");
                            dataTable.Columns.Add("Nom place");

                            // Charger les données dans le DataTable à partir du lecteur
                            while (reader.Read())
                            {

                                DataRow row = dataTable.NewRow();
                                row["Nom clients"] = reader["Nom clients"];
                                row["CIN"] = reader["CIN"];

                                // Convertir la date_vent en DateTime
                                DateTime dateVent = Convert.ToDateTime(reader["Date vente"]);
                                // Extraire uniquement les informations de jour, mois et année
                                string dateSansHeureMinute = dateVent.ToShortDateString();
                                row["Date vente"] = dateSansHeureMinute;

                                row["ID facture"] = reader["ID facture"];
                               // row["ID client"] = reader["ID client"];
                                row["Nom place"] = reader["Nom place"];
                                dataTable.Rows.Add(row);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération des données des clients : " + ex.Message);
            }

            return dataTable;
        }
    }
}
