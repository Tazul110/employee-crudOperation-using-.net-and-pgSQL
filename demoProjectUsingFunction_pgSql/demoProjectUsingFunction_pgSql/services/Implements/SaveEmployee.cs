using demoProjectUsingFunction_pgSql.Models;
using demoProjectUsingFunction_pgSql.Models.Response;
using demoProjectUsingFunction_pgSql.repository.Interfaces;
using demoProjectUsingFunction_pgSql.services.Interfaces;

namespace demoProjectUsingFunction_pgSql.services.Implements
{
    public class SaveEmployee : ISaveEmployee
    {
        private readonly ISaveEmployeeInterface _crudAdd;
        public SaveEmployee(ISaveEmployeeInterface crudAdd)
        {
            _crudAdd = crudAdd;
        }
      

        ResponseModel ISaveEmployee.addEmployee(Employee employee)
        {
            return _crudAdd.addEmployee(employee);
        }
    }
}
