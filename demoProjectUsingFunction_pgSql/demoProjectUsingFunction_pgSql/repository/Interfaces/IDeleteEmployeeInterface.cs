using demoProjectUsingFunction_pgSql.Models.Response;

namespace demoProjectUsingFunction_pgSql.repository.Interfaces
{
    public interface IDeleteEmployeeInterface
    {
        ResponseModel deleteEmp(int  empId);
    }
}
