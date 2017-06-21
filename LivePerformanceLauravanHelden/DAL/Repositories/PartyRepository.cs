using LivePerformanceLauravanHelden.DAL.Contexts;
using LivePerformanceLauravanHelden.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceLauravanHelden.DAL.Repositories
{
    public class PartyRepository : IRepository<Party>
    {
        public List<Party> Items { get; private set; }
        private readonly IContext<Party> _context;

        public PartyRepository(IDatabaseConnector connector)
        {
            _context = new PartyContext(connector);
            Items = new List<Party>();
        }
        public void Add(Party t)
        {
            _context.Add(t);
            Items.Add(t);
        }

        public void Delete(Party t)
        {
            _context.Delete(t);
            Items.Remove(t);
        }

        public void Refresh()
        {
            _context.Read();
        }

        public void Update(Party t)
        {
            _context.Update(t);
        }
    }
}
