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
            List<Party> party = new List<Party>();
            Party p = null;

            IDbCommand command = _connector.CreateCommand();
            command.CommandText = "SELECT [Naam], [Lijsttrekker], [AantalLeden], [Stemmen], [Zetels] FROM Partij JOIN PartijUitslag ON Partij.ID = PartijUitslag.PartijID";

            using (IDataReader reader = _connector.ExecuteReader(command))
            {
                while (reader.Read())
                {
                    p = new Party() {Name = reader.GetString(0),
                        PartyLeader = reader.GetString(1),
                        AmountOfMembers = reader.GetInt32(2),
                        Votes = reader.GetInt32(3),
                        Seats = reader.GetInt32(4)};
                    party.Add(p);
                }
            }

            return party;
        }

        public void Update(Party t)
        {
            throw new NotImplementedException();
        }
    }
}
