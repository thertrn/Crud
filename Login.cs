using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class Login : Form
    {
        DBConnection Verbin = new DBConnection();
        Utilisateur leUser;

        public Login()
        {
            InitializeComponent();
            this.leUser = leUser;
            textBoxLogin.Text = "";
            textBoxMdP.Text = "";
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxMdP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Verbin.Server = "localhost";
            Verbin.DatabaseName = "sucrerie";
            Verbin.UserName = "root";
            Verbin.Password = Crypto.Decrypt("+fcSDyxHBFw8BqLnszLExg==");
            Verbin.Port = 3306;

            if (Verbin.IsConnect())
            {
                TBResult.Text = "Connecté avec succès";
                Utilisateur utilisateurConnecte = new Utilisateur(); // Remplacez cela par votre méthode de récupération d'utilisateur
                Form1 FormPrinci = new Form1();
                FormPrinci.ShowDialog();
                if (utilisateurConnecte != null && utilisateurConnecte.Statut == "admin")
                {
                    // Remplissez le DataGridView dans Form1 avec les données appropriées
                    string query = "SELECT idu, nom, prenom, identifiant, statut FROM utilisateurs";
                    var cmd = new MySqlCommand(query, Verbin.Connection);
                    var reader = cmd.ExecuteReader();

                    List<Utilisateur> contacts = new List<Utilisateur>();
                    while (reader.Read())
                    {
                        string someStringFromColumnOne = reader.GetString(1);
                        string someStringFromColumnThree = reader.GetString(3);
                        //FormPrinci.RTBClients.AppendText(someStringFromColumnOne + "," + someStringFromColumnThree + "\n");
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
                    //FormPrinci.dataGridView1.DataSource = contacts;
                    //FormPrinci.dataGridView1.Columns[0].Visible = false;
                    reader.Close();
                    //labelCount.Text = contacts.Count.ToString();
                }
            }
            else
            {
                TBResult.Text = "Problème de connexion";
            }
        }
    }
}
