using System.Data;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using demoProjectUsingFunction_pgSql.Models.Response;
using demoProjectUsingFunction_pgSql.repository.Interfaces;
using demoProjectUsingFunction_pgSql.Data;

namespace demoProjectUsingFunction_pgSql.repository.Implements
{
    public class DeleteEmployeeInterface : IDeleteEmployeeInterface
    {

        private readonly DatabaseConnectionFactory _connectionFactory;

        public DeleteEmployeeInterface(DatabaseConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        ResponseModel IDeleteEmployeeInterface.deleteEmp(int empId)
        {
            ResponseModel response = new ResponseModel();
            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                string query = "DELETE FROM employee WHERE empId = @Id";

                try
                {
                    connection.Open();
                    int rowsAffected = connection.Execute(query, new { Id = empId });
                    //int rowsAffected = connection.Execute("DELETE FROM employee WHERE empId = @Id", new { Id = empId });
                    if (rowsAffected > 0)
                    {
                        response.StatusCode = 200;
                        response.StatusMessage = "Employee deleted successfully.";
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
