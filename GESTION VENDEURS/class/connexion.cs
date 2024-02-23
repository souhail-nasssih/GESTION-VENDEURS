using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

internal class connexion
{

    public static MySqlConnection cnx = new MySqlConnection("server=localhost;database=appmarcher;uid=root;password=");
    public static DataTable dataTable = new DataTable();



    public static void OpenConnection()
    {
        try
        {
            if (cnx.State == System.Data.ConnectionState.Closed)
            {
                cnx.Open();
                Console.WriteLine("Connexion à la base de données ouverte avec succès.");
                MessageBox.Show("Connexion à la base de données ouverte avec succès.", "Gestion Restaurant");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erreur lors de l'ouverture de la connexion : " + ex.Message);
            MessageBox.Show("Erreur lors de l'ouverture de la connexion : " + ex.Message, "Gestion Restaurant");
        }
    }

    // Méthode pour fermer la connexion
    public static void CloseConnection()
    {
        try
        {
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
                Console.WriteLine("Connexion à la base de données fermée avec succès.");
                MessageBox.Show("Connexion à la base de données fermer avec succès.", "Gestion Restaurant");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erreur lors de la fermeture de la connexion : " + ex.Message);
            MessageBox.Show("Connexion à la base de données fermer avec succès.", "Gestion Restaurant");
        }
    }
}