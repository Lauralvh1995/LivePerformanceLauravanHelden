using LivePerformanceLauravanHelden.DAL.Contexts;
using LivePerformanceLauravanHelden.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceLauravanHelden.DAL.Repositories
{
    public class ElectionRepository : IRepository<Election>
    {
        public List<Election> Items { get; private set; }
        private readonly IContext<Election> _context;

        public ElectionRepository(IDatabaseConnector connector)
        {
            _context = new ElectionContext(connector);
            Items = new List<Election>();
        }
        public void Add(Election t)
        {
            _context.Add(t);
            Items.Add(t);
        }

        public void Delete(Election t)
        {
            _context.Delete(t);
            Items.Remove(t);
        }

        public void Refresh()
        {
            _context.Read();
        }

        public void Update(Election t)
        {
            _context.Update(t);
        }
    }
}
