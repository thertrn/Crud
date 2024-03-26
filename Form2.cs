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
    public partial class Form2 : Form
    {
        Utilisateur LeUserCourant;
        private Utilisateur selectedUtilisateur;

        public Form2(Utilisateur monUser)
        {
            /*InitializeComponent();
            LeUserCourant = monUser;
            TBClientNom.Text = monUser.ContactNom;
            TBAdresse.Text = monUser.ContactAdresse;
            TBVille.Text = monUser.ContactVille;

            this.selectedUtilisateur = selectedUtilisateur;*/
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnEnreg_Click(object sender, EventArgs e)
        {
            LeUserCourant.Save();
        }
    }
}
