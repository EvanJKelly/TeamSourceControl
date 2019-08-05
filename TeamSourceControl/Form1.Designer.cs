namespace TeamSourceControl
{
    partial class MainPage
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
            this.LinkBox = new System.Windows.Forms.ComboBox();
            this.Links = new System.Windows.Forms.Label();
            this.AddLInk = new System.Windows.Forms.Button();
            this.UpdateLink = new System.Windows.Forms.Button();
            this.DeleteLink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LinkBox
            // 
            this.LinkBox.FormattingEnabled = true;
            this.LinkBox.Location = new System.Drawing.Point(181, 66);
            this.LinkBox.Name = "LinkBox";
            this.LinkBox.Size = new System.Drawing.Size(210, 21);
            this.LinkBox.TabIndex = 0;
            // 
            // Links
            // 
            this.Links.AutoSize = true;
            this.Links.Location = new System.Drawing.Point(130, 69);
            this.Links.Name = "Links";
            this.Links.Size = new System.Drawing.Size(35, 13);
            this.Links.TabIndex = 1;
            this.Links.Text = "Links:";
            // 
            // AddLInk
            // 
            this.AddLInk.Location = new System.Drawing.Point(520, 50);
            this.AddLInk.Name = "AddLInk";
            this.AddLInk.Size = new System.Drawing.Size(108, 50);
            this.AddLInk.TabIndex = 2;
            this.AddLInk.Text = "Add Link";
            this.AddLInk.UseVisualStyleBackColor = true;
            // 
            // UpdateLink
            // 
            this.UpdateLink.Location = new System.Drawing.Point(520, 147);
            this.UpdateLink.Name = "UpdateLink";
            this.UpdateLink.Size = new System.Drawing.Size(108, 54);
            this.UpdateLink.TabIndex = 3;
            this.UpdateLink.Text = "Update Link";
            this.UpdateLink.UseVisualStyleBackColor = true;
            // 
            // DeleteLink
            // 
            this.DeleteLink.Location = new System.Drawing.Point(520, 243);
            this.DeleteLink.Name = "DeleteLink";
            this.DeleteLink.Size = new System.Drawing.Size(108, 52);
            this.DeleteLink.TabIndex = 4;
            this.DeleteLink.Text = "Delete Link";
            this.DeleteLink.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteLink);
            this.Controls.Add(this.UpdateLink);
            this.Controls.Add(this.AddLInk);
            this.Controls.Add(this.Links);
            this.Controls.Add(this.LinkBox);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LinkBox;
        private System.Windows.Forms.Label Links;
        private System.Windows.Forms.Button AddLInk;
        private System.Windows.Forms.Button UpdateLink;
        private System.Windows.Forms.Button DeleteLink;
    }
}

