﻿namespace Client_PM
{
    partial class Blacklist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBOX_Usager = new System.Windows.Forms.ListBox();
            this.LBOX_Blacklist = new System.Windows.Forms.ListBox();
            this.LB_Usager = new System.Windows.Forms.Label();
            this.LB_Blacklist = new System.Windows.Forms.Label();
            this.BT_Droite = new System.Windows.Forms.Button();
            this.BT_Gauche = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBOX_Usager
            // 
            this.LBOX_Usager.FormattingEnabled = true;
            this.LBOX_Usager.Location = new System.Drawing.Point(91, 55);
            this.LBOX_Usager.Name = "LBOX_Usager";
            this.LBOX_Usager.Size = new System.Drawing.Size(120, 160);
            this.LBOX_Usager.TabIndex = 0;
            // 
            // LBOX_Blacklist
            // 
            this.LBOX_Blacklist.FormattingEnabled = true;
            this.LBOX_Blacklist.Location = new System.Drawing.Point(348, 55);
            this.LBOX_Blacklist.Name = "LBOX_Blacklist";
            this.LBOX_Blacklist.Size = new System.Drawing.Size(120, 160);
            this.LBOX_Blacklist.TabIndex = 1;
            // 
            // LB_Usager
            // 
            this.LB_Usager.AutoSize = true;
            this.LB_Usager.Location = new System.Drawing.Point(88, 20);
            this.LB_Usager.Name = "LB_Usager";
            this.LB_Usager.Size = new System.Drawing.Size(41, 13);
            this.LB_Usager.TabIndex = 2;
            this.LB_Usager.Text = "Usager";
            // 
            // LB_Blacklist
            // 
            this.LB_Blacklist.AutoSize = true;
            this.LB_Blacklist.Location = new System.Drawing.Point(345, 20);
            this.LB_Blacklist.Name = "LB_Blacklist";
            this.LB_Blacklist.Size = new System.Drawing.Size(46, 13);
            this.LB_Blacklist.TabIndex = 3;
            this.LB_Blacklist.Text = "Blacklist";
            // 
            // BT_Droite
            // 
            this.BT_Droite.Location = new System.Drawing.Point(217, 90);
            this.BT_Droite.Name = "BT_Droite";
            this.BT_Droite.Size = new System.Drawing.Size(125, 30);
            this.BT_Droite.TabIndex = 4;
            this.BT_Droite.Text = "--->";
            this.BT_Droite.UseVisualStyleBackColor = true;
            this.BT_Droite.Click += new System.EventHandler(this.BT_Droite_Click);
            // 
            // BT_Gauche
            // 
            this.BT_Gauche.Location = new System.Drawing.Point(217, 141);
            this.BT_Gauche.Name = "BT_Gauche";
            this.BT_Gauche.Size = new System.Drawing.Size(125, 30);
            this.BT_Gauche.TabIndex = 5;
            this.BT_Gauche.Text = "<---";
            this.BT_Gauche.UseVisualStyleBackColor = true;
            this.BT_Gauche.Click += new System.EventHandler(this.BT_Gauche_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(444, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Blacklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT_Gauche);
            this.Controls.Add(this.BT_Droite);
            this.Controls.Add(this.LB_Blacklist);
            this.Controls.Add(this.LB_Usager);
            this.Controls.Add(this.LBOX_Blacklist);
            this.Controls.Add(this.LBOX_Usager);
            this.Name = "Blacklist";
            this.Text = "Blacklist";
            this.Load += new System.EventHandler(this.Blacklist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBOX_Usager;
        private System.Windows.Forms.ListBox LBOX_Blacklist;
        private System.Windows.Forms.Label LB_Usager;
        private System.Windows.Forms.Label LB_Blacklist;
        private System.Windows.Forms.Button BT_Droite;
        private System.Windows.Forms.Button BT_Gauche;
        private System.Windows.Forms.Button button1;
    }
}