using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWindows
{
    internal class DatabaseConnection
    {
        private static readonly Lazy<DatabaseConnection> instance =
            new Lazy<DatabaseConnection>(() => new DatabaseConnection());

        private readonly string connectionString;

        private DatabaseConnection()
        {
            connectionString =
                "Data Source=85.234.124.151;Initial Catalog=Lazutkin;User ID=Lazutkin;Password=12345678;Encrypt=False";
        }

        public static DatabaseConnection Instance => instance.Value;

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
