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
    public class ResultsContext : IContext<Results>
    {
        private readonly IDatabaseConnector _connector;
        public ResultsContext(IDatabaseConnector connector)
        {
            _connector = connector;
        }
        public void Add(Results t)
        {
            IDbCommand command = _connector.CreateCommand();
            command.CommandText = "INSERT INTO [Uitslag] ([VerkiezingID], [Naam], [TotaalStemmen]) VALUES (@electionid, @name, @votes);";
            command.AddParameterWithValue("electionid", 1);
            command.AddParameterWithValue("name", t.Name);
            command.AddParameterWithValue("votes", t.TotalVotes);

            _connector.ExecuteNonQuery(command);
        }

        public void Delete(Results t)
        {
            IDbCommand command = _connector.CreateCommand();


            command.CommandText = "DELETE FROM [Uitslag] WHERE [Naam]=@naam";
            command.AddParameterWithValue("naam", t.Name);

            _connector.ExecuteNonQuery(command);
        }

        public List<Results> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(Results t)
        {
            throw new NotImplementedException();
        }
    }
}
