namespace demoProjectUsingFunction_pgSql.Models.Response
{
    public class ResponseModel
    {
        public int StatusCode { get; set; }
        public string? StatusMessage {get;set;}
        public Employee? Employee { get;set;}
        public List<Employee> Employees { get; set;}

    }
}
