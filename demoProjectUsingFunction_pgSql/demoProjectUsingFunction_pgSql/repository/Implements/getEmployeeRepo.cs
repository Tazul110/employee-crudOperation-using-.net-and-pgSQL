using Dapper;
using demoProjectUsingFunction_pgSql.Data;
using demoProjectUsingFunction_pgSql.Models;
using demoProjectUsingFunction_pgSql.Models.Response;
using demoProjectUsingFunction_pgSql.repository.Interfaces;
using Npgsql;
using System.Data;

namespace demoProjectUsingFunction_pgSql.repository.Implements
{
    public class getEmployeeRepo : IgetEmployeeRepo
    {
        private readonly DatabaseConnectionFactory _connectionFactory;

        public getEmployeeRepo(DatabaseConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        ResponseModel IgetEmployeeRepo.getEmpRepo(int empId)
        {
            ResponseModel response = new ResponseModel();

            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                connection.Open();
                string query = "SELECT * FROM employee WHERE empId = @EmpId";

                var ret = connection.QueryFirstOrDefault<Employee>(query, new { EmpId = empId });
                try 
                { 

                if (ret != null)
                {
                        response.Employee = new Employee // Initialize the Employee object
                        {
                            empId = ret.empId,
                            empName = ret.empName,
                            empDept = ret.empDept,
                            empPhone = ret.empPhone
                        };

                        response.StatusCode = 200;
                        response.StatusMessage = "Employee retrieved successfully.";
                    }
                else
                {
                    response.StatusCode = 100;
                    response.StatusMessage = "Employee deletion failed.";
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
