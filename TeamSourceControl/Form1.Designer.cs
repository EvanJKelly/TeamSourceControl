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
            this.LinkCboBox = new System.Windows.Forms.ComboBox();
            this.Links = new System.Windows.Forms.Label();
            this.MainAddLinkButton = new System.Windows.Forms.Button();
            this.MainUpdateLinkButton = new System.Windows.Forms.Button();
            this.MainDeleteLinkButton = new System.Windows.Forms.Button();
            this.wbPlayer = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LinkCboBox
            // 
            this.LinkCboBox.FormattingEnabled = true;
            this.LinkCboBox.Location = new System.Drawing.Point(104, 30);
            this.LinkCboBox.Name = "LinkCboBox";
            this.LinkCboBox.Size = new System.Drawing.Size(210, 21);
            this.LinkCboBox.TabIndex = 0;
            this.LinkCboBox.SelectedIndexChanged += new System.EventHandler(this.LinkCboBox_SelectedIndexChanged);
            // 
            // Links
            // 
            this.Links.AutoSize = true;
            this.Links.Location = new System.Drawing.Point(49, 34);
            this.Links.Name = "Links";
            this.Links.Size = new System.Drawing.Size(35, 13);
            this.Links.TabIndex = 1;
            this.Links.Text = "Links:";
            // 
            // MainAddLinkButton
            // 
            this.MainAddLinkButton.Location = new System.Drawing.Point(680, 113);
            this.MainAddLinkButton.Name = "MainAddLinkButton";
            this.MainAddLinkButton.Size = new System.Drawing.Size(108, 50);
            this.MainAddLinkButton.TabIndex = 2;
            this.MainAddLinkButton.Text = "Add Link";
            this.MainAddLinkButton.UseVisualStyleBackColor = true;
            this.MainAddLinkButton.Click += new System.EventHandler(this.MainAddLinkButton_Click);
            // 
            // MainUpdateLinkButton
            // 
            this.MainUpdateLinkButton.Location = new System.Drawing.Point(680, 224);
            this.MainUpdateLinkButton.Name = "MainUpdateLinkButton";
            this.MainUpdateLinkButton.Size = new System.Drawing.Size(108, 54);
            this.MainUpdateLinkButton.TabIndex = 3;
            this.MainUpdateLinkButton.Text = "Update Link";
            this.MainUpdateLinkButton.UseVisualStyleBackColor = true;
            this.MainUpdateLinkButton.Click += new System.EventHandler(this.MainUpdateLinkButton_Click);
            // 
            // MainDeleteLinkButton
            // 
            this.MainDeleteLinkButton.Location = new System.Drawing.Point(680, 338);
            this.MainDeleteLinkButton.Name = "MainDeleteLinkButton";
            this.MainDeleteLinkButton.Size = new System.Drawing.Size(108, 52);
            this.MainDeleteLinkButton.TabIndex = 4;
            this.MainDeleteLinkButton.Text = "Delete Link";
            this.MainDeleteLinkButton.UseVisualStyleBackColor = true;
            this.MainDeleteLinkButton.Click += new System.EventHandler(this.MainDeleteLinkButton_Click);
            // 
            // wbPlayer
            // 
            this.wbPlayer.Location = new System.Drawing.Point(12, 75);
            this.wbPlayer.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPlayer.Name = "wbPlayer";
            this.wbPlayer.Size = new System.Drawing.Size(639, 363);
            this.wbPlayer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search: ";
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(458, 31);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(172, 20);
            this.txtSearchBar.TabIndex = 7;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wbPlayer);
            this.Controls.Add(this.MainDeleteLinkButton);
            this.Controls.Add(this.MainUpdateLinkButton);
            this.Controls.Add(this.MainAddLinkButton);
            this.Controls.Add(this.Links);
            this.Controls.Add(this.LinkCboBox);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LinkCboBox;
        private System.Windows.Forms.Label Links;
        private System.Windows.Forms.Button MainAddLinkButton;
        private System.Windows.Forms.Button MainUpdateLinkButton;
        private System.Windows.Forms.Button MainDeleteLinkButton;
        private System.Windows.Forms.WebBrowser wbPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchBar;
    }
}

