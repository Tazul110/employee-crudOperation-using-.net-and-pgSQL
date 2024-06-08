using demoProjectUsingFunction_pgSql.Models.Response;
using demoProjectUsingFunction_pgSql.Models;

namespace demoProjectUsingFunction_pgSql.services.Interfaces
{
    public interface IeditEmployee
    {
        ResponseModel empEdit(Employee employee);
    }
}
