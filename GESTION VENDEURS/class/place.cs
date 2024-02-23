using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static GESTION_VENDEURS.Form2;

namespace GESTION_VENDEURS.classe
{
    internal class Place
    {


        public Place(string nomPlace)
        {
            PlaceManager.NomPlace = nomPlace; 
        }

        public static string VerifierDisponibilite()
        {
            using (MySqlConnection connection = new MySqlConnection(connexion.cnx.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT EtatPlace FROM places WHERE NomPlace = @NomPlace";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NomPlace", PlaceManager.NomPlace); 
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Aucun résultat trouvé pour le nom de place : " + PlaceManager.NomPlace);
                            return "Indisponible";
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message);
                    return "Erreur de connexion";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la vérification de la disponibilité de la place : " + ex.Message);
                    return "Erreur";
                }
            }
        }

    }
}

