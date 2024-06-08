using demoProjectUsingFunction_pgSql.Models;
using demoProjectUsingFunction_pgSql.Models.Response;
using System.Data.SqlClient;

namespace demoProjectUsingFunction_pgSql.services.Interfaces
{
    public interface ISaveEmployee
    {
        ResponseModel addEmployee(Employee employee);
    }
}
