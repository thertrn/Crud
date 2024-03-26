using System;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public class Utilisateur
    {
        public string Idu { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Statut { get; set; }
        public string Identifiant { get; set; }
        public string Mdp { get; set; }
        /*public int ContactID {  get; set; }
        public string ContactNom {  get; set; }
        public string ContactAdresse { get; set; }
        public string ContactVille { get; set; }

        /*public void Save(DBConnection dBConnection, MySqlDataReader theReader)
        {
            if (ContactID > 0)
                UpdateContact(dBConnection, theReader);
            else
                AddContact(dBConnection, theReader);
        }*/


        public void Delete(DBConnection dBConnection, MySqlDataReader theReader)
        {
            try
            {
                String sqlString = "Delete from client where code_c = ?code_c";

                sqlString = Tools.PrepareLigne(sqlString, "?code_c", Tools.PrepareChamp(Idu.ToString(), "Nombre"));
                var cmd = new MySqlCommand(sqlString, dBConnection.Connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("Erreur n° " + ex.Number + " : " + ex.Message);
            }
        }

        public void Save()
        {

        }
    }

    
}
