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

        public int TotalVotes;
        private Election Election { get; set; }
        public List<Party> ParticipatingParties = new List<Party>();

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
                decimal partialseats = Election.Seats * decimal.Divide(p.Votes, TotalVotes);
                p.Seats = Convert.ToInt32(partialseats);
            }
        }

        private void CalculateTotalVotes()
        {
            TotalVotes = 0;
            foreach(Party p in ParticipatingParties)
            {
                TotalVotes = TotalVotes + p.Votes;
            }
        }
    }
}
