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
    public partial class Slideshow : Form
    {
        private List<Photo> photos;
        private List<int> SlideShowList;
       private  List<int> bl;
        public Slideshow()
        {
            InitializeComponent();
        }
        private void Load_Settings()
        {
            if (!Properties.Settings.Default.First_Execution)
            {
                LoadSlideShowList();
            }
            else
            {
                SlideShowList = new List<int>();
            }
        }

        private void Save_settings()
        {
            Properties.Settings.Default.First_Execution = false;
            SaveSlideShowList();
            Properties.Settings.Default.Save();
        }


        private void LoadSlideShowList()
        {
            SlideShowList = new List<int>();
            if (Properties.Settings.Default.SlideShowList != null)
            {
                foreach (string stringPhotoId in Properties.Settings.Default.SlideShowList)
                {
                    int photoId = int.Parse(stringPhotoId);
                    SlideShowList.Add(photoId);
                }
            }
        }

        private void SaveSlideShowList()
        {
            if (Properties.Settings.Default.SlideShowList == null)
                Properties.Settings.Default.SlideShowList = new System.Collections.Specialized.StringCollection();
            Properties.Settings.Default.SlideShowList.Clear();
            if (SlideShowList != null)
                foreach (int photoId in SlideShowList)
                {
                    Properties.Settings.Default.SlideShowList.Add(photoId.ToString());
                }
        }

       public void setblacklist(List<int> b)
        {
            bl = b;
        }

        private void Slideshow_Load(object sender, EventArgs e)
        {
            Load_Settings();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                ManageSlideShow dlg = new ManageSlideShow();
                dlg.SlideShowList = SlideShowList;
                dlg.PhotoPool = photos;
                dlg.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Diaporama dlg = new Diaporama();
            dlg.setblacklist(bl);
            dlg.SlideShowList = SlideShowList;
            dlg.PhotoPool = photos;
            dlg.ShowDialog();
        }

        private void Slideshow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_settings();
        }

        private void Slideshow_Shown(object sender, EventArgs e)
        {
            WaitSplash.Show(this, "Loading photos from server...");
            photos = DBPhotosWebServices.GetAllPhotos();
            //photos = DBPhotosWebServices.GetAllPhotos().Where(p=>bl.IndexOf(p.OwnerId)==-1).ToList();
            WaitSplash.Hide();
        }
    }
}
