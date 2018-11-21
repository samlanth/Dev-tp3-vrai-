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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBX_VerifyPassword = new System.Windows.Forms.TextBox();
            this.TBX_Password = new System.Windows.Forms.TextBox();
            this.TBX_Username = new System.Windows.Forms.TextBox();
            this.IBX_Avatar = new PhotoManagerClient.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.IBX_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_DeleteAccount
            // 
            this.BTN_DeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_DeleteAccount.Location = new System.Drawing.Point(39, 398);
            this.BTN_DeleteAccount.Name = "BTN_DeleteAccount";
            this.BTN_DeleteAccount.Size = new System.Drawing.Size(116, 29);
            this.BTN_DeleteAccount.TabIndex = 5;
            this.BTN_DeleteAccount.Text = "Supprimer";
            this.BTN_DeleteAccount.UseVisualStyleBackColor = true;
            // 
            // BTN_Change
            // 
            this.BTN_Change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Change.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Change.Location = new System.Drawing.Point(161, 398);
            this.BTN_Change.Name = "BTN_Change";
            this.BTN_Change.Size = new System.Drawing.Size(75, 29);
            this.BTN_Change.TabIndex = 14;
            this.BTN_Change.Text = "Change";
            this.BTN_Change.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(242, 398);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 29);
            this.BTN_Cancel.TabIndex = 15;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Avatar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vérification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom d\'usager";
            // 
            // TBX_VerifyPassword
            // 
            this.TBX_VerifyPassword.Location = new System.Drawing.Point(133, 91);
            this.TBX_VerifyPassword.Name = "TBX_VerifyPassword";
            this.TBX_VerifyPassword.Size = new System.Drawing.Size(173, 20);
            this.TBX_VerifyPassword.TabIndex = 13;
            this.TBX_VerifyPassword.UseSystemPasswordChar = true;
            // 
            // TBX_Password
            // 
            this.TBX_Password.Location = new System.Drawing.Point(133, 55);
            this.TBX_Password.Name = "TBX_Password";
            this.TBX_Password.Size = new System.Drawing.Size(173, 20);
            this.TBX_Password.TabIndex = 11;
            this.TBX_Password.UseSystemPasswordChar = true;
            // 
            // TBX_Username
            // 
            this.TBX_Username.Location = new System.Drawing.Point(133, 21);
            this.TBX_Username.Name = "TBX_Username";
            this.TBX_Username.Size = new System.Drawing.Size(173, 20);
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
            this.IBX_Avatar.Location = new System.Drawing.Point(39, 148);
            this.IBX_Avatar.Name = "IBX_Avatar";
            this.IBX_Avatar.OpenFileDialogTitle = "Please choose image an file";
            this.IBX_Avatar.PasteMenuText = "Paste image from clipboard";
            this.IBX_Avatar.Size = new System.Drawing.Size(297, 236);
            this.IBX_Avatar.TabIndex = 12;
            this.IBX_Avatar.TabStop = false;
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 434);
            this.Controls.Add(this.BTN_DeleteAccount);
            this.Controls.Add(this.BTN_Change);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.IBX_Avatar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_VerifyPassword);
            this.Controls.Add(this.TBX_Password);
            this.Controls.Add(this.TBX_Username);
            this.Name = "Profil";
            this.Text = "Profil";
            ((System.ComponentModel.ISupportInitialize)(this.IBX_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_DeleteAccount;
        private System.Windows.Forms.Button BTN_Change;
        private System.Windows.Forms.Button BTN_Cancel;
        private PhotoManagerClient.ImageBox IBX_Avatar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBX_VerifyPassword;
        private System.Windows.Forms.TextBox TBX_Password;
        private System.Windows.Forms.TextBox TBX_Username;
    }
}