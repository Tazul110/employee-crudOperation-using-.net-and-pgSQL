using demoProjectUsingFunction_pgSql.Models;
using demoProjectUsingFunction_pgSql.Models.Response;
using demoProjectUsingFunction_pgSql.services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace demoProjectUsingFunction_pgSql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly ISaveEmployee _service;
        private readonly IDeleteEmployee _deleteServ;
        private readonly IeditEmployee _editServ;
        private readonly IgetEmployee _getServ;
        private readonly IGetAllEmployee _getAllServ;
  
        public EmployeeController(ISaveEmployee service, IDeleteEmployee deleteServ, IeditEmployee editServ, IgetEmployee getServ, IGetAllEmployee getAllServ)
        {
            _service = service;
            _deleteServ = deleteServ;
            _editServ=editServ;
            _getServ = getServ;
            _getAllServ = getAllServ;
        }


        [HttpPost]
        [Route("AddEmployee")]
        public ResponseModel AddEmployee(Employee employee)
        {
            
            ResponseModel response = new ResponseModel();

            response = _service.addEmployee(employee);
            return response;
        }


        [HttpDelete]
        [Route("DeleteEmployee/{id}")]
        public ResponseModel DeleteEmployee(int id)
        {
           
            ResponseModel response = new ResponseModel();

            response = _deleteServ.DeleteEmpService(id);

            return response;
        }


        [HttpPut]
        [Route("UpdateEmployee")]
        public ResponseModel UpdateEmployee(Employee employee)
        {
           
            ResponseModel response = new ResponseModel();

            response = _editServ.empEdit(employee);
            return response;
        }

        [HttpGet]
        [Route("GetEmployeeById/{id}")]
        public ResponseModel GetEmployeeById(int id)
        {

            ResponseModel response = new ResponseModel();

            response = _getServ.getEmp(id);

            return response;
        }


        [HttpGet]
        [Route("GetAllEmployees")]
        public ResponseModel GetAllEmployees()
        {
            ResponseModel response = new ResponseModel();

            response = _getAllServ.GetAll();
            return response;




        }
    }
}
