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
    public partial class Update : Form
    {
        public Photo photo { get; set; }
        public User User { get; set; }
        private ValidationProvider ValidationProvider;
        public int ID;
        public Update(int Id)
        {
            
            InitializeComponent();
            ID = Id;
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
        private bool Validate_CB_Shared(ref string message)
        {
            message = "Vous devez choisir de partager ou non";
            return TB_keyword.Text != "";
        }

        private void Update_Load(object sender, EventArgs e)
        {
            User_To_DLG();
            ValidationProvider = new ValidationProvider(this, SubmitTask);
            ValidationProvider.AddControlToValidate(TB_title, Validate_TB_title);
            ValidationProvider.AddControlToValidate(IBX_photo, Validate_IBX_Avatar);
        }
        private void User_To_DLG()
        {

            photo = DBPhotosWebServices.GetPhoto(ID);
            TB_title.Text = photo.Title;
            TB_keyword.Text = photo.Keywords;
            RTBX_description.Text = photo.Description;
            DTP_Date.Value = photo.CreationDate;
            IBX_photo.BackgroundImage = photo.GetOriginalImage();
            CB_Shared.Checked = photo.Shared;
        }


        private void DLG_To_User()
        {

            photo.Title = TB_title.Text;
            photo.Keywords = TB_keyword.Text;
            photo.Shared = CB_Shared.Checked;
            photo.Description = RTBX_description.Text;
            if (IBX_photo.BackgroundImage != photo.GetOriginalImage())
                photo.SetImage(IBX_photo.BackgroundImage);
        }
        private void SubmitTask()
        {
            DLG_To_User();
            DBPhotosWebServices.UpdatePhoto(photo);

        }

        private void BT_Update_Click(object sender, EventArgs e)
        {
            SubmitTask();
        }

        private void BT_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Rotate_Click(object sender, EventArgs e)
        {
        }
    }
}
