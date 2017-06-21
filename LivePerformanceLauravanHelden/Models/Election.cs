using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceLauravanHelden.Models
{
    public class Election
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public int Majority { get; set; }
        private List<Results> ElectionResults = new List<Results>();

        public Election(string name, int seats)
        {
            Name = name;
            Seats = seats;
            Majority = CalculateMajority(Seats);
        }

        private int CalculateMajority(int seats)
        {
            int i = seats/2+1;
            return i;
        }
    }
}
