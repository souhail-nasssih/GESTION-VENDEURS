using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GESTION_VENDEURS
{
    public partial class clients : Form
    {

        private int idClient = Global.TxtIdValue;

        private Clients clientsinst; // Instance de votre classe Clients

        public clients() 
        {
            InitializeComponent();
            clientsinst = new Clients();  // Initialisez votre instance de classe Clients

        }


        private void ActualiserDataGridView()
        {
            // Mettre à jour le DataSource du DataGridView avec les données de l'employé
            tableclient.DataSource = clientsinst.AfficherClients(); // Utilisez l'instance de votre classe Clients
            tableclient.Refresh();
        }

        private void clients_Load(object sender, EventArgs e)
        {
            ActualiserDataGridView();


            tableclient.CellClick += tableclient_CellContentClick; // Correction ici


        }





        private void tableclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Récupérer les données de la ligne sélectionnée dans le DataGridView
                DataGridViewRow row = tableclient.Rows[e.RowIndex];

                // Remplir les champs du formulaire avec les données de la ligne sélectionnée
                txtnc.Text = row.Cells["nom_client"].Value.ToString();
                txttc.Text = row.Cells["tel"].Value.ToString();
                txtcinc.Text = row.Cells["cin"].Value.ToString();
            }
        }


        private void gunaAdvenceButton2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnc.Text) || string.IsNullOrWhiteSpace(txttc.Text) || string.IsNullOrWhiteSpace(txtcinc.Text))
            {
                MessageBox.Show("Tous les champs doivent être remplis.");
            }
            else
            {

                string nom = txtnc.Text;
                string tel = txttc.Text;
                string cin = txtcinc.Text;

                // Vérifier si le client existe déjà dans la base de données en fonction du CIN
                if (clientsinst.ClientExiste(cin))
                {
                    MessageBox.Show("Ce client existe déjà.");
                }
                else
                {
                    // Si le client n'existe pas, ajoutez-le à la base de données
                    connexion.OpenConnection();
                    int idClient = Global.TxtIdValue;

                    Clients emp = new Clients(nom, tel, cin);
                    clientsinst.AjouterClient(nom, tel, cin, idClient);
                    ActualiserDataGridView();
                }
            }
        }
        private void gunaAdvenceButton5_Click_1(object sender, EventArgs e)
        {
            // Récupérer les données de l'employé à partir des champs du formulaire       
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (tableclient.CurrentRow != null)
            {
                // Vérifier si une ligne est sélectionnée dans le DataGridView
                if (tableclient.CurrentRow != null)
                {
                    // Récupérer l'ID de l'employé à partir de la ligne sélectionnée
                    int id_CV = Convert.ToInt32(tableclient.CurrentRow.Cells["id_CV"].Value);

                    // Récupérer les valeurs mises à jour à partir des champs de texte
                    string nom = txtnc.Text;
                    string tel = txttc.Text;
                    string cin = txtcinc.Text;

                    // Appeler la méthode de modification de l'employé en utilisant les nouvelles valeurs
                    clientsinst.ModifierClient(id_CV, nom, tel, cin);

                    // Actualiser le DataGridView pour afficher les changements
                    ActualiserDataGridView();
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un client à modifier.");
                }
            }
            }

        private void gunaAdvenceButton4_Click_1(object sender, EventArgs e)
        {
            if (tableclient.SelectedRows.Count > 0)
            {
                int id_CV = Convert.ToInt32(tableclient.CurrentRow.Cells["id_CV"].Value);
                clientsinst.SupprimerClient(id_CV); // Utilisez l'instance de votre classe Clients
                ActualiserDataGridView();
            }
        }

        private void gunaAdvenceButton3_Click_1(object sender, EventArgs e)
        {
            txtnc.Text = ""; // Vider le champ pour le nom
            txttc.Text = ""; // Vider le champ pour le prénom
            txtcinc.Text = ""; // Vider le champ pour l'adresse
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            // Vérifier d'abord si une ligne est sélectionnée dans le DataGridView
            if (tableclient.CurrentRow != null)
            {
                // Récupérer les valeurs de la ligne sélectionnée
                DataGridViewRow row = tableclient.CurrentRow;

                // Récupérer les valeurs de id_cv, nom, tel et cin
                int id_cv = Convert.ToInt32(row.Cells["id_CV"].Value);
                string nom = row.Cells["nom_client"].Value.ToString();
                string tel = row.Cells["tel"].Value.ToString();
                string cin = row.Cells["cin"].Value.ToString();

                // Créer une nouvelle instance de la forme frm_vents
                frm_vents p = new frm_vents(id_cv, nom, tel, cin);

                // Ajouter la forme au panneau pnlC
                p.TopLevel = false;
                this.Controls.Add(p);
                p.BringToFront();
                p.Show();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client.");
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
