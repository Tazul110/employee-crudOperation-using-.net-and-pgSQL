using demoProjectUsingFunction_pgSql.Models;
using demoProjectUsingFunction_pgSql.Models.Response;

namespace demoProjectUsingFunction_pgSql.repository.Interfaces
{
    public interface IeditEmployeeRepo
    {
        ResponseModel editEmp(Employee emp);
    }
}
