namespace Client_PM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.CBX_UsersList = new System.Windows.Forms.ComboBox();
            this.MS_Account = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Account_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Account_Profil = new System.Windows.Forms.ToolStripMenuItem();
            this.Mi_Account_Create = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Account_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CBX_Keywords = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTN_Bottom = new System.Windows.Forms.Button();
            this.BTN_Right = new System.Windows.Forms.Button();
            this.BTN_Top = new System.Windows.Forms.Button();
            this.BTN_Left = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ViewPhoto = new PhotoManagerClient.FlashButton();
            this.DeletePhoto = new PhotoManagerClient.FlashButton();
            this.EditerPhoto = new PhotoManagerClient.FlashButton();
            this.AddNewPhoto = new PhotoManagerClient.FlashButton();
            this.PhotoBrowser = new PhotoManagerClient.PhotosBrowser();
            this.flashButton5 = new PhotoManagerClient.FlashButton();
            this.flashButton4 = new PhotoManagerClient.FlashButton();
            this.flashButton3 = new PhotoManagerClient.FlashButton();
            this.flashButton2 = new PhotoManagerClient.FlashButton();
            this.flashButton1 = new PhotoManagerClient.FlashButton();
            this.groupBox1.SuspendLayout();
            this.MS_Account.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.CBX_UsersList);
            this.groupBox1.Location = new System.Drawing.Point(451, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 23);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(222, 24);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Ne pas afficher mes photos";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // CBX_UsersList
            // 
            this.CBX_UsersList.FormattingEnabled = true;
            this.CBX_UsersList.Location = new System.Drawing.Point(6, 61);
            this.CBX_UsersList.Name = "CBX_UsersList";
            this.CBX_UsersList.Size = new System.Drawing.Size(225, 28);
            this.CBX_UsersList.TabIndex = 0;
            this.CBX_UsersList.SelectedIndexChanged += new System.EventHandler(this.CBX_UsersList_SelectedIndexChanged);
            // 
            // MS_Account
            // 
            this.MS_Account.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.toolStripMenuItem1});
            this.MS_Account.Location = new System.Drawing.Point(0, 0);
            this.MS_Account.Name = "MS_Account";
            this.MS_Account.Size = new System.Drawing.Size(1153, 24);
            this.MS_Account.TabIndex = 2;
            this.MS_Account.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Account_Login,
            this.MI_Account_Profil,
            this.Mi_Account_Create,
            this.MI_Account_Exit});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // MI_Account_Login
            // 
            this.MI_Account_Login.Name = "MI_Account_Login";
            this.MI_Account_Login.Size = new System.Drawing.Size(152, 22);
            this.MI_Account_Login.Text = "Login";
            this.MI_Account_Login.Click += new System.EventHandler(this.MI_Account_Login_Click);
            // 
            // MI_Account_Profil
            // 
            this.MI_Account_Profil.Name = "MI_Account_Profil";
            this.MI_Account_Profil.Size = new System.Drawing.Size(152, 22);
            this.MI_Account_Profil.Text = "Profil";
            this.MI_Account_Profil.Click += new System.EventHandler(this.MI_Account_Profil_Click);
            // 
            // Mi_Account_Create
            // 
            this.Mi_Account_Create.Name = "Mi_Account_Create";
            this.Mi_Account_Create.Size = new System.Drawing.Size(152, 22);
            this.Mi_Account_Create.Text = "Create";
            this.Mi_Account_Create.Click += new System.EventHandler(this.Mi_Account_Create_Click);
            // 
            // MI_Account_Exit
            // 
            this.MI_Account_Exit.Name = "MI_Account_Exit";
            this.MI_Account_Exit.Size = new System.Drawing.Size(152, 22);
            this.MI_Account_Exit.Text = "Exit";
            this.MI_Account_Exit.Click += new System.EventHandler(this.MI_Account_Exit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topToolStripMenuItem,
            this.downToolStripMenuItem,
            this.leftToolStripMenuItem,
            this.rightToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem1.Text = "Layout";
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.topToolStripMenuItem.Text = "Top";
            // 
            // downToolStripMenuItem
            // 
            this.downToolStripMenuItem.Name = "downToolStripMenuItem";
            this.downToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.downToolStripMenuItem.Text = "Down";
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.leftToolStripMenuItem.Text = "Left";
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rightToolStripMenuItem.Text = "Right";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.CBX_Keywords);
            this.groupBox2.Location = new System.Drawing.Point(195, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keyword";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(205, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Recherche avec keyword";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CBX_Keywords
            // 
            this.CBX_Keywords.FormattingEnabled = true;
            this.CBX_Keywords.Location = new System.Drawing.Point(6, 61);
            this.CBX_Keywords.Name = "CBX_Keywords";
            this.CBX_Keywords.Size = new System.Drawing.Size(225, 28);
            this.CBX_Keywords.TabIndex = 0;
            this.CBX_Keywords.SelectedIndexChanged += new System.EventHandler(this.CBX_Keywords_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.BTN_Bottom);
            this.groupBox3.Controls.Add(this.BTN_Right);
            this.groupBox3.Controls.Add(this.BTN_Top);
            this.groupBox3.Controls.Add(this.BTN_Left);
            this.groupBox3.Location = new System.Drawing.Point(958, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 105);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Placement";
            // 
            // BTN_Bottom
            // 
            this.BTN_Bottom.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Bottom.Location = new System.Drawing.Point(146, 40);
            this.BTN_Bottom.Name = "BTN_Bottom";
            this.BTN_Bottom.Size = new System.Drawing.Size(31, 36);
            this.BTN_Bottom.TabIndex = 0;
            this.BTN_Bottom.Text = "↓";
            this.BTN_Bottom.UseVisualStyleBackColor = true;
            this.BTN_Bottom.Click += new System.EventHandler(this.BTN_Bottom_Click);
            // 
            // BTN_Right
            // 
            this.BTN_Right.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Right.Location = new System.Drawing.Point(98, 41);
            this.BTN_Right.Name = "BTN_Right";
            this.BTN_Right.Size = new System.Drawing.Size(31, 36);
            this.BTN_Right.TabIndex = 0;
            this.BTN_Right.Text = "→";
            this.BTN_Right.UseVisualStyleBackColor = true;
            this.BTN_Right.Click += new System.EventHandler(this.BTN_Right_Click);
            // 
            // BTN_Top
            // 
            this.BTN_Top.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Top.Location = new System.Drawing.Point(52, 41);
            this.BTN_Top.Name = "BTN_Top";
            this.BTN_Top.Size = new System.Drawing.Size(31, 36);
            this.BTN_Top.TabIndex = 0;
            this.BTN_Top.Text = "↑";
            this.BTN_Top.UseVisualStyleBackColor = true;
            this.BTN_Top.Click += new System.EventHandler(this.BTN_Top_Click);
            // 
            // BTN_Left
            // 
            this.BTN_Left.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Left.Location = new System.Drawing.Point(6, 39);
            this.BTN_Left.Name = "BTN_Left";
            this.BTN_Left.Size = new System.Drawing.Size(31, 37);
            this.BTN_Left.TabIndex = 0;
            this.BTN_Left.Text = "← ";
            this.BTN_Left.UseVisualStyleBackColor = true;
            this.BTN_Left.Click += new System.EventHandler(this.BTN_Left_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(12, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 105);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Commands";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox3);
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Location = new System.Drawing.Point(704, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(248, 105);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Date interval";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(9, 28);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(45, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(197, 28);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.CBX_UsersList_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.CBX_UsersList_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ViewPhoto);
            this.groupBox6.Controls.Add(this.DeletePhoto);
            this.groupBox6.Controls.Add(this.EditerPhoto);
            this.groupBox6.Controls.Add(this.AddNewPhoto);
            this.groupBox6.Location = new System.Drawing.Point(12, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(177, 105);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Commands";
            // 
            // ViewPhoto
            // 
            this.ViewPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViewPhoto.BackgroundImage")));
            this.ViewPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ViewPhoto.ClickedImage = null;
            this.ViewPhoto.DisabledImage = null;
            this.ViewPhoto.Image = ((System.Drawing.Image)(resources.GetObject("ViewPhoto.Image")));
            this.ViewPhoto.Location = new System.Drawing.Point(132, 41);
            this.ViewPhoto.Name = "ViewPhoto";
            this.ViewPhoto.NeutralImage = null;
            this.ViewPhoto.OverImage = null;
            this.ViewPhoto.Size = new System.Drawing.Size(36, 36);
            this.ViewPhoto.TabIndex = 6;
            this.ViewPhoto.UseVisualStyleBackColor = true;
            this.ViewPhoto.Click += new System.EventHandler(this.ViewPhoto_Click);
            // 
            // DeletePhoto
            // 
            this.DeletePhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeletePhoto.BackgroundImage")));
            this.DeletePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeletePhoto.ClickedImage = null;
            this.DeletePhoto.DisabledImage = null;
            this.DeletePhoto.Image = ((System.Drawing.Image)(resources.GetObject("DeletePhoto.Image")));
            this.DeletePhoto.Location = new System.Drawing.Point(90, 41);
            this.DeletePhoto.Name = "DeletePhoto";
            this.DeletePhoto.NeutralImage = null;
            this.DeletePhoto.OverImage = null;
            this.DeletePhoto.Size = new System.Drawing.Size(36, 36);
            this.DeletePhoto.TabIndex = 5;
            this.DeletePhoto.UseVisualStyleBackColor = true;
            // 
            // EditerPhoto
            // 
            this.EditerPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditerPhoto.BackgroundImage")));
            this.EditerPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditerPhoto.ClickedImage = null;
            this.EditerPhoto.DisabledImage = null;
            this.EditerPhoto.Image = ((System.Drawing.Image)(resources.GetObject("EditerPhoto.Image")));
            this.EditerPhoto.Location = new System.Drawing.Point(48, 41);
            this.EditerPhoto.Name = "EditerPhoto";
            this.EditerPhoto.NeutralImage = null;
            this.EditerPhoto.OverImage = null;
            this.EditerPhoto.Size = new System.Drawing.Size(36, 36);
            this.EditerPhoto.TabIndex = 4;
            this.EditerPhoto.UseVisualStyleBackColor = true;
            this.EditerPhoto.Click += new System.EventHandler(this.EditerPhoto_Click);
            // 
            // AddNewPhoto
            // 
            this.AddNewPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddNewPhoto.BackgroundImage")));
            this.AddNewPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddNewPhoto.ClickedImage = null;
            this.AddNewPhoto.DisabledImage = null;
            this.AddNewPhoto.Image = ((System.Drawing.Image)(resources.GetObject("AddNewPhoto.Image")));
            this.AddNewPhoto.Location = new System.Drawing.Point(6, 41);
            this.AddNewPhoto.Name = "AddNewPhoto";
            this.AddNewPhoto.NeutralImage = null;
            this.AddNewPhoto.OverImage = null;
            this.AddNewPhoto.Size = new System.Drawing.Size(36, 36);
            this.AddNewPhoto.TabIndex = 3;
            this.AddNewPhoto.UseVisualStyleBackColor = true;
            this.AddNewPhoto.Click += new System.EventHandler(this.AddNewPhoto_Click);
            // 
            // PhotoBrowser
            // 
            this.PhotoBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhotoBrowser.Location = new System.Drawing.Point(12, 138);
            this.PhotoBrowser.Name = "PhotoBrowser";
            this.PhotoBrowser.Placement = PhotoManagerClient.PhotoBrowserPlacement.Left;
            this.PhotoBrowser.SelectedPhoto = null;
            this.PhotoBrowser.Size = new System.Drawing.Size(1129, 570);
            this.PhotoBrowser.TabIndex = 0;
            // 
            // flashButton5
            // 
            this.flashButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton5.ClickedImage = null;
            this.flashButton5.DisabledImage = null;
            this.flashButton5.Image = ((System.Drawing.Image)(resources.GetObject("flashButton5.Image")));
            this.flashButton5.Location = new System.Drawing.Point(123, 41);
            this.flashButton5.Name = "flashButton5";
            this.flashButton5.NeutralImage = null;
            this.flashButton5.OverImage = null;
            this.flashButton5.Size = new System.Drawing.Size(36, 36);
            this.flashButton5.TabIndex = 4;
            this.flashButton5.Text = "flashButton5";
            this.flashButton5.UseVisualStyleBackColor = true;
            // 
            // flashButton4
            // 
            this.flashButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton4.ClickedImage = null;
            this.flashButton4.DisabledImage = null;
            this.flashButton4.Image = ((System.Drawing.Image)(resources.GetObject("flashButton4.Image")));
            this.flashButton4.Location = new System.Drawing.Point(84, 41);
            this.flashButton4.Name = "flashButton4";
            this.flashButton4.NeutralImage = null;
            this.flashButton4.OverImage = null;
            this.flashButton4.Size = new System.Drawing.Size(33, 31);
            this.flashButton4.TabIndex = 3;
            this.flashButton4.Text = "flashButton1";
            this.flashButton4.UseVisualStyleBackColor = true;
            // 
            // flashButton3
            // 
            this.flashButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton3.ClickedImage = null;
            this.flashButton3.DisabledImage = null;
            this.flashButton3.Image = ((System.Drawing.Image)(resources.GetObject("flashButton3.Image")));
            this.flashButton3.Location = new System.Drawing.Point(45, 41);
            this.flashButton3.Name = "flashButton3";
            this.flashButton3.NeutralImage = null;
            this.flashButton3.OverImage = null;
            this.flashButton3.Size = new System.Drawing.Size(33, 31);
            this.flashButton3.TabIndex = 3;
            this.flashButton3.Text = "flashButton1";
            this.flashButton3.UseVisualStyleBackColor = true;
            // 
            // flashButton2
            // 
            this.flashButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton2.ClickedImage = null;
            this.flashButton2.DisabledImage = null;
            this.flashButton2.Image = ((System.Drawing.Image)(resources.GetObject("flashButton2.Image")));
            this.flashButton2.Location = new System.Drawing.Point(6, 41);
            this.flashButton2.Name = "flashButton2";
            this.flashButton2.NeutralImage = null;
            this.flashButton2.OverImage = null;
            this.flashButton2.Size = new System.Drawing.Size(33, 31);
            this.flashButton2.TabIndex = 3;
            this.flashButton2.Text = "flashButton1";
            this.flashButton2.UseVisualStyleBackColor = true;
            // 
            // flashButton1
            // 
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton1.ClickedImage = null;
            this.flashButton1.DisabledImage = null;
            this.flashButton1.Image = ((System.Drawing.Image)(resources.GetObject("flashButton1.Image")));
            this.flashButton1.Location = new System.Drawing.Point(6, 41);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.NeutralImage = null;
            this.flashButton1.OverImage = null;
            this.flashButton1.Size = new System.Drawing.Size(33, 31);
            this.flashButton1.TabIndex = 3;
            this.flashButton1.Text = "flashButton1";
            this.flashButton1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 674);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.PhotoBrowser);
            this.Controls.Add(this.MS_Account);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MS_Account;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1169, 713);
            this.Name = "MainForm";
            this.Text = "Photo manager client application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MS_Account.ResumeLayout(false);
            this.MS_Account.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhotoManagerClient.PhotosBrowser PhotoBrowser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip MS_Account;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_Account_Login;
        private System.Windows.Forms.ToolStripMenuItem MI_Account_Profil;
        private System.Windows.Forms.ToolStripMenuItem Mi_Account_Create;
        private System.Windows.Forms.ToolStripMenuItem MI_Account_Exit;
        private System.Windows.Forms.ComboBox CBX_UsersList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CBX_Keywords;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTN_Bottom;
        private System.Windows.Forms.Button BTN_Right;
        private System.Windows.Forms.Button BTN_Top;
        private System.Windows.Forms.Button BTN_Left;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private PhotoManagerClient.FlashButton flashButton1;
        private System.Windows.Forms.GroupBox groupBox6;
        private PhotoManagerClient.FlashButton flashButton4;
        private PhotoManagerClient.FlashButton flashButton3;
        private PhotoManagerClient.FlashButton flashButton2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private PhotoManagerClient.FlashButton flashButton5;
        private PhotoManagerClient.FlashButton ViewPhoto;
        private PhotoManagerClient.FlashButton DeletePhoto;
        private PhotoManagerClient.FlashButton EditerPhoto;
        private PhotoManagerClient.FlashButton AddNewPhoto;
    }
}

