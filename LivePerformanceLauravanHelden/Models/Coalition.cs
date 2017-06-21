using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceLauravanHelden.Models
{
    public class Coalition
    {
        public string PrimeMinister { get; set; }
        public string Name { get; set; }
        public int Seats { get; set; }
        public bool InPower { get; set; }

        public List<Party> CoalitionParties = new List<Party>();

        public Coalition(string primeMinister, string name)
        {
            PrimeMinister = primeMinister;
            Name = name;
        }

        public void SetInPower(bool power)
        {
            InPower = power;
        }

        public void AddParty(Party party)
        {
            CoalitionParties.Add(party);
            Seats = 0;
            foreach(Party p in CoalitionParties)
            {
                Seats = Seats + p.Seats;
            }
        }
    }
}
