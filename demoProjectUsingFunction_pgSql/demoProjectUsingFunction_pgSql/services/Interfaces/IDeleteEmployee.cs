using demoProjectUsingFunction_pgSql.Models.Response;

namespace demoProjectUsingFunction_pgSql.services.Interfaces
{
    public interface IDeleteEmployee
    {
        ResponseModel DeleteEmpService(int  empId);
    }
}
