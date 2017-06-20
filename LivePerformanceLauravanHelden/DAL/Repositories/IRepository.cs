using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceLauravanHelden.DAL.Repositories
{
    interface IRepository<T>
    {
        void Add(T t);
        void Refresh();
        void Update(T t);
        void Delete(T t);
    }
}
