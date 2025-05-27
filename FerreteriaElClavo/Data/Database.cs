using System.Configuration;
using System.Data.SqlClient;

namespace FerreteriaElClavo.Data
{
    public static class Database
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["FerreteriaDB"].ConnectionString);
        }
    }
}
