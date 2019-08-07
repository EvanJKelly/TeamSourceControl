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
    public partial class MainPage : Form
    {

        public MainPage()
        {
            
            InitializeComponent();
        }

        private void MainDeleteLinkButton_Click(object sender, EventArgs e)
        {
            if(LinkCboBox.SelectedIndex >= 0)
            {
                LinkCboBox.Items.RemoveAt(LinkCboBox.SelectedIndex);
            }
        }

        private void MainAddLinkButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
