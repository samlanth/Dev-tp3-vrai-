using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validation;
using PhotoManagerClient;

namespace Client_PM
{
    public partial class AjouterPhoto : Form
    {
        public Photo photo { get; set; }
        public User User { get; set; }
        private ValidationProvider ValidationProvider;
        private bool AvatarImageChanged = false;

        public AjouterPhoto()
        {
            InitializeComponent();
        }
        private bool Validate_TB_title(ref string message)
        {
            message = "Titre manquant";
            return TB_title.Text != "";
        }
        private bool Validate_IBX_Avatar(ref string message)
        {
            message = "Veuillez vhoisir votre avatar.";
            return IBX_photo.BackgroundImage != null;
        }
        private bool Validate_RTBX_description(ref string message)
        {
            message = "Description manquant";
            return RTBX_description.Text != "";
        }
        private bool Validate_TB_keyword(ref string message)
        {
            message = "Veuillez vhoisir votre avatar.";
            return TB_keyword.Text != "";
        }
        private bool Validate_CB_Shared(ref string message)
        {
            message = "Vous devez choisir de partager ou non";
            return TB_keyword.Text != "";
        }
        private void SubmitTask()
        {
            if (photo == null)
            {
                Photo photo = new Photo();
                photo.SetImage(IBX_photo.BackgroundImage);
                photo.CreationDate = dateTimePicker1.Value;
                photo.Description = RTBX_description.Text;
                photo.Keywords = TB_keyword.Text;
                photo.Shared = CB_Shared.Checked;
                photo.Title = TB_title.Text;
                photo.OwnerId = User.Id;
                
                photo = DBPhotosWebServices.CreatePhoto(photo);
            }
            else
            {
            }
        }
        private void AjouterPhoto_Load(object sender, EventArgs e)
        {
            ValidationProvider = new ValidationProvider(this, SubmitTask);
            ValidationProvider.AddControlToValidate(TB_title, Validate_TB_title);
            ValidationProvider.AddControlToValidate(IBX_photo, Validate_IBX_Avatar);
            ValidationProvider.AddControlToValidate(RTBX_description, Validate_RTBX_description);
            ValidationProvider.AddControlToValidate(TB_keyword, Validate_TB_keyword);
 
        }

        private void BT_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_add_Click(object sender, EventArgs e)
        {
            SubmitTask();
        }
    }
}
