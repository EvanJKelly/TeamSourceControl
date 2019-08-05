namespace TeamSourceControl
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
            this.LinkTitle = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.UpdateLink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LinkTitle
            // 
            this.LinkTitle.AutoSize = true;
            this.LinkTitle.Location = new System.Drawing.Point(262, 85);
            this.LinkTitle.Name = "LinkTitle";
            this.LinkTitle.Size = new System.Drawing.Size(27, 13);
            this.LinkTitle.TabIndex = 0;
            this.LinkTitle.Text = "Title";
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Location = new System.Drawing.Point(265, 122);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(30, 13);
            this.Link.TabIndex = 1;
            this.Link.Text = "Link:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(337, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(337, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 20);
            this.textBox2.TabIndex = 3;
            // 
            // UpdateLink
            // 
            this.UpdateLink.Location = new System.Drawing.Point(316, 202);
            this.UpdateLink.Name = "UpdateLink";
            this.UpdateLink.Size = new System.Drawing.Size(237, 78);
            this.UpdateLink.TabIndex = 4;
            this.UpdateLink.Text = "Update ";
            this.UpdateLink.UseVisualStyleBackColor = true;
            // 
            // UpdatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateLink);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.LinkTitle);
            this.Name = "UpdatePage";
            this.Text = "UpdatePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LinkTitle;
        private System.Windows.Forms.Label Link;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button UpdateLink;
    }
}