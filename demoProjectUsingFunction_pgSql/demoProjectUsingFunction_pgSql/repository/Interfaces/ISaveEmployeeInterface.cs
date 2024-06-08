using demoProjectUsingFunction_pgSql.Models.Response;
using demoProjectUsingFunction_pgSql.Models;

namespace demoProjectUsingFunction_pgSql.repository.Interfaces
{
    public interface ISaveEmployeeInterface
    {
        ResponseModel addEmployee(Employee emp);
    }
}
