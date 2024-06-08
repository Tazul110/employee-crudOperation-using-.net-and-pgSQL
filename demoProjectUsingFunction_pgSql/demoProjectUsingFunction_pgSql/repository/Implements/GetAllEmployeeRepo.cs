using Dapper;
using demoProjectUsingFunction_pgSql.Data;
using demoProjectUsingFunction_pgSql.Models;
using demoProjectUsingFunction_pgSql.Models.Response;
using demoProjectUsingFunction_pgSql.repository.Interfaces;
using System.Data;

namespace demoProjectUsingFunction_pgSql.repository.Implements
{
    public class GetAllEmployeeRepo : IGetAllEmployeeRepo
    {
        private readonly DatabaseConnectionFactory _connectionFactory;

        public GetAllEmployeeRepo(DatabaseConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        ResponseModel IGetAllEmployeeRepo.GetAllEmp()
        {
            ResponseModel response = new ResponseModel();
            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                try
                {
                    connection.Open();
                    var employees = connection.Query<Employee>("SELECT * FROM employee").ToList();

                    if (employees != null && employees.Any())
                    {
                        response.StatusCode = 200;
                        response.StatusMessage = "Employees retrieved successfully.";
                        response.Employees = employees;
                    }
                    else
                    {
                        response.StatusCode = 100;
                        response.StatusMessage = "No employees found.";
                    }
                }
                catch (Exception ex)
                {
                    response.StatusCode = 500;
                    response.StatusMessage = $"Exception: {ex.Message}";
                }
            }
            return response;
        }
    }
}