﻿namespace TeamSourceControl
{
    partial class UpdatePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePage));
            this.LinkTitlelabel = new System.Windows.Forms.Label();
            this.LinkLabel = new System.Windows.Forms.Label();
            this.UpdateTItleBox = new System.Windows.Forms.TextBox();
            this.UpdateLinkBox = new System.Windows.Forms.TextBox();
            this.UpdateLinkButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkTitlelabel
            // 
            this.LinkTitlelabel.AutoSize = true;
            this.LinkTitlelabel.Location = new System.Drawing.Point(68, 60);
            this.LinkTitlelabel.Name = "LinkTitlelabel";
            this.LinkTitlelabel.Size = new System.Drawing.Size(27, 13);
            this.LinkTitlelabel.TabIndex = 0;
            this.LinkTitlelabel.Text = "Title";
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Location = new System.Drawing.Point(71, 97);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(30, 13);
            this.LinkLabel.TabIndex = 1;
            this.LinkLabel.Text = "Link:";
            // 
            // UpdateTItleBox
            // 
            this.UpdateTItleBox.Location = new System.Drawing.Point(143, 52);
            this.UpdateTItleBox.Name = "UpdateTItleBox";
            this.UpdateTItleBox.Size = new System.Drawing.Size(223, 20);
            this.UpdateTItleBox.TabIndex = 2;
            // 
            // UpdateLinkBox
            // 
            this.UpdateLinkBox.Location = new System.Drawing.Point(143, 97);
            this.UpdateLinkBox.Name = "UpdateLinkBox";
            this.UpdateLinkBox.Size = new System.Drawing.Size(223, 20);
            this.UpdateLinkBox.TabIndex = 3;
            // 
            // UpdateLinkButton
            // 
            this.UpdateLinkButton.Location = new System.Drawing.Point(122, 177);
            this.UpdateLinkButton.Name = "UpdateLinkButton";
            this.UpdateLinkButton.Size = new System.Drawing.Size(237, 78);
            this.UpdateLinkButton.TabIndex = 4;
            this.UpdateLinkButton.Text = "Update ";
            this.UpdateLinkButton.UseVisualStyleBackColor = true;
            this.UpdateLinkButton.Click += new System.EventHandler(this.UpdateLinkButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(423, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 176);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UpdatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UpdateLinkButton);
            this.Controls.Add(this.UpdateLinkBox);
            this.Controls.Add(this.UpdateTItleBox);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.LinkTitlelabel);
            this.Name = "UpdatePage";
            this.Text = "UpdatePage";
            this.Load += new System.EventHandler(this.UpdatePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LinkTitlelabel;
        private System.Windows.Forms.Label LinkLabel;
        private System.Windows.Forms.TextBox UpdateTItleBox;
        private System.Windows.Forms.TextBox UpdateLinkBox;
        private System.Windows.Forms.Button UpdateLinkButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}