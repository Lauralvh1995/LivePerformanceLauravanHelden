using LivePerformanceLauravanHelden.DAL;
using LivePerformanceLauravanHelden.DAL.DatabaseConnection;
using LivePerformanceLauravanHelden.DAL.Repositories;
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
        public Coalition Coalition { get; set; }
        public Election Election { get; set; }
        public Results Results { get; set; }
        string PrimeMinister { get; set; }

        private IDatabaseConnector _connector;
        private CoalitionRepository _coalitionRepo;

        public OverviewForm(Coalition coalition)
        {
            _connector = new SQLServerConnector();
            _coalitionRepo = new CoalitionRepository(_connector);
            Coalition = coalition;
            GetPrimeMinister(coalition);
            InitializeComponent();
        }

        private void btSaveCoalition_Click(object sender, EventArgs e)
        {
            Coalition.Name = tbCoalitionName.Text;
            Coalition.PrimeMinister = PrimeMinister;
            _coalitionRepo.Add(Coalition);
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            string[] export = {@"Coalitievoorstel "+Election.Name,
                                "=============================",
                                "",
                                "Van: Tjeerd Willink",
                                "Aan: Z.M. Koning Willem-Alexander: Majesteit",
                                "Partij     "+"Zetels       "+"Lijsttrekker     ",
                                PrintParties(Coalition).ToString(),
                                "Totaal aantal Zetels: "+ Coalition.Seats+" Premier: "+Coalition.PrimeMinister
            };
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\laura\Documents\School\Live Performance\LivePerformanceLauravanHelden\Exports\"+Coalition.Name+".txt"))
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
