using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamSourceControl
{
    public partial class AddPage : Form
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void AddLinkButton_Click(object sender, EventArgs e)
        {
            Link link = new Link()
            {
                LinkTitle = AddTitleBox.Text,
                LinkURL = AddLinkiBox.Text
                
            };

            LinkDB.Add(link);
            MessageBox.Show("Link added!");
            Close();
        }
    }
}
