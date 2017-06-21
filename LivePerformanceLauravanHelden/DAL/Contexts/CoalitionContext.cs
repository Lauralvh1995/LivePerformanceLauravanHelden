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
    public class CoalitionContext : IContext<Coalition>
    {
        private readonly IDatabaseConnector _connector;

        public CoalitionContext(IDatabaseConnector connector)
        {
            _connector = connector;
        }

        public void Add(Coalition t)
        {
            IDbCommand command = _connector.CreateCommand();
            command.CommandText = "INSERT INTO [Coalitie] ([Naam], [Premier], [Zetels]) VALUES (@name, @primeminister, @seats);";
            command.AddParameterWithValue("name", t.Name);
            command.AddParameterWithValue("primeminister", t.PrimeMinister);
            command.AddParameterWithValue("seats", t.Seats);

            _connector.ExecuteNonQuery(command);
        }

        public void Delete(Coalition t)
        {
            throw new NotImplementedException();
        }

        public List<Coalition> Read(int userid)
        {
            throw new NotImplementedException();
        }

        public void Update(Coalition t)
        {
            throw new NotImplementedException();
        }

        public void AddPartyToCoalition(Coalition coalition, Party party)
        {
            IDbCommand command = _connector.CreateCommand();
            command.CommandText = "VoegPartijToeAanCoalitie(@coalitienaam, @partijnaam);";
            command.AddParameterWithValue("coalitienaam", coalition.Name);
            command.AddParameterWithValue("partijnaam", party.Name);
            command.CommandType = CommandType.StoredProcedure;

            _connector.ExecuteNonQuery(command);
        }

        public void RemovePartyFromCoalition(Coalition coalition, Party party)
        {
            IDbCommand command = _connector.CreateCommand();
            command.CommandText = "VerwijderPartijUitCoalitie(@coalitienaam, @partijnaam);";
            command.AddParameterWithValue("coalitienaam", coalition.Name);
            command.AddParameterWithValue("partijnaam", party.Name);
            command.CommandType = CommandType.StoredProcedure;

            _connector.ExecuteNonQuery(command);
        }
    }
}
