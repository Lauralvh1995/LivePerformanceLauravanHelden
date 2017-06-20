using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceLauravanHelden.DAL.DatabaseConnection
{

    public class SQLServerConnector : IDatabaseConnector
    {
        SqlConnection _connection = new SqlConnection("Server=mssql.fhict.local;Database=dbi337797;User Id=dbi337797;Password=LivePerformanceVJ2017;");

        public IDbCommand CreateCommand()
        {
            return _connection.CreateCommand();
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Dispose();
                _connection = null;
            }
        }

        public void ExecuteNonQuery(IDbCommand command)
        {
            Open();

            using (command)
                command.ExecuteNonQuery();

            Close();
        }

        public IDataReader ExecuteReader(IDbCommand command)
        {
            Open();

            using (command)
                return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public void Open()
        {
            _connection.Open();
        }

        public void Close()
        {
            _connection.Close();
        }
    }
}
