using LivePerformanceLauravanHelden.DAL.Contexts;
using LivePerformanceLauravanHelden.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceLauravanHelden.DAL.Repositories
{
    public class ResultsRepository : IRepository<Results>
    {
        public List<Results> Items { get; private set; }
        private readonly IContext<Results> _context;

        public ResultsRepository(IDatabaseConnector connector)
        {
            _context = new ResultsContext(connector);
            Items = new List<Results>();
        }
        public void Add(Results t)
        {
            _context.Add(t);
            Items.Add(t);
        }

        public void Delete(Results t)
        {
            _context.Delete(t);
            Items.Remove(t);
        }

        public void Refresh()
        {
            _context.Read();
        }

        public void Update(Results t)
        {
            _context.Update(t);
        }
    }
}
