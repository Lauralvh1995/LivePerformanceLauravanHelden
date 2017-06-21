using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformanceLauravanHelden
{
    public partial class EditResultForm : Form
    {
        public string partyName { get; set; }
        public int votes { get; set; }
        public EditResultForm()
        {
            InitializeComponent();
        }
        public void UpdateForm()
        {
            tbPartyName.Text = partyName;
            nudVotes.Value = votes;
        }
        private void btSend_Click(object sender, EventArgs e)
        {
            partyName = tbPartyName.Text;
            votes = (int)nudVotes.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
