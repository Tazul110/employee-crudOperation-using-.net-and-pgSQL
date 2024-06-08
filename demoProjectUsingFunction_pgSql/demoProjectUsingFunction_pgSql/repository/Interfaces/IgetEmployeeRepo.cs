using demoProjectUsingFunction_pgSql.Models.Response;

namespace demoProjectUsingFunction_pgSql.repository.Interfaces
{
    public interface IgetEmployeeRepo
    {
        ResponseModel getEmpRepo(int empId);
    }
}
