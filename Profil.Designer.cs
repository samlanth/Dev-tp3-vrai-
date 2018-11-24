namespace Client_PM
{
    partial class Profil
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
            this.BTN_DeleteAccount = new System.Windows.Forms.Button();
            this.BTN_Change = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBX_VerifyPassword = new System.Windows.Forms.TextBox();
            this.TBX_Password = new System.Windows.Forms.TextBox();
            this.TBX_Username = new System.Windows.Forms.TextBox();
            this.IBX_Avatar = new PhotoManagerClient.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.IBX_Avatar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_DeleteAccount
            // 
            this.BTN_DeleteAccount.Location = new System.Drawing.Point(241, 170);
            this.BTN_DeleteAccount.Name = "BTN_DeleteAccount";
            this.BTN_DeleteAccount.Size = new System.Drawing.Size(92, 29);
            this.BTN_DeleteAccount.TabIndex = 5;
            this.BTN_DeleteAccount.Text = "Delete";
            this.BTN_DeleteAccount.UseVisualStyleBackColor = true;
            // 
            // BTN_Change
            // 
            this.BTN_Change.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Change.Location = new System.Drawing.Point(355, 170);
            this.BTN_Change.Name = "BTN_Change";
            this.BTN_Change.Size = new System.Drawing.Size(92, 29);
            this.BTN_Change.TabIndex = 14;
            this.BTN_Change.Text = "Changer";
            this.BTN_Change.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(471, 170);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(92, 29);
            this.BTN_Cancel.TabIndex = 15;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vérification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // TBX_VerifyPassword
            // 
            this.TBX_VerifyPassword.Location = new System.Drawing.Point(78, 106);
            this.TBX_VerifyPassword.Name = "TBX_VerifyPassword";
            this.TBX_VerifyPassword.Size = new System.Drawing.Size(201, 20);
            this.TBX_VerifyPassword.TabIndex = 13;
            this.TBX_VerifyPassword.UseSystemPasswordChar = true;
            // 
            // TBX_Password
            // 
            this.TBX_Password.Location = new System.Drawing.Point(78, 72);
            this.TBX_Password.Name = "TBX_Password";
            this.TBX_Password.Size = new System.Drawing.Size(201, 20);
            this.TBX_Password.TabIndex = 11;
            this.TBX_Password.UseSystemPasswordChar = true;
            // 
            // TBX_Username
            // 
            this.TBX_Username.Location = new System.Drawing.Point(78, 40);
            this.TBX_Username.Name = "TBX_Username";
            this.TBX_Username.Size = new System.Drawing.Size(201, 20);
            this.TBX_Username.TabIndex = 6;
            // 
            // IBX_Avatar
            // 
            this.IBX_Avatar.AllowDrop = true;
            this.IBX_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IBX_Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IBX_Avatar.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.IBX_Avatar.ImportImageText = "Import image from file...";
            this.IBX_Avatar.Location = new System.Drawing.Point(12, 12);
            this.IBX_Avatar.Name = "IBX_Avatar";
            this.IBX_Avatar.OpenFileDialogTitle = "Please choose image an file";
            this.IBX_Avatar.PasteMenuText = "Paste image from clipboard";
            this.IBX_Avatar.Size = new System.Drawing.Size(250, 152);
            this.IBX_Avatar.TabIndex = 12;
            this.IBX_Avatar.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBX_Username);
            this.groupBox1.Controls.Add(this.TBX_Password);
            this.groupBox1.Controls.Add(this.TBX_VerifyPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(268, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 152);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information de base";
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 215);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_DeleteAccount);
            this.Controls.Add(this.BTN_Change);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.IBX_Avatar);
            this.Name = "Profil";
            this.Text = "Changer Profil";
            ((System.ComponentModel.ISupportInitialize)(this.IBX_Avatar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_DeleteAccount;
        private System.Windows.Forms.Button BTN_Change;
        private System.Windows.Forms.Button BTN_Cancel;
        private PhotoManagerClient.ImageBox IBX_Avatar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBX_VerifyPassword;
        private System.Windows.Forms.TextBox TBX_Password;
        private System.Windows.Forms.TextBox TBX_Username;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}