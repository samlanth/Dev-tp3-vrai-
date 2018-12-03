namespace Client_PM
{
    partial class AjouterPhoto
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
            this.TB_title = new System.Windows.Forms.TextBox();
            this.TB_keyword = new System.Windows.Forms.TextBox();
            this.RTBX_description = new System.Windows.Forms.RichTextBox();
            this.LB_title = new System.Windows.Forms.Label();
            this.LB_Date = new System.Windows.Forms.Label();
            this.LB_Description = new System.Windows.Forms.Label();
            this.LB_Keywords = new System.Windows.Forms.Label();
            this.CB_Shared = new System.Windows.Forms.CheckBox();
            this.BT_exit = new System.Windows.Forms.Button();
            this.BT_Rotate = new System.Windows.Forms.Button();
            this.BT_add = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.IBX_photo = new PhotoManagerClient.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.IBX_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_title
            // 
            this.TB_title.Location = new System.Drawing.Point(25, 33);
            this.TB_title.Margin = new System.Windows.Forms.Padding(5);
            this.TB_title.Name = "TB_title";
            this.TB_title.Size = new System.Drawing.Size(210, 26);
            this.TB_title.TabIndex = 0;
            // 
            // TB_keyword
            // 
            this.TB_keyword.Location = new System.Drawing.Point(25, 147);
            this.TB_keyword.Margin = new System.Windows.Forms.Padding(5);
            this.TB_keyword.Name = "TB_keyword";
            this.TB_keyword.Size = new System.Drawing.Size(210, 26);
            this.TB_keyword.TabIndex = 2;
            // 
            // RTBX_description
            // 
            this.RTBX_description.Location = new System.Drawing.Point(25, 213);
            this.RTBX_description.Margin = new System.Windows.Forms.Padding(5);
            this.RTBX_description.Name = "RTBX_description";
            this.RTBX_description.Size = new System.Drawing.Size(210, 122);
            this.RTBX_description.TabIndex = 3;
            this.RTBX_description.Text = "";
            // 
            // LB_title
            // 
            this.LB_title.AutoSize = true;
            this.LB_title.Location = new System.Drawing.Point(21, 9);
            this.LB_title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LB_title.Name = "LB_title";
            this.LB_title.Size = new System.Drawing.Size(45, 20);
            this.LB_title.TabIndex = 4;
            this.LB_title.Text = "Titre";
            // 
            // LB_Date
            // 
            this.LB_Date.AutoSize = true;
            this.LB_Date.Location = new System.Drawing.Point(21, 64);
            this.LB_Date.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LB_Date.Name = "LB_Date";
            this.LB_Date.Size = new System.Drawing.Size(48, 20);
            this.LB_Date.TabIndex = 5;
            this.LB_Date.Text = "Date";
            // 
            // LB_Description
            // 
            this.LB_Description.AutoSize = true;
            this.LB_Description.Location = new System.Drawing.Point(21, 188);
            this.LB_Description.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LB_Description.Name = "LB_Description";
            this.LB_Description.Size = new System.Drawing.Size(100, 20);
            this.LB_Description.TabIndex = 6;
            this.LB_Description.Text = "Description";
            // 
            // LB_Keywords
            // 
            this.LB_Keywords.AutoSize = true;
            this.LB_Keywords.Location = new System.Drawing.Point(21, 122);
            this.LB_Keywords.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LB_Keywords.Name = "LB_Keywords";
            this.LB_Keywords.Size = new System.Drawing.Size(85, 20);
            this.LB_Keywords.TabIndex = 7;
            this.LB_Keywords.Text = "Keywords";
            // 
            // CB_Shared
            // 
            this.CB_Shared.AutoSize = true;
            this.CB_Shared.Location = new System.Drawing.Point(149, 184);
            this.CB_Shared.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Shared.Name = "CB_Shared";
            this.CB_Shared.Size = new System.Drawing.Size(86, 24);
            this.CB_Shared.TabIndex = 8;
            this.CB_Shared.Text = "Shared";
            this.CB_Shared.UseVisualStyleBackColor = true;
            // 
            // BT_exit
            // 
            this.BT_exit.Location = new System.Drawing.Point(393, 345);
            this.BT_exit.Margin = new System.Windows.Forms.Padding(5);
            this.BT_exit.Name = "BT_exit";
            this.BT_exit.Size = new System.Drawing.Size(112, 35);
            this.BT_exit.TabIndex = 9;
            this.BT_exit.Text = "Cancel";
            this.BT_exit.UseVisualStyleBackColor = true;
            this.BT_exit.Click += new System.EventHandler(this.BT_exit_Click);
            // 
            // BT_Rotate
            // 
            this.BT_Rotate.Location = new System.Drawing.Point(271, 345);
            this.BT_Rotate.Margin = new System.Windows.Forms.Padding(5);
            this.BT_Rotate.Name = "BT_Rotate";
            this.BT_Rotate.Size = new System.Drawing.Size(112, 35);
            this.BT_Rotate.TabIndex = 10;
            this.BT_Rotate.Text = "Rotate";
            this.BT_Rotate.UseVisualStyleBackColor = true;
            this.BT_Rotate.Click += new System.EventHandler(this.BT_Rotate_Click);
            // 
            // BT_add
            // 
            this.BT_add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BT_add.Location = new System.Drawing.Point(25, 345);
            this.BT_add.Margin = new System.Windows.Forms.Padding(5);
            this.BT_add.Name = "BT_add";
            this.BT_add.Size = new System.Drawing.Size(112, 35);
            this.BT_add.TabIndex = 11;
            this.BT_add.Text = "Create";
            this.BT_add.UseVisualStyleBackColor = true;
            this.BT_add.Click += new System.EventHandler(this.BT_add_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 91);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 26);
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
            this.IBX_photo.Location = new System.Drawing.Point(271, 33);
            this.IBX_photo.Margin = new System.Windows.Forms.Padding(5);
            this.IBX_photo.Name = "IBX_photo";
            this.IBX_photo.OpenFileDialogTitle = "Please choose image an file";
            this.IBX_photo.PasteMenuText = "Paste image from clipboard";
            this.IBX_photo.Size = new System.Drawing.Size(236, 302);
            this.IBX_photo.TabIndex = 12;
            this.IBX_photo.TabStop = false;
            // 
            // AjouterPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 398);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.IBX_photo);
            this.Controls.Add(this.BT_add);
            this.Controls.Add(this.BT_Rotate);
            this.Controls.Add(this.BT_exit);
            this.Controls.Add(this.CB_Shared);
            this.Controls.Add(this.LB_Keywords);
            this.Controls.Add(this.LB_Description);
            this.Controls.Add(this.LB_Date);
            this.Controls.Add(this.LB_title);
            this.Controls.Add(this.RTBX_description);
            this.Controls.Add(this.TB_keyword);
            this.Controls.Add(this.TB_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(539, 437);
            this.MinimumSize = new System.Drawing.Size(539, 437);
            this.Name = "AjouterPhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter Une Photo";
            this.Load += new System.EventHandler(this.AjouterPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IBX_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_title;
        private System.Windows.Forms.TextBox TB_keyword;
        private System.Windows.Forms.RichTextBox RTBX_description;
        private System.Windows.Forms.Label LB_title;
        private System.Windows.Forms.Label LB_Date;
        private System.Windows.Forms.Label LB_Description;
        private System.Windows.Forms.Label LB_Keywords;
        private System.Windows.Forms.CheckBox CB_Shared;
        private System.Windows.Forms.Button BT_exit;
        private System.Windows.Forms.Button BT_Rotate;
        private System.Windows.Forms.Button BT_add;
        private PhotoManagerClient.ImageBox IBX_photo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}