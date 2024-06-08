using demoProjectUsingFunction_pgSql.Models.Response;
using demoProjectUsingFunction_pgSql.repository.Interfaces;
using demoProjectUsingFunction_pgSql.services.Interfaces;

namespace demoProjectUsingFunction_pgSql.services.Implements
{
    public class GetAllEmployee : IGetAllEmployee
    {
        private readonly IGetAllEmployeeRepo _repo;
        public GetAllEmployee(IGetAllEmployeeRepo repo)
        {
            _repo = repo;
        }
        ResponseModel IGetAllEmployee.GetAll()
        {
            return _repo.GetAllEmp();
        }
    }
}
