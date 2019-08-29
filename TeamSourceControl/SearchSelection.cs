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
    public partial class SearchSelection : Form
    {

        public SearchSelection()
        {
            InitializeComponent();
        }
        
        public void PopulateSelectionComboBox(List<string> potentialSearches)
        {
            for(int i = 0; i < potentialSearches.Count; i++)
            {
                cboSearchSelection.Items.Add(potentialSearches[i]);
            }
        }

        private void cboSearchSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
