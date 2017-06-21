using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceLauravanHelden.DAL.Contexts
{
    interface IContext<T>
    {
        void Add(T t);
        List<T> Read();
        void Update(T t);
        void Delete(T t);
    }
}
