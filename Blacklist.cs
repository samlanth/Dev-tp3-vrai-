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
    
    public partial class Blacklist : Form
    {
        public User User { get; set; }
        public List<int> Black_Liste;
        public Blacklist()
        {
            InitializeComponent();
        }
        private void LoadSlideShowList()
        {
            Black_Liste = new List<int>();
            if (Properties.Settings.Default.Black_List_save != null)
            {
                foreach (string userId in Properties.Settings.Default.Black_List_save)
                {
                    
                    int UserId = int.Parse(userId);
                    Black_Liste.Add(UserId);
                }
            }
        }

        private void Load_Settings()
        {
            if (!Properties.Settings.Default.First_Execution)
            {
                LoadSlideShowList();
            }
            else
            {
                Black_Liste = new List<int>();
            }
        }

        private void Blacklist_Load(object sender, EventArgs e)
        {
            Load_Settings();
            foreach (User User in User.GetAllUsers().Where(p => Properties.Settings.Default.Black_List_save.IndexOf(p.Id.ToString())==-1))
            {
                LBOX_Usager.Items.Add(User);
            }
            foreach (User User in User.GetAllUsers().Where(p => Properties.Settings.Default.Black_List_save.IndexOf(p.Id.ToString()) != -1))
            {
                LBOX_Blacklist.Items.Add(User);
            }
        }

        private void BT_Droite_Click(object sender, EventArgs e)
        {
            LBOX_Blacklist.Items.Add(LBOX_Usager.SelectedItem);
            LBOX_Usager.Items.RemoveAt(LBOX_Usager.SelectedIndex);
            this.Refresh();
        }

        private void BT_Gauche_Click(object sender, EventArgs e)
        {
            LBOX_Usager.Items.Add(LBOX_Blacklist.SelectedItem);
            LBOX_Blacklist.Items.RemoveAt(LBOX_Blacklist.SelectedIndex);
            this.Refresh();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (User user in LBOX_Blacklist.Items)
            {
                Black_Liste.Add(user.Id);
            }
            Save_settings();
        }
        private void SaveBlackList()
        {
            if (Properties.Settings.Default.Black_List_save == null)
                Properties.Settings.Default.Black_List_save = new System.Collections.Specialized.StringCollection();
            Properties.Settings.Default.Black_List_save.Clear();
            if (Black_Liste != null)
                foreach (int photoId in Black_Liste)
                {
                    Properties.Settings.Default.Black_List_save.Add(photoId.ToString());
                }
        }
        private void Save_settings()
        {
            Properties.Settings.Default.First_Execution = false;
            SaveBlackList();
            Properties.Settings.Default.Save();
        }
    }
}
