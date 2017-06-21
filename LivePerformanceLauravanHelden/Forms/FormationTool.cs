using LivePerformanceLauravanHelden.Models;
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
    public partial class FormationTool : Form
    {
        public Election TK2017;
        public Results results;
        public Coalition coalition;

        private List<string> partyInfo = new List<string>();

        public FormationTool()
        {
            InitializeComponent();
            TK2017 = new Election("Tweede Kamerverkiezingen 2017", 150);
            results = new Results("Resultaten " + TK2017.Name, TK2017);
            coalition = new Coalition("", "");
            UpdateCListbox();
            lbAmSeats.Text = coalition.Seats.ToString();
        }

        private void btCreateFormation_Click(object sender, EventArgs e)
        {

        }

        private void btResults_Click(object sender, EventArgs e)
        {
            try
            {
                Party p = null;
                EditResultForm editResult = new EditResultForm();

                foreach (Party party in results.ParticipatingParties)
                {
                    if (GetPartyByName(cLBParties.SelectedItem.ToString()) == party)
                    {
                        p = party;
                    }
                }
                editResult.partyName = p.Name;
                editResult.votes = p.Votes;

                editResult.UpdateForm();

                editResult.ShowDialog();

                if (editResult.DialogResult == DialogResult.OK)
                {
                    p.Votes = editResult.votes;
                }
            }
            catch
            {
                MessageBox.Show("Selecteer een partij, alstublieft.");
            }
            UpdateCListbox();
        }
        private void btCalculateSeats_Click(object sender, EventArgs e)
        {
            results.CalculateSeats();
            UpdateCListbox();
        }

        private void btAddParty_Click(object sender, EventArgs e)
        {
            Party p;
            AddPartyForm addParty = new AddPartyForm();
            addParty.ShowDialog();

            if (addParty.DialogResult == DialogResult.OK)
            {
                p = new Party(addParty.partyName, addParty.partyLeader, addParty.amMembers);
                results.ParticipatingParties.Add(p);
            }
            UpdateCListbox();
        }

        private void btEditParty_Click(object sender, EventArgs e)
        {
            try
            {
                Party p = null;
                EditPartyForm editParty = new EditPartyForm();

                foreach (Party party in results.ParticipatingParties)
                {
                    if (GetPartyByName(cLBParties.SelectedItem.ToString()) == party)
                    {
                        p = party;
                    }
                }
                editParty.partyName = p.Name;
                editParty.partyLeader = p.PartyLeader;
                editParty.amMembers = p.AmountOfMembers;

                editParty.UpdateForm();

                editParty.ShowDialog();

                if (editParty.DialogResult == DialogResult.OK)
                {
                    p.Name = editParty.partyName;
                    p.PartyLeader = editParty.partyLeader;
                    p.AmountOfMembers = editParty.amMembers;
                }
            }
            catch
            {
                MessageBox.Show("Selecteer een partij, alstublieft.");
            }
            UpdateCListbox();
        }

        private void cLBParties_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                coalition.CoalitionParties.Clear();
                foreach (string i in cLBParties.CheckedItems.OfType<string>().ToList())
                {
                    if (e.NewValue == CheckState.Checked)
                    {
                        coalition.CoalitionParties.Add(GetPartyByName(i));
                    }

                }
                coalition.Seats = 0;
                foreach (Party p in coalition.CoalitionParties)
                {
                    coalition.Seats = coalition.Seats + p.Seats;
                }
                if (coalition.Seats >= TK2017.Majority)
                {
                    lbIsMajority.Text = "Ja";
                }
                else
                {
                    lbIsMajority.Text = "Nee";
                }
            }
            ));
        }

        public Party GetPartyByName(string entry)
        {
            string[] tempEntries = entry.Split(' ');
            foreach (Party p in results.ParticipatingParties)
            {
                if (p.Name == tempEntries[0])
                {
                    return p;
                }
            }
            return null;
        }

        public void UpdateCListbox()
        {
            cLBParties.Items.Clear();
            partyInfo.Clear();
            foreach (Party p in results.ParticipatingParties)
            {
                partyInfo.Add(p.Name + " " + p.PartyLeader + " " + p.Votes + " " + p.Seats);
            }
            foreach (string s in partyInfo)
            {
                cLBParties.Items.Add(s);
            }
        }


    }
}
