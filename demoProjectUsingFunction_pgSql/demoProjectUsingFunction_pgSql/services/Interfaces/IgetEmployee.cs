using demoProjectUsingFunction_pgSql.Models.Response;

namespace demoProjectUsingFunction_pgSql.services.Interfaces
{
    public interface IgetEmployee
    {
        ResponseModel getEmp(int empId);
    }
}
