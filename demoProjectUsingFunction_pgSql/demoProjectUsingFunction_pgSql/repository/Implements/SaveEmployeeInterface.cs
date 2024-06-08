using System.Data;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;  // Import Npgsql for PostgreSQL
using demoProjectUsingFunction_pgSql.Models;
using demoProjectUsingFunction_pgSql.Models.Response;
using demoProjectUsingFunction_pgSql.repository.Interfaces;
using demoProjectUsingFunction_pgSql.Data;

namespace demoProjectUsingFunction_pgSql.repository
{
    public class SaveEmployeeInterface : ISaveEmployeeInterface
    {
        private readonly DatabaseConnectionFactory _connectionFactory;

        public SaveEmployeeInterface(DatabaseConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public ResponseModel addEmployee(Employee emp)
        {
                ResponseModel response = new ResponseModel();

                using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                    string query = "INSERT INTO employee (empName, empDept, empPhone) VALUES (@empName, @empDept, @empPhone)";

                    var parameters = new
                    {
                       
                        empName = emp.empName,
                        empDept = emp.empDept,
                        empPhone = emp.empPhone
                    };

                    try
                    {
                        connection.Open();
                        int rowsAffected = connection.Execute(query, parameters);

                        if (rowsAffected > 0)
                        {
                            response.StatusCode = 200;
                            response.StatusMessage = "Employee added successfully.";
                        }
                        else
                        {
                            response.StatusCode = 100;
                            response.StatusMessage = "No data inserted.";
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
