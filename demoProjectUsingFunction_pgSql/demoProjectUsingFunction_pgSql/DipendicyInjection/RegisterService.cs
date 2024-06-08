using demoProjectUsingFunction_pgSql.repository.Interfaces;
using demoProjectUsingFunction_pgSql.services.Implements;
using demoProjectUsingFunction_pgSql.services.Interfaces;

namespace demoProjectUsingFunction_pgSql.DipendicyInjection
{
    public static class RegisterService
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IDeleteEmployee, DeleteEmployee>();
            services.AddScoped<IgetEmployee, getEmployee>();
            services.AddScoped<ISaveEmployee, SaveEmployee>();
            services.AddScoped<IeditEmployee, editEmployee>();
            services.AddScoped<IGetAllEmployee, GetAllEmployee>();
            
        }
    }
}
