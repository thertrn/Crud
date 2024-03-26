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
    public partial class FormIdent : Form
    {
        Utilisateur LeUserCourant;
        public FormIdent(Utilisateur leUser)
        {
            InitializeComponent();
            LeUserCourant = leUser;
            TBidu.Text = leUser.Idu;
            TBuNom.Text = leUser.Nom;
            TBuPrenom.Text = leUser.Prenom;
            TBuPWD.Text = leUser.Mdp;
            TBuIdent.Text = leUser.Identifiant;
            comboBoxStatut.Text = leUser.Statut;
        }

        private void TBidu_TextChanged(object sender, EventArgs e)
        {
            LeUserCourant.Idu = TBidu.Text;
        }

        private void TBuNom_TextChanged(object sender, EventArgs e)
        {
            LeUserCourant.Nom = TBuNom.Text;
        }

        private void TBuPrenom_TextChanged(object sender, EventArgs e)
        {
            LeUserCourant.Prenom = TBuNom.Text;
        }

        private void comboBoxStatut_SelectedIndexChanged(object sender, EventArgs e)
        {
            LeUserCourant.Statut = comboBoxStatut.Text;
        }

        private void TBuIdent_TextChanged(object sender, EventArgs e)
        {
            LeUserCourant.Identifiant = TBuIdent.Text;
        }

        private void TBuPWD_TextChanged(object sender, EventArgs e)
        {
            LeUserCourant.Mdp = TBuPWD.Text;
        }
    }
}
