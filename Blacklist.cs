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
                int a = Black_Liste.Count();
            }
            
        }

        private void Load_Settings()
        {
            if (!Properties.Settings.Default.First_Execution)
            {
                //LoadSlideShowList();
            }
            else
            {
                Black_Liste = new List<int>();
            }
        }

        private void Blacklist_Load(object sender, EventArgs e)
        {
            Load_Settings();
            Black_Liste = new List<int>();
            int ab = Black_Liste.Count();
            int aab = User.GetAllUsers().Count();
            foreach (User user in User.GetAllUsers().Where(p => Properties.Settings.Default.Black_List_save.IndexOf(p.Id.ToString()) == -1))
            {
                LBOX_Usager.Items.Add(user);
            }
            foreach (User user in  User.GetAllUsers().Where(p => Properties.Settings.Default.Black_List_save.IndexOf(p.Id.ToString()) != -1))
            {
                Black_Liste.Add(user.Id);
                LBOX_Blacklist.Items.Add(user);
            }
            int a = Black_Liste.Count();
            int b = User.GetAllUsers().Count();
            
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
            int b = Black_Liste.Count;
            Black_Liste.RemoveAt(LBOX_Blacklist.SelectedIndex);
            int a = Black_Liste.Count;
            //Properties.Settings.Default.Black_List_save.RemoveAt(LBOX_Blacklist.SelectedIndex);
            //int a =  Properties.Settings.Default.Black_List_save.Count;
            LBOX_Blacklist.Items.RemoveAt(LBOX_Blacklist.SelectedIndex);
            Save_settings();
            this.Refresh();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            //Save_settings();
            foreach (User user in LBOX_Blacklist.Items)
            {
                Black_Liste.Add(user.Id);
            }
            Save_settings();
        }
        private void SaveBlackList()
        {
            if (Properties.Settings.Default.Black_List_save == null)
            {
                Properties.Settings.Default.Black_List_save = new System.Collections.Specialized.StringCollection();
            }

            Properties.Settings.Default.Black_List_save.Clear();
            if (Black_Liste != null)
            {
                foreach (int UserId in Black_Liste)
                {
                    Properties.Settings.Default.Black_List_save.Add(UserId.ToString());
                }
            }
            int a = Black_Liste.Count();
            Properties.Settings.Default.Save();
        }
        private void Save_settings()
        {
            Properties.Settings.Default.First_Execution = false;
            SaveBlackList();
            
           // Properties.Settings.Default.Save();
        }
    }
}
