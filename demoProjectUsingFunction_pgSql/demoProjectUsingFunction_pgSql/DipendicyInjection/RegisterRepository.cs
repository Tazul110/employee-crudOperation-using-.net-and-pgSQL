using demoProjectUsingFunction_pgSql.repository.Implements;
using demoProjectUsingFunction_pgSql.repository.Interfaces;
using demoProjectUsingFunction_pgSql.repository;
using demoProjectUsingFunction_pgSql.services.Implements;
using demoProjectUsingFunction_pgSql.services.Interfaces;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

namespace demoProjectUsingFunction_pgSql.DipendicyInjection
{
    public static class RegisterRepository
    {
        public static void AddRepositories(this IServiceCollection services)
        {
           
            services.AddScoped<ISaveEmployeeInterface, SaveEmployeeInterface>();
            services.AddScoped<IDeleteEmployeeInterface, DeleteEmployeeInterface>();
            services.AddScoped<IeditEmployeeRepo, editEmployeeRepo>();
            services.AddScoped<IgetEmployeeRepo, getEmployeeRepo>();
            services.AddScoped<IGetAllEmployeeRepo, GetAllEmployeeRepo>();


        }
        
    }
}
