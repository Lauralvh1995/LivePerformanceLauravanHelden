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

namespace LivePerformanceLauravanHelden.Forms
{
    public partial class OverviewForm : Form
    {
        public Coalition coalition { get; set; }
        public Election election { get; set; }
        public Results results { get; set; }
        string PrimeMinister { get; set; }

        public OverviewForm(Coalition coalition)
        {
            GetPrimeMinister(coalition);
            InitializeComponent();
        }

        private void btSaveCoalition_Click(object sender, EventArgs e)
        {
            coalition.Name = tbCoalitionName.Text;
            coalition.PrimeMinister = PrimeMinister;
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            string[] export = {@"Coalitievoorstel "+election.Name,
                                "=============================",
                                "",
                                "Van: Tjeerd Willink",
                                "Aan: Z.M. Koning Willem-Alexander: Majesteit",
                                "Partij     "+"Zetels       "+"Lijsttrekker     ",
                                PrintParties(coalition).ToString(),
                                "Totaal aantal Zetels: "+ coalition.Seats+" Premier: "+coalition.PrimeMinister
            };
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\laura\Documents\School\Live Performance\LivePerformanceLauravanHelden\Exports\"+coalition.Name))
            {
                foreach (string line in export)
                {
                    file.WriteLine(line);
                }
            }
        }
        public void GetPrimeMinister(Coalition coalition)
        {
            coalition.CoalitionParties.Sort();
            PrimeMinister = coalition.CoalitionParties[0].PartyLeader;
        }

        public string PrintParties(Coalition coalition)
        {
            string print="";
            foreach(Party p in coalition.CoalitionParties)
            {
                print = @print +Environment.NewLine+ @p.Name + @"      "+ @p.Seats+@"        "+@p.PartyLeader;
            }
            return print;
        }
    }
}
