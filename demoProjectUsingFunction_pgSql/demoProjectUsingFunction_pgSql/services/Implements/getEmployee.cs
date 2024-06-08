using demoProjectUsingFunction_pgSql.Models.Response;
using demoProjectUsingFunction_pgSql.repository.Interfaces;
using demoProjectUsingFunction_pgSql.services.Interfaces;

namespace demoProjectUsingFunction_pgSql.services.Implements
{
    public class getEmployee: IgetEmployee
    {

        private readonly IgetEmployeeRepo _repo;
        public getEmployee(IgetEmployeeRepo repo)
        {
            _repo = repo;
        }

        ResponseModel IgetEmployee.getEmp(int empId)
        {
           return _repo.getEmpRepo(empId);
        }
    }
}
