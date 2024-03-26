using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Crud
{
    public partial class Form1 : Form
    {
        DBConnection laConnexion = new DBConnection();

        public int Id { get; private set; }
        public string Nom { get; private set; }
        public string Prenom { get; private set; }

        public Form1()
        {
            InitializeComponent();

        }

        /*private void btnConnex_Click(object sender, EventArgs e)
        {
            
            laConnexion.Server = "localhost";
            laConnexion.DatabaseName = "sucrerie";
            laConnexion.UserName = "root";
            laConnexion.Password = Crypto.Decrypt("+fcSDyxHBFw8BqLnszLExg==");
            laConnexion.Port = 3306;

            if (laConnexion.IsConnect())
            {
                TBResult.Text = "Connecté avec succès";
            }
            else
            {
                TBResult.Text = "Problème de connexion";
            }
        }*/

        private void btnDisconn_Click(object sender, EventArgs e)
        {
            laConnexion.Close();
            TBResult.Text = "Deconnecté avec succès";
        }

        private void btnPointInterr_Click(object sender, EventArgs e)
        {
            FormUtilitaire formUtil = new FormUtilitaire();
            formUtil.Show();
        }

        private void btnRemplissage_Click(object sender, EventArgs e)
        {
            if (laConnexion.IsConnect()) {
                string query = "SELECT idu, nom, prenom, statut, identifiant FROM utilisateurs";
                var cmd = new MySqlCommand(query, laConnexion.Connection);
                var reader = cmd.ExecuteReader();
                
                List<Utilisateur> contacts = new List<Utilisateur>();
                while(reader.Read())
                {
                    string someStringFromColumnOne = reader.GetString(1);
                    string someStringFromColumnThree = reader.GetString(3);
                    RTBClients.AppendText(someStringFromColumnOne + "," + someStringFromColumnThree + "\n");
                    Utilisateur contact = new Utilisateur()
                    {
                        Idu = (string)reader["idu"],
                        Nom = (string)reader["nom"],
                        Prenom = (string)reader["prenom"],
                        Statut = (string)reader["statut"],
                        Identifiant = (string)reader["identifiant"],
                        Mdp = (string)reader["mdp"]
                    };
                    contacts.Add(contact);
                }
                dataGridView1.DataSource = contacts;
                dataGridView1.Columns[0].Visible = false;
                reader.Close();
                labelCount.Text = contacts.Count.ToString();
            }
        }

        /*private void btnOuvrir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                Client selectedClient = (Client)row.DataBoundItem;
                Form2 formClient = new Form2(selectedClient);
                formClient.Show();
            }    
        }*/

        /*private void btnOuvrir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer la ligne sélectionnée dans le DataGridView
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                int userId = Convert.ToInt32(row.Cells["Idu"].Value); // Assurez-vous de remplacer "Idu" par le nom correct de la colonne ID dans votre DataGridView

                // Connexion à la base de données MySQL
                string connectionString = "Server=localhost;Database=sucrerie;Uid=root;Pwd=Password123;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Exécuter une requête SQL pour récupérer les données de l'utilisateur
                    string query = "SELECT * FROM utilisateurs WHERE idu = @UserId"; // Assurez-vous d'ajuster la requête en fonction de votre schéma de base de données
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Créer un objet Utilisateur à partir des données de la base de données
                                Utilisateur selectedUtilisateur = new Utilisateur
                                {
                                    Idu = reader.GetString("idu"),
                                    Nom = reader.GetString("nom"),
                                    Prenom = reader.GetString("prenom"),
                                    Statut = reader.GetString("statut"),
                                    Identifiant = reader.GetString("identifiant"),
                                    Mdp = reader.GetString("mdp"),
                                };

                                Form2 formUtilisateur = new Form2(selectedUtilisateur);
                                formUtilisateur.Show();
                            }
                        }
                    }
                }
            }
        }*/

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        /*private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];//ligne
                Utilisateur selectedUser = (Utilisateur)row.DataBoundItem;// renvoi une instance de la classe row donc on la retip en un client

                ConfirmationSuppressionUser ConfirmeSuppUser = new ConfirmationSuppressionUser(selectedUser);
                ConfirmeSuppUser.ShowDialog();
            }
        }*/

        /*private void btnAffich_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer la ligne sélectionnée dans le DataGridView
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Assurez-vous que votre classe Client correspond à votre structure de base de données
                // Supposons que votre classe Client ait des propriétés comme Id, Nom, Prenom, etc.
                int idUser = Convert.ToInt32(row.Cells["idu"].Value); // Assurez-vous de remplacer "Id" par le nom correct de la colonne ID dans votre DataGridView

                // Établir une connexion à la base de données MySQL
                string connectionString = "Server=localhost;Database=sucrerie;Uid=root;Pwd=Password123;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Exécuter une requête SQL pour récupérer les données du client
                    string query = "SELECT * FROM utilisateur"; // Assurez-vous d'ajuster la requête en fonction de votre schéma de base de données
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idu", idUser);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Créer un objet Client à partir des données de la base de données
                                Utilisateur selectedClient = new Utilisateur();
                                {
                                    Id = reader.GetInt32("Id");
                                    Nom = reader.GetString("Nom");
                                    Prenom = reader.GetString("Prenom");
                                    // Ajoutez d'autres propriétés en fonction de votre schéma
                                };

                                // Afficher le formulaire avec les données du client
                                Form2 formUser = new Form2(selectedClient);
                                formUser.Show();
                            }
                        }
                    }
                }
            }
        }*/

        private void btnIdent_Click(object sender, EventArgs e)
        {
            Form FormIdent = new Form();
            FormIdent.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (laConnexion.IsConnect())
            {
                string query = "SELECT idu, nom, prenom, statut, identifiant FROM utilisateurs";
                var cmd = new MySqlCommand(query, laConnexion.Connection);
                var reader = cmd.ExecuteReader();

                List<Utilisateur> contacts = new List<Utilisateur>();
                while (reader.Read())
                {
                    string someStringFromColumnOne = reader.GetString(1);
                    string someStringFromColumnThree = reader.GetString(3);
                    RTBClients.AppendText(someStringFromColumnOne + "," + someStringFromColumnThree + "\n");
                    Utilisateur contact = new Utilisateur()
                    {
                        Idu = (string)reader["idu"],
                        Nom = (string)reader["nom"],
                        Prenom = (string)reader["prenom"],
                        Statut = (string)reader["statut"],
                        Identifiant = (string)reader["identifiant"],
                        Mdp = (string)reader["mdp"]
                    };
                    contacts.Add(contact);
                }
                dataGridView1.DataSource = contacts;
                dataGridView1.Columns[0].Visible = false;
                reader.Close();
                labelCount.Text = contacts.Count.ToString();
            }
        }
    }
}
