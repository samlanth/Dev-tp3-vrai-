namespace Client_PM
{
    partial class View
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
            this.components = new System.ComponentModel.Container();
            this.GB_Owner = new System.Windows.Forms.GroupBox();
            this.LB_Nom = new System.Windows.Forms.Label();
            this.LB_X = new System.Windows.Forms.Label();
            this.LB_Date = new System.Windows.Forms.Label();
            this.LB_Pixels = new System.Windows.Forms.Label();
            this.LB_Shared = new System.Windows.Forms.Label();
            this.LB_Keywords = new System.Windows.Forms.Label();
            this.LB_Description = new System.Windows.Forms.Label();
            this.LB_Title = new System.Windows.Forms.Label();
            this.TB_keywords = new System.Windows.Forms.TextBox();
            this.TB_Left = new System.Windows.Forms.TextBox();
            this.TB_Title = new System.Windows.Forms.TextBox();
            this.RTBX_Description = new System.Windows.Forms.RichTextBox();
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_right = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.IBX_photo = new PhotoManagerClient.ImageBox();
            this.GB_Owner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IBX_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_Owner
            // 
            this.GB_Owner.Controls.Add(this.IBX_photo);
            this.GB_Owner.Controls.Add(this.LB_Nom);
            this.GB_Owner.Location = new System.Drawing.Point(12, 12);
            this.GB_Owner.Name = "GB_Owner";
            this.GB_Owner.Size = new System.Drawing.Size(272, 113);
            this.GB_Owner.TabIndex = 0;
            this.GB_Owner.TabStop = false;
            this.GB_Owner.Text = "Owner";
            // 
            // LB_Nom
            // 
            this.LB_Nom.AutoSize = true;
            this.LB_Nom.Location = new System.Drawing.Point(135, 51);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(29, 13);
            this.LB_Nom.TabIndex = 5;
            this.LB_Nom.Text = "Nom";
            // 
            // LB_X
            // 
            this.LB_X.AutoSize = true;
            this.LB_X.Location = new System.Drawing.Point(71, 365);
            this.LB_X.Name = "LB_X";
            this.LB_X.Size = new System.Drawing.Size(14, 13);
            this.LB_X.TabIndex = 0;
            this.LB_X.Text = "X";
            // 
            // LB_Date
            // 
            this.LB_Date.AutoSize = true;
            this.LB_Date.Location = new System.Drawing.Point(188, 134);
            this.LB_Date.Name = "LB_Date";
            this.LB_Date.Size = new System.Drawing.Size(30, 13);
            this.LB_Date.TabIndex = 1;
            this.LB_Date.Text = "Date";
            // 
            // LB_Pixels
            // 
            this.LB_Pixels.AutoSize = true;
            this.LB_Pixels.Location = new System.Drawing.Point(147, 365);
            this.LB_Pixels.Name = "LB_Pixels";
            this.LB_Pixels.Size = new System.Drawing.Size(34, 13);
            this.LB_Pixels.TabIndex = 2;
            this.LB_Pixels.Text = "Pixels";
            // 
            // LB_Shared
            // 
            this.LB_Shared.AutoSize = true;
            this.LB_Shared.Location = new System.Drawing.Point(201, 365);
            this.LB_Shared.Name = "LB_Shared";
            this.LB_Shared.Size = new System.Drawing.Size(0, 13);
            this.LB_Shared.TabIndex = 3;
            // 
            // LB_Keywords
            // 
            this.LB_Keywords.AutoSize = true;
            this.LB_Keywords.Location = new System.Drawing.Point(12, 286);
            this.LB_Keywords.Name = "LB_Keywords";
            this.LB_Keywords.Size = new System.Drawing.Size(53, 13);
            this.LB_Keywords.TabIndex = 4;
            this.LB_Keywords.Text = "Keywords";
            // 
            // LB_Description
            // 
            this.LB_Description.AutoSize = true;
            this.LB_Description.Location = new System.Drawing.Point(12, 183);
            this.LB_Description.Name = "LB_Description";
            this.LB_Description.Size = new System.Drawing.Size(60, 13);
            this.LB_Description.TabIndex = 6;
            this.LB_Description.Text = "Description";
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.Location = new System.Drawing.Point(12, 134);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(28, 13);
            this.LB_Title.TabIndex = 7;
            this.LB_Title.Text = "Titre";
            // 
            // TB_keywords
            // 
            this.TB_keywords.Location = new System.Drawing.Point(15, 302);
            this.TB_keywords.Name = "TB_keywords";
            this.TB_keywords.ReadOnly = true;
            this.TB_keywords.Size = new System.Drawing.Size(324, 20);
            this.TB_keywords.TabIndex = 6;
            // 
            // TB_Left
            // 
            this.TB_Left.Location = new System.Drawing.Point(15, 362);
            this.TB_Left.Name = "TB_Left";
            this.TB_Left.ReadOnly = true;
            this.TB_Left.Size = new System.Drawing.Size(50, 20);
            this.TB_Left.TabIndex = 8;
            // 
            // TB_Title
            // 
            this.TB_Title.Location = new System.Drawing.Point(15, 150);
            this.TB_Title.Name = "TB_Title";
            this.TB_Title.ReadOnly = true;
            this.TB_Title.Size = new System.Drawing.Size(148, 20);
            this.TB_Title.TabIndex = 10;
            // 
            // RTBX_Description
            // 
            this.RTBX_Description.Enabled = false;
            this.RTBX_Description.Location = new System.Drawing.Point(12, 199);
            this.RTBX_Description.Name = "RTBX_Description";
            this.RTBX_Description.ReadOnly = true;
            this.RTBX_Description.Size = new System.Drawing.Size(327, 75);
            this.RTBX_Description.TabIndex = 8;
            this.RTBX_Description.Text = "";
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.Location = new System.Drawing.Point(264, 365);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Fermer.TabIndex = 11;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            this.BTN_Fermer.Click += new System.EventHandler(this.BTN_Fermer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dimensions";
            // 
            // TB_right
            // 
            this.TB_right.Location = new System.Drawing.Point(91, 362);
            this.TB_right.Name = "TB_right";
            this.TB_right.ReadOnly = true;
            this.TB_right.Size = new System.Drawing.Size(50, 20);
            this.TB_right.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // IBX_photo
            // 
            this.IBX_photo.AllowDrop = true;
            this.IBX_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IBX_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IBX_photo.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.IBX_photo.ImportImageText = "Import image from file...";
            this.IBX_photo.Location = new System.Drawing.Point(15, 34);
            this.IBX_photo.Name = "IBX_photo";
            this.IBX_photo.OpenFileDialogTitle = "Please choose image an file";
            this.IBX_photo.PasteMenuText = "Paste image from clipboard";
            this.IBX_photo.Size = new System.Drawing.Size(100, 50);
            this.IBX_photo.TabIndex = 6;
            this.IBX_photo.TabStop = false;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 397);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.TB_right);
            this.Controls.Add(this.TB_Left);
            this.Controls.Add(this.TB_Title);
            this.Controls.Add(this.TB_keywords);
            this.Controls.Add(this.RTBX_Description);
            this.Controls.Add(this.LB_Description);
            this.Controls.Add(this.LB_Keywords);
            this.Controls.Add(this.LB_Title);
            this.Controls.Add(this.LB_Pixels);
            this.Controls.Add(this.LB_X);
            this.Controls.Add(this.LB_Shared);
            this.Controls.Add(this.GB_Owner);
            this.Controls.Add(this.LB_Date);
            this.Name = "View";
            this.Text = "Informations";
            this.Load += new System.EventHandler(this.View_Load);
            this.GB_Owner.ResumeLayout(false);
            this.GB_Owner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IBX_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Owner;
        private System.Windows.Forms.Label LB_X;
        private System.Windows.Forms.Label LB_Date;
        private System.Windows.Forms.Label LB_Pixels;
        private System.Windows.Forms.Label LB_Shared;
        private System.Windows.Forms.Label LB_Keywords;
        private System.Windows.Forms.Label LB_Nom;
        private System.Windows.Forms.Label LB_Description;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.TextBox TB_keywords;
        private System.Windows.Forms.TextBox TB_Left;
        private System.Windows.Forms.TextBox TB_Title;
        private System.Windows.Forms.RichTextBox RTBX_Description;
        private System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_right;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private PhotoManagerClient.ImageBox IBX_photo;
    }
}