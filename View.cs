using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoManagerClient;

namespace Client_PM
{
    public partial class View : Form
    {
        public Photo photo { get; set; }
        public User User { get; set; }
        public int ID;
        public int UID;
        public View(int Id,int UId)
        {
            InitializeComponent();
            ID = Id;
            UID = UId;
        }
        private void User_To_DLG()
        {
            User = DBPhotosWebServices.GetUser(UID);
            photo = DBPhotosWebServices.GetPhoto(ID);
            TB_Title.Text = photo.Title;
            TB_keywords.Text = photo.Keywords;
            RTBX_Description.Text = photo.Description;
            dateTimePicker1.Value = photo.CreationDate;
            IBX_photo.BackgroundImage = photo.GetOriginalImage();
            TB_Left.Text = photo.GetOriginalImage().Width.ToString();
            TB_right.Text = photo.GetOriginalImage().Height.ToString();
            User u = DBPhotosWebServices.GetUser(photo.OwnerId);
            LB_Nom.Text = u.Name;
            if (photo.Shared)
                LB_Shared.Text = "Shared";
            else
                LB_Shared.Text = "Private";
        }

        private void View_Load(object sender, EventArgs e)
        {
            User_To_DLG();
            this.ControlBox = false;
            this.Text = "  ";
        }

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
