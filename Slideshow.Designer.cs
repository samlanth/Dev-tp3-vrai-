﻿namespace Client_PM
{
    partial class Slideshow
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(-10, -11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "Select photos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(-10, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 77);
            this.button3.TabIndex = 2;
            this.button3.Text = "Slide show";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Slideshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 132);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Slideshow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slideshow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Slideshow_FormClosing);
            this.Load += new System.EventHandler(this.Slideshow_Load);
            this.Shown += new System.EventHandler(this.Slideshow_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}