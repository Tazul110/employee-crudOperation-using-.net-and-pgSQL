using demoProjectUsingFunction_pgSql.Models.Response;
using demoProjectUsingFunction_pgSql.repository.Interfaces;
using demoProjectUsingFunction_pgSql.services.Interfaces;

namespace demoProjectUsingFunction_pgSql.services.Implements
{
    public class DeleteEmployee : IDeleteEmployee
    {
        private readonly IDeleteEmployeeInterface _deleteEmployee;
        public DeleteEmployee(IDeleteEmployeeInterface deleteEmployee)
        {
            _deleteEmployee = deleteEmployee;
        }
        public ResponseModel DeleteEmpService(int empId)
        {
            return _deleteEmployee.deleteEmp(empId);
        }
    }
}
