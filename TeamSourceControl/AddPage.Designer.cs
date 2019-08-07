namespace TeamSourceControl
{
    partial class AddPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddTitleBox = new System.Windows.Forms.TextBox();
            this.AddLinkiBox = new System.Windows.Forms.TextBox();
            this.AddLinkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Link";
            // 
            // AddTitleBox
            // 
            this.AddTitleBox.Location = new System.Drawing.Point(340, 58);
            this.AddTitleBox.Name = "AddTitleBox";
            this.AddTitleBox.Size = new System.Drawing.Size(100, 20);
            this.AddTitleBox.TabIndex = 2;
            // 
            // AddLinkiBox
            // 
            this.AddLinkiBox.Location = new System.Drawing.Point(340, 104);
            this.AddLinkiBox.Name = "AddLinkiBox";
            this.AddLinkiBox.Size = new System.Drawing.Size(100, 20);
            this.AddLinkiBox.TabIndex = 3;
            // 
            // AddLinkButton
            // 
            this.AddLinkButton.Location = new System.Drawing.Point(303, 175);
            this.AddLinkButton.Name = "AddLinkButton";
            this.AddLinkButton.Size = new System.Drawing.Size(137, 55);
            this.AddLinkButton.TabIndex = 4;
            this.AddLinkButton.Text = "Add Link";
            this.AddLinkButton.UseVisualStyleBackColor = true;
            this.AddLinkButton.Click += new System.EventHandler(this.AddLinkButton_Click);
            // 
            // AddPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddLinkButton);
            this.Controls.Add(this.AddLinkiBox);
            this.Controls.Add(this.AddTitleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPage";
            this.Text = "AddPage";
            this.Load += new System.EventHandler(this.AddPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddTitleBox;
        private System.Windows.Forms.TextBox AddLinkiBox;
        private System.Windows.Forms.Button AddLinkButton;
    }
}