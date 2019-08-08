using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamSourceControl
{
    public partial class UpdatePage : Form
    {
        public UpdatePage(Link link)
        {
            InitializeComponent();
            existinglink = link;
            if(link != null)
            {
                UpdateTItleBox.Text = existinglink.LinkTitle;
                UpdateLinkBox.Text = existinglink.LinkURL;
            }
        }
        public Link existinglink;

        public void FormUpdateLink(Link l = null)
        {
            
            existinglink = l;

            if(l != null)
            {
                UpdateTItleBox.Text = existinglink.LinkTitle;
                UpdateLinkBox.Text = existinglink.LinkURL;

            }
        }



        private void UpdatePage_Load(object sender, EventArgs e)
        {

        }

        private void UpdateLinkButton_Click(object sender, EventArgs e)
        {
            Link link = new Link()
            {
                LinkTitle = UpdateTItleBox.Text,
                LinkURL = UpdateLinkBox.Text
            };
            try
            {
                if (existinglink != null)
                {
                    link.LinkId = existinglink.LinkId;
                    LinkDB.Update(link);
                    MessageBox.Show("Link Updated!");
                }


                Close();
            }
            catch (SqlException )
            {

                MessageBox.Show("It didn't work.");
            }
        }
    }
}
