namespace TeamSourceControl
{
    partial class SearchSelection
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
            this.cboSearchSelection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboSearchSelection
            // 
            this.cboSearchSelection.FormattingEnabled = true;
            this.cboSearchSelection.Location = new System.Drawing.Point(12, 12);
            this.cboSearchSelection.Name = "cboSearchSelection";
            this.cboSearchSelection.Size = new System.Drawing.Size(282, 21);
            this.cboSearchSelection.TabIndex = 0;
            this.cboSearchSelection.SelectedIndexChanged += new System.EventHandler(this.cboSearchSelection_SelectedIndexChanged);
            // 
            // SearchSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 46);
            this.Controls.Add(this.cboSearchSelection);
            this.Name = "SearchSelection";
            this.Text = "SearchSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSearchSelection;
    }
}