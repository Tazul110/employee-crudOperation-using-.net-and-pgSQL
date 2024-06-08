using Npgsql;
using System.Data;

namespace demoProjectUsingFunction_pgSql.Data
{
    public class DatabaseConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public DatabaseConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            return new NpgsqlConnection(_configuration.GetConnectionString("CrudConnection"));
        }
    }
}
