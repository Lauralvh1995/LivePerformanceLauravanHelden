using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceLauravanHelden.Models
{
    public class Results
    {
        public string Name { get; set; }

        private int TotalVotes;
        private Election Election { get; set; }
        private List<Party> ParticipatingParties = new List<Party>();

        public Results(string name, Election election)
        {
            Name = name;
            Election = election;
        }

        public void CalculateSeats()
        {
            CalculateTotalVotes();
            foreach(Party p in ParticipatingParties)
            {
                p.Seats = p.Votes / TotalVotes * Election.Seats;
            }
        }

        private void CalculateTotalVotes()
        {
            foreach(Party p in ParticipatingParties)
            {
                TotalVotes = TotalVotes + p.Votes;
            }
        }
    }
}
