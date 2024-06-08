using Dapper;
using demoProjectUsingFunction_pgSql.Data;
using demoProjectUsingFunction_pgSql.Models;
using demoProjectUsingFunction_pgSql.Models.Response;
using demoProjectUsingFunction_pgSql.repository.Interfaces;
using Npgsql;
using System.Data;

namespace demoProjectUsingFunction_pgSql.repository.Implements
{
    public class editEmployeeRepo : IeditEmployeeRepo
    {
        private readonly DatabaseConnectionFactory _connectionFactory;

        public editEmployeeRepo(DatabaseConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }


        ResponseModel IeditEmployeeRepo.editEmp(Employee emp)
        {
            ResponseModel response = new ResponseModel();
            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
               
                try
                {
                    connection.Open();
                    int rowsAffected = connection.Execute("UPDATE employee SET empName = @EmpName, empDept = @EmpDept, empPhone = @EmpPhone WHERE empId = @EmpId", emp);

                    /*connection.Open();
                    int rowsAffected = connection.Execute(query, new
                    {
                        EmpId = emp.empId,
                        EmpName = emp.empName,
                        EmpDept = emp.empDept,
                        EmpPhone = emp.empPhone
                    });*/

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
