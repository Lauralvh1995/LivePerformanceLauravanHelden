using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceLauravanHelden.Models
{
    public class Party
    {
        public string Name { get; set; }
        public string PartyLeader { get; set; }
        public int AmountOfMembers { get; set; }
        public int Votes { get; set; }
        public int Seats { get; set; }
        public bool InPower { get; set; }

        public Party(string name, string partyLeader, int members)
        {
            Name = name;
            PartyLeader = partyLeader;
            AmountOfMembers = members;
        }

        public void SetInPower(bool power)
        {
            InPower = power;
        }
    }
}
