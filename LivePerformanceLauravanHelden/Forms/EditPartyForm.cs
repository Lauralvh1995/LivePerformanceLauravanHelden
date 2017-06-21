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
    public partial class EditPartyForm : Form
    {
        public string partyName { get; set; }
        public string partyLeader { get; set; }
        public int amMembers { get; set; }
        public EditPartyForm()
        {
            InitializeComponent();
        }

        public void UpdateForm()
        {
            tbPartyName.Text = partyName;
            tbPartyLeaderName.Text = partyLeader;
            nudAmMembers.Value = amMembers;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            partyName = tbPartyName.Text;
            partyLeader = tbPartyLeaderName.Text;
            amMembers = (int)nudAmMembers.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
