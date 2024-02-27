using GESTION_VENDEURS.classe;
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
    public partial class Form2 : Form
    {
        public Form2()
        {   
            InitializeComponent();

        }   

        public static class PlaceManager
        {
            public static string NomPlace { get; set; }
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            // Check if the textbox is empty
            if (string.IsNullOrEmpty(place.Text))
            {
                MessageBox.Show("Veuillez remplir le champ de la place.", "Champ Vide", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Exit the method since the textbox is empty
            }

            // Continue with your existing logic
            string nomPlace = place.Text;
            PlaceManager.NomPlace = nomPlace;
            Form1 placeInstance = new Form1();
            string etatPlace = Place.VerifierDisponibilite();

            if (etatPlace == "Occupee")
            {
                MessageBox.Show("La place est occupée.", "Place Occupée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Passer le nom de place au tableau de bord lors de sa création
                Form1 d = new Form1();
                d.Show(); 
                this.Hide();

            }
            else if (etatPlace == "Disponible")
            {
                MessageBox.Show("La place est vide.", "Place Vide", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur lors de la vérification de la disponibilité de la place.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
