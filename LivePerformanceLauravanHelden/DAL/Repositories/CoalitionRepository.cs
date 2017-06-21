using LivePerformanceLauravanHelden.DAL.Contexts;
using LivePerformanceLauravanHelden.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceLauravanHelden.DAL.Repositories
{
    public class CoalitionRepository : IRepository<Coalition>
    {
        public List<Coalition> Items { get; private set; }
        private readonly IContext<Coalition> _context;

        public CoalitionRepository(IDatabaseConnector connector)
        {
            _context = new CoalitionContext(connector);
            Items = new List<Coalition>();
        }
        public void Add(Coalition t)
        {
            _context.Add(t);
            Items.Add(t);
        }

        public void Delete(Coalition t)
        {
            _context.Delete(t);
            Items.Remove(t);
        }

        public void Refresh()
        {
            _context.Read();
        }

        public void Update(Coalition t)
        {
            _context.Update(t);
        }
    }
}
