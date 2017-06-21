using LivePerformanceLauravanHelden.DAL.Extensions;
using LivePerformanceLauravanHelden.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceLauravanHelden.DAL.Contexts
{
    public class ElectionContext : IContext<Election>
    {
        private readonly IDatabaseConnector _connector;
        public ElectionContext(IDatabaseConnector connector)
        {
            _connector = connector;
        }
        public void Add(Election t)
        {
            IDbCommand command = _connector.CreateCommand();
            command.CommandText = "INSERT INTO [Verkiezing] ([Naam], [AantalZetels]) VALUES (@name, @seats);";
            command.AddParameterWithValue("name", t.Name);
            command.AddParameterWithValue("seats", t.Seats);

            _connector.ExecuteNonQuery(command);
        }

        public void Delete(Election t)
        {
            IDbCommand command = _connector.CreateCommand();

            command.CommandText = "DELETE FROM [Verkiezing] WHERE [Naam]=@naam";
            command.AddParameterWithValue("naam", t.Name);

            _connector.ExecuteNonQuery(command);
        }

        public List<Election> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(Election t)
        {
            throw new NotImplementedException();
        }
    }
}
