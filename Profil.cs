using PhotoManagerClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_PM
{
    public partial class Profil : Form
    {
        public User User { get; set; }

        public Profil()
        {
            InitializeComponent();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_DeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir effacer votre compte et toutes vos photos?", "Attention!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                DBPhotosWebServices.DeleteUser(User.Id);
                User = null;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
