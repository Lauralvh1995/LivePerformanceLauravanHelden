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
    public class PartyContext : IContext<Party>
    {
        private readonly IDatabaseConnector _connector;
        public PartyContext(IDatabaseConnector connector)
        {
            _connector = connector;
        }
        public void Add(Party t)
        {
            IDbCommand command = _connector.CreateCommand();
            command.CommandText = "INSERT INTO [Partij] ([Naam], [Lijsttrekker], [AantalLeden]) VALUES (@name, @partyleader, @members);";
            command.AddParameterWithValue("name", t.Name);
            command.AddParameterWithValue("primeminister", t.PartyLeader);
            command.AddParameterWithValue("members", t.AmountOfMembers);

            _connector.ExecuteNonQuery(command);
        }

        public void Delete(Party t)
        {
            IDbCommand command = _connector.CreateCommand();

            command.CommandText = "DELETE FROM [CoalitiePartij] WHERE [PartijID] = (SELECT ID FROM Partij WHERE Naam=@naam)";
            command.AddParameterWithValue("naam", t.Name);

            _connector.ExecuteNonQuery(command);

            command.CommandText = "DELETE FROM [Partij] WHERE [Naam]=@naam";
            command.AddParameterWithValue("naam", t.Name);

            _connector.ExecuteNonQuery(command);
        }

        public List<Party> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(Party t)
        {
            throw new NotImplementedException();
        }
    }
}
