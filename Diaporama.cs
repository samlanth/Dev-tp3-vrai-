﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Slideshow;
using PhotoManagerClient;
namespace Client_PM
{
    public partial class Diaporama : Form
    {
        // Liste des id des photos incluses dans le diaporama
        public List<int> SlideShowList { get; set; }

        // Liste des photos incluses dans le diaporama
        public List<Photo> PhotoPool { get; set; }
        private List<Photo> Slides;
        private List<int> bl;
        // Liste des index de photo dans définissant l'ordre de passation
        private int[] PhotosOrder;
        // Ordre aléatoire si vrai
        private bool RandomOrder = false;
        // Plein écran si vrai
        private bool FullScreen = false;

        // Index courrant de PhotosOrder 
        private int Current_PhotosOrder_Index = 0;
        public Diaporama()
        {
            InitializeComponent();
            // Optimiser l'affichage
            this.DoubleBuffered = true;
            this.BackColor = Color.Black;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public void setblacklist(List<int> b)
        {
            bl = b;
        }
        private void Diaporama_Shown(object sender, EventArgs e)
        {

            WaitSplash.Show(this, "Loading slide show photos...");
            Slides = new List<Photo>();
            // PhotoPool = new List<Photo>();
            foreach (int photoId in SlideShowList)
            {
                // Obtenir la photo du service
                Photo photo = DBPhotosWebServices.GetPhoto(photoId);
                if (photo != null)
                {
                    if (bl.IndexOf(photo.OwnerId) == -1)
                    {
                        Slides.Add(photo);
                    }
                }
            }
            
            WaitSplash.Hide();
            // Définir l'ordre des photos
            SetPhotosOrder();
            // Démarrer l'horloge
            SlideshowTimer.Start();

        }

        private void Toggle_FullScreen()
        {
            FullScreen = !FullScreen;

            if (FullScreen)
            {
                // Masquer la bordure et l'entête
                this.FormBorderStyle = FormBorderStyle.None;
                // Masquer la barre des menus
                this.menuStrip1.Visible = false;
                // Agrandir
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.menuStrip1.Visible = true;
                this.WindowState = FormWindowState.Normal;
            }
        }
        
        private void Next()
        {
            if ((PhotosOrder.Count() > 0)
                && (Current_PhotosOrder_Index < PhotosOrder.Count() )
                    && (PhotosOrder[Current_PhotosOrder_Index] < Slides.Count()))

            {
                // Régler l'image de fond avec la prochaine photo
                this.BackgroundImage = Slides[PhotosOrder[Current_PhotosOrder_Index]].GetOriginalImage();
                // Index de la prochaine photo. Si était la dernière, revenir à la première
                Current_PhotosOrder_Index = (Current_PhotosOrder_Index < Slides.Count - 1 ? Current_PhotosOrder_Index + 1 : 0);
            }
        }

        // Mélanger les photos aléatoirement
        private void ShufflePhotosOrder()
        {
            Random rnd = new Random(DateTime.Now.Second);
            int nb_Photos = SlideShowList.Count;
            for (int i = 0; i < nb_Photos - 1; i++)
            {
                int j = rnd.Next((nb_Photos - i - 2)) + i + 1;
                int k = PhotosOrder[i];
                PhotosOrder[i] = PhotosOrder[j];
                PhotosOrder[j] = k;
            }
        }

        // Définir l'ordre des photos
        private void SetPhotosOrder()
        {
            WaitSplash.Show(this, "Setting photo order...");
            Current_PhotosOrder_Index = 0;

            int nb_Photos = SlideShowList.Count;
            PhotosOrder = new int[nb_Photos];
            // Ordre séquentiel
            for (int i = 0; i < nb_Photos; i++)
            {
                PhotosOrder[i] = i;
            }
            if (RandomOrder)
            {
                // Ordre aléatoire
                ShufflePhotosOrder();
            }
            WaitSplash.Hide();
            // Affichier la première photo
            Next();
        }
        private void ShowHelp()
        {
            SlideshowHelp dlg = new SlideshowHelp();
            dlg.ShowDialog();
        }

        private void SlideshowTimer_Tick_1(object sender, EventArgs e)
        {
            Next();
        }

        private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowHelp();
        }

        private void Diaporama_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1: ShowHelp(); break;
                case Keys.F11: Toggle_FullScreen(); break;
                case Keys.P: SlideshowTimer.Start(); break;
                case Keys.S: SlideshowTimer.Stop(); break;
                case Keys.R: RandomOrder = !RandomOrder; SetPhotosOrder(); break;
                case Keys.Down: SlideshowTimer.Interval = (SlideshowTimer.Interval < 60000 ? SlideshowTimer.Interval + 250 : SlideshowTimer.Interval); break;
                case Keys.Up: SlideshowTimer.Interval = (SlideshowTimer.Interval > 500 ? SlideshowTimer.Interval - 250 : SlideshowTimer.Interval); break;
                case Keys.Escape: SlideshowTimer.Stop(); Close(); break;
            }
        }
    }
}

