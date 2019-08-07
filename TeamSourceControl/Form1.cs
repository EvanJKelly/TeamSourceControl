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
            if (LinkCboBox.SelectedItem != null)
            {
                LinkCboBox.Items.Remove(LinkCboBox.SelectedItem);
            }
        }
    }

   
}
