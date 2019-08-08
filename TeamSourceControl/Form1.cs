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
            PopulateLinkComboBox();
        }

        private void MainDeleteLinkButton_Click(object sender, EventArgs e)
        {
            if (LinkCboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a student!");
                return;
            }

            Link link = LinkCboBox.SelectedItem as Link;

            string msg = $"Are you sure you want to delete {link.LinkTitle} \n" +
                $"{link.LinkURL}";

            DialogResult answer = MessageBox.Show(msg, "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes)
            {
                LinkDB.Delete(link.LinkTitle);
                PopulateLinkComboBox();
                MessageBox.Show("Link deleted successfully");
            }
        }
        private void PopulateLinkComboBox()
        {
            List<Link> links = LinkDB.GetAllLinks();
            links = links.OrderBy(link => link.LinkTitle).ToList();

            LinkCboBox.Items.Clear();

            foreach(Link l in links)
            {
                LinkCboBox.Items.Add(l);
            }
        }
        private void MainUpdateLinkButton_Click(object sender, EventArgs e)
        {
            DisplayUpdateForm();
            PopulateLinkComboBox();

        }

        private void DisplayUpdateForm()
        {
            var updateForm = new UpdatePage(LinkCboBox.SelectedItem as Link);
            updateForm.ShowDialog();
            
        }

        private void MainAddLinkButton_Click(object sender, EventArgs e)
        {
            AddPage addlink = new AddPage();
            addlink.ShowDialog();
            PopulateLinkComboBox();
        }
    }
}
