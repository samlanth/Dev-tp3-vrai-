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
    public partial class MainForm : Form
    {
        User Logged_User = null;
        PhotoFilter PhotoFilter = null;
        public List<int> Black_Liste;
        public MainForm()
        {
            InitializeComponent();
            Black_Liste = new List<int>();
            Text = "Photo Manager Client application - Not connected";
        }

 
        bool initializing = true;
        private void MainForm_Shown(object sender, EventArgs e)
        {
            // Get server attention...
            WaitSplash.Show(this, "Connecting to Photo Manager...");
            string bidon = DBPhotosWebServices.GetServerImagesURLBase();
            WaitSplash.Hide();
            Update_UI();
        }

        private void Update_UI()
        {
            MI_Account_Profil.Enabled = Logged_User != null;
        }

        private void Init_UsersList()
        {
            foreach (User user in PhotoFilter.UsersList)
            {
                if (user.Name != null)
                    CBX_UsersList.Items.Add(user);
            }
            CBX_UsersList.SelectedIndex = 0;
        }

        private void LoadPhoto()
        {
            WaitSplash.Show(this, "Loading photos from server...");
            // PhotoBrowser.LoadPhotos(PhotoFilter.GetPhotos().Where(P => Black_Liste.IndexOf(P.OwnerId)==-1).ToList());
            // PhotoBrowser.LoadPhotos(PhotoFilter.GetPhotos());
            PhotoBrowser.LoadPhotos(PhotoFilter.GetPhotos().Where(P => Properties.Settings.Default.Black_List_save.IndexOf(P.OwnerId.ToString()) == -1).ToList());
            WaitSplash.Hide();
        }


        private void Init_Keywords_List()
        {
            CBX_Keywords.Items.Clear();
            CBX_Keywords.Items.Add("");

            foreach (string keyword in PhotoFilter.KeywordsList)
            {
                CBX_Keywords.Items.Add(keyword.Clone());
            }
            CBX_Keywords.SelectedIndex = 0;
        }

        private void CBX_UsersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = (User)CBX_UsersList.SelectedItem;
            if (selectedUser.Id == -1) // Only mine
            {
                PhotoFilter.SetUserFilter(false, false, 0);
            }
            else
            {
                if (selectedUser.Id == 0) // All users
                {
                    PhotoFilter.SetUserFilter(false, true, 0);
                }
                else
                {
                    PhotoFilter.SetUserFilter(true, false, selectedUser.Id);
                }
            }
            initializing = true;
            PhotoFilter.SetKeywordsFilter(false, "");
            LoadPhoto();
            Init_Keywords_List();
            initializing = false;
        }

        private void CBX_Keywords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!initializing)
            {

                PhotoFilter.SetKeywordsFilter(true, CBX_Keywords.SelectedItem.ToString());

                LoadPhoto();
                PhotoBrowser.SelectNext();
                PhotoBrowser.Focus();
            }
        }

        private void BTN_Left_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Left;
        }

        private void BTN_Top_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Top;
        }

        private void BTN_Right_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Right;
        }

        private void BTN_Bottom_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Bottom;
        }

        private void Setup_Logged_User()
        {
            if (Logged_User != null)
            {
                AddNewPhoto.Enabled = true;
                AddNewPhoto.BackgroundImage = Properties.Resources.ICON_Add_Neutral;
                Text = "Photo Manager Client application -" + Logged_User.Name;
                PhotoFilter = new PhotoFilter(Logged_User.Id);
                Init_UsersList();
                initializing = true;
                LoadPhoto();
                Init_Keywords_List();
                initializing = false;
            }
            else
            {
                AddNewPhoto.Enabled = false;
                CBX_UsersList.Items.Clear();
                CBX_Keywords.Items.Clear();
                PhotoBrowser.Clear();
                PhotoFilter = null;
            }
            Update_UI();
        }
        private void MI_Account_Login_Click(object sender, EventArgs e)
        {
            DLG_Login dlg = new DLG_Login();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Logged_User = dlg.Logged_User;
                Setup_Logged_User();
                
            }
        }

        private void MI_Account_Profil_Click(object sender, EventArgs e)
        {
            Profil dlg = new Profil();
            dlg.User = Logged_User;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Logged_User = dlg.User;
                Setup_Logged_User();
            }
        }

        private void Mi_Account_Create_Click(object sender, EventArgs e)
        {
            DLG_Account dlg = new DLG_Account();
             if (dlg.ShowDialog() == DialogResult.OK)
            {
                Logged_User = dlg.User;
                Setup_Logged_User();
            }
        }

        private void AddNewPhoto_Click(object sender, EventArgs e)
        {
            AjouterPhoto dlg = new AjouterPhoto();
            dlg.User = Logged_User;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PhotoBrowser.AddPhoto(dlg.photo);
                LoadPhoto();
            }
        }

        private void EditerPhoto_Click(object sender, EventArgs e)
        {
            Update dlg = new Update(PhotoBrowser.SelectedPhoto.Id);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                
                LoadPhoto();
            }
        }

        private void ViewPhoto_Click(object sender, EventArgs e)
        {
            View dlg = new View(PhotoBrowser.SelectedPhoto.Id,Logged_User.Id);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadPhoto();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //AddNewPhoto.Enabled = false;
            //EditerPhoto.Enabled = false;
            //ViewPhoto.Enabled = false;
            //DeletePhoto.Enabled = false;
            this.Refresh();
            PhotoBrowser.Refresh();
            
            ToolTip toolTipFlash = new ToolTip();

            toolTipFlash.SetToolTip(AddNewPhoto, "Ajouter une photo");
            toolTipFlash.SetToolTip(EditerPhoto, "Editer une photo");
            toolTipFlash.SetToolTip(DeletePhoto, "Enlever une photo");
            toolTipFlash.SetToolTip(ViewPhoto, "Details de la photo");
            
        }

        private void MI_Account_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddNewPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            this.AddNewPhoto.BackgroundImage = Properties.Resources.ICON_Add_Click;
        }

        private void AddNewPhoto_MouseHover(object sender, EventArgs e)
        {
            this.AddNewPhoto.BackgroundImage = Properties.Resources.ICON_Add_Over;
        }

        private void AddNewPhoto_MouseLeave(object sender, EventArgs e)
        {
            this.AddNewPhoto.BackgroundImage = Properties.Resources.ICON_Add_Neutral;
        }

        private void EditerPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            this.EditerPhoto.BackgroundImage = Properties.Resources.ICON_Editer_Click;
        }

        private void EditerPhoto_MouseHover(object sender, EventArgs e)
        {
            this.EditerPhoto.BackgroundImage = Properties.Resources.ICON_Editer_Survol;
        }

        private void EditerPhoto_MouseLeave(object sender, EventArgs e)
        {
            this.EditerPhoto.BackgroundImage = Properties.Resources.ICON_Editer_Neutre;
        }

        private void DeletePhoto_MouseDown(object sender, MouseEventArgs e)
        {
            this.DeletePhoto.BackgroundImage = Properties.Resources.ICON_Delete_Click;
        }

        private void DeletePhoto_MouseHover(object sender, EventArgs e)
        {
            this.DeletePhoto.BackgroundImage = Properties.Resources.ICON_Delete_Over;
        }

        private void DeletePhoto_MouseLeave(object sender, EventArgs e)
        {
            this.DeletePhoto.BackgroundImage = Properties.Resources.ICON_Delete_Neutral;
        }

        private void ViewPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            this.ViewPhoto.BackgroundImage = Properties.Resources._201_spy_eyes_hover;
        }

        private void ViewPhoto_MouseHover(object sender, EventArgs e)
        {
            this.ViewPhoto.BackgroundImage = Properties.Resources._201_spy_eyes_click;
        }

        private void ViewPhoto_MouseLeave(object sender, EventArgs e)
        {
            this.ViewPhoto.BackgroundImage = Properties.Resources._201_spy_eyes;
        }

        private void MS_Account_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DeletePhoto_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??","Confirm Delete!!",MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                PhotoBrowser.DeleteSelectedPhoto();
            }
        }

        private void topToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Top;
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Bottom;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Left;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Right;
        }
        

        private void blacklistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blacklist dlg = new Blacklist();

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                Black_Liste = dlg.Black_Liste;
                LoadPhoto();
            }
        }

        private void slideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Slideshow dlg = new Slideshow();
            dlg.setblacklist(Black_Liste);
            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PhotoBrowser_SelectedChanged(object sender, EventArgs e)
        {
            if (PhotoBrowser.SelectedPhoto != null)
            {
                EditerPhoto.Enabled = true;
                EditerPhoto.BackgroundImage = Properties.Resources.ICON_Editer_Neutre;
                DeletePhoto.Enabled = true;
                DeletePhoto.BackgroundImage = Properties.Resources.ICON_Delete_Neutral;
                ViewPhoto.Enabled = true;
                ViewPhoto.BackgroundImage = Properties.Resources._201_spy_eyes;
                if (PhotoBrowser.SelectedPhoto.OwnerId != Logged_User.Id)
                {
                    EditerPhoto.Enabled = false;
                    DeletePhoto.Enabled = false;
                }
            }
            else
            {
                EditerPhoto.Enabled = false;
                DeletePhoto.Enabled = false;
                ViewPhoto.Enabled = false;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                PhotoFilter.SetUserFilter(true, true, 0);
                LoadPhoto();
                PhotoBrowser.SelectNext();
                PhotoBrowser.Focus();
            }
            else
            {
                PhotoFilter.SetUserFilter(false, true, 0);
                LoadPhoto();
                PhotoBrowser.SelectNext();
                PhotoBrowser.Focus();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                PhotoFilter.SetDateFilter(true, dateTimePicker1.Value, dateTimePicker2.Value);
                LoadPhoto();
                PhotoBrowser.SelectNext();
                PhotoBrowser.Focus();
            }
            else
            {
                PhotoFilter.SetDateFilter(false, dateTimePicker1.Value, dateTimePicker2.Value);
                LoadPhoto();
                PhotoBrowser.SelectNext();
                PhotoBrowser.Focus();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                PhotoFilter.SetDateFilter(true, dateTimePicker1.Value, dateTimePicker2.Value);
                LoadPhoto();
                PhotoBrowser.SelectNext();
                PhotoBrowser.Focus();
            }
            else
            {
                PhotoFilter.SetDateFilter(false, dateTimePicker1.Value, dateTimePicker2.Value);
                LoadPhoto();
                PhotoBrowser.SelectNext();
                PhotoBrowser.Focus();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                PhotoFilter.SetDateFilter(true, dateTimePicker1.Value, dateTimePicker2.Value);
                LoadPhoto();
                PhotoBrowser.SelectNext();
                PhotoBrowser.Focus();
            }
            else
            {
                PhotoFilter.SetDateFilter(false, dateTimePicker1.Value, dateTimePicker2.Value);
                LoadPhoto();
                PhotoBrowser.SelectNext();
                PhotoBrowser.Focus();
            }
        }
    }
}
