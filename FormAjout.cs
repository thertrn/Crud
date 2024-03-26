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
    public partial class FormAjout : Form
    {
        Utilisateur leNewUser;
        public FormAjout(Utilisateur newUser)
        {
            InitializeComponent();
            leNewUser = newUser;
            TBnomNew.Text = newUser.Nom;
            TBprenNew.Text = newUser.Prenom;
            TBloginNew.Text = newUser.Identifiant;
            TBpasswdNew.Text = newUser.Mdp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
