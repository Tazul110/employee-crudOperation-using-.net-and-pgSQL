using demoProjectUsingFunction_pgSql.Models;
using demoProjectUsingFunction_pgSql.Models.Response;
using demoProjectUsingFunction_pgSql.repository.Interfaces;
using demoProjectUsingFunction_pgSql.services.Interfaces;

namespace demoProjectUsingFunction_pgSql.services.Implements
{
    public class editEmployee: IeditEmployee
    {
        private readonly IeditEmployeeRepo _repo;
        public editEmployee(IeditEmployeeRepo repo)
        {
            _repo = repo;
        }

        ResponseModel IeditEmployee.empEdit(Employee employee)
        {
            return _repo.editEmp(employee);
        }
    }
}
