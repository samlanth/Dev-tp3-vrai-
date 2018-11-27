namespace Client_PM
{
    partial class Update
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
            this.BT_Update = new System.Windows.Forms.Button();
            this.BT_Rotate = new System.Windows.Forms.Button();
            this.BT_exit = new System.Windows.Forms.Button();
            this.CB_Shared = new System.Windows.Forms.CheckBox();
            this.LB_Keywords = new System.Windows.Forms.Label();
            this.LB_Description = new System.Windows.Forms.Label();
            this.LB_Date = new System.Windows.Forms.Label();
            this.LB_title = new System.Windows.Forms.Label();
            this.RTBX_description = new System.Windows.Forms.RichTextBox();
            this.TB_keyword = new System.Windows.Forms.TextBox();
            this.TB_title = new System.Windows.Forms.TextBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.IBX_photo = new PhotoManagerClient.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.IBX_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Update
            // 
            this.BT_Update.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BT_Update.Location = new System.Drawing.Point(358, 575);
            this.BT_Update.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(137, 48);
            this.BT_Update.TabIndex = 24;
            this.BT_Update.Text = "Update";
            this.BT_Update.UseVisualStyleBackColor = true;
            this.BT_Update.Click += new System.EventHandler(this.BT_Update_Click);
            // 
            // BT_Rotate
            // 
            this.BT_Rotate.Location = new System.Drawing.Point(30, 577);
            this.BT_Rotate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BT_Rotate.Name = "BT_Rotate";
            this.BT_Rotate.Size = new System.Drawing.Size(137, 48);
            this.BT_Rotate.TabIndex = 23;
            this.BT_Rotate.Text = "Rotate";
            this.BT_Rotate.UseVisualStyleBackColor = true;
            this.BT_Rotate.Click += new System.EventHandler(this.BT_Rotate_Click);
            // 
            // BT_exit
            // 
            this.BT_exit.Location = new System.Drawing.Point(193, 577);
            this.BT_exit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BT_exit.Name = "BT_exit";
            this.BT_exit.Size = new System.Drawing.Size(137, 48);
            this.BT_exit.TabIndex = 22;
            this.BT_exit.Text = "Cancel";
            this.BT_exit.UseVisualStyleBackColor = true;
            this.BT_exit.Click += new System.EventHandler(this.BT_exit_Click);
            // 
            // CB_Shared
            // 
            this.CB_Shared.AutoSize = true;
            this.CB_Shared.Location = new System.Drawing.Point(25, 177);
            this.CB_Shared.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CB_Shared.Name = "CB_Shared";
            this.CB_Shared.Size = new System.Drawing.Size(86, 24);
            this.CB_Shared.TabIndex = 21;
            this.CB_Shared.Text = "Shared";
            this.CB_Shared.UseVisualStyleBackColor = true;
            // 
            // LB_Keywords
            // 
            this.LB_Keywords.AutoSize = true;
            this.LB_Keywords.Location = new System.Drawing.Point(25, 254);
            this.LB_Keywords.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LB_Keywords.Name = "LB_Keywords";
            this.LB_Keywords.Size = new System.Drawing.Size(85, 20);
            this.LB_Keywords.TabIndex = 20;
            this.LB_Keywords.Text = "Keywords";
            // 
            // LB_Description
            // 
            this.LB_Description.AutoSize = true;
            this.LB_Description.Location = new System.Drawing.Point(25, 108);
            this.LB_Description.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LB_Description.Name = "LB_Description";
            this.LB_Description.Size = new System.Drawing.Size(100, 20);
            this.LB_Description.TabIndex = 19;
            this.LB_Description.Text = "Description";
            // 
            // LB_Date
            // 
            this.LB_Date.AutoSize = true;
            this.LB_Date.Location = new System.Drawing.Point(25, 58);
            this.LB_Date.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LB_Date.Name = "LB_Date";
            this.LB_Date.Size = new System.Drawing.Size(48, 20);
            this.LB_Date.TabIndex = 18;
            this.LB_Date.Text = "Date";
            // 
            // LB_title
            // 
            this.LB_title.AutoSize = true;
            this.LB_title.Location = new System.Drawing.Point(25, 14);
            this.LB_title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LB_title.Name = "LB_title";
            this.LB_title.Size = new System.Drawing.Size(45, 20);
            this.LB_title.TabIndex = 17;
            this.LB_title.Text = "Titre";
            // 
            // RTBX_description
            // 
            this.RTBX_description.Location = new System.Drawing.Point(140, 108);
            this.RTBX_description.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.RTBX_description.Name = "RTBX_description";
            this.RTBX_description.Size = new System.Drawing.Size(354, 122);
            this.RTBX_description.TabIndex = 16;
            this.RTBX_description.Text = "";
            // 
            // TB_keyword
            // 
            this.TB_keyword.Location = new System.Drawing.Point(140, 254);
            this.TB_keyword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TB_keyword.Name = "TB_keyword";
            this.TB_keyword.Size = new System.Drawing.Size(354, 26);
            this.TB_keyword.TabIndex = 15;
            // 
            // TB_title
            // 
            this.TB_title.Location = new System.Drawing.Point(138, 14);
            this.TB_title.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TB_title.Name = "TB_title";
            this.TB_title.Size = new System.Drawing.Size(354, 26);
            this.TB_title.TabIndex = 13;
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(138, 58);
            this.DTP_Date.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(356, 26);
            this.DTP_Date.TabIndex = 26;
            // 
            // IBX_photo
            // 
            this.IBX_photo.AllowDrop = true;
            this.IBX_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IBX_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IBX_photo.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.IBX_photo.ImportImageText = "Import image from file...";
            this.IBX_photo.Location = new System.Drawing.Point(30, 311);
            this.IBX_photo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.IBX_photo.Name = "IBX_photo";
            this.IBX_photo.OpenFileDialogTitle = "Please choose image an file";
            this.IBX_photo.PasteMenuText = "Paste image from clipboard";
            this.IBX_photo.Size = new System.Drawing.Size(464, 254);
            this.IBX_photo.TabIndex = 25;
            this.IBX_photo.TabStop = false;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 637);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.IBX_photo);
            this.Controls.Add(this.BT_Update);
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
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IBX_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhotoManagerClient.ImageBox IBX_photo;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_Rotate;
        private System.Windows.Forms.Button BT_exit;
        private System.Windows.Forms.CheckBox CB_Shared;
        private System.Windows.Forms.Label LB_Keywords;
        private System.Windows.Forms.Label LB_Description;
        private System.Windows.Forms.Label LB_Date;
        private System.Windows.Forms.Label LB_title;
        private System.Windows.Forms.RichTextBox RTBX_description;
        private System.Windows.Forms.TextBox TB_keyword;
        private System.Windows.Forms.TextBox TB_title;
        private System.Windows.Forms.DateTimePicker DTP_Date;
    }
}