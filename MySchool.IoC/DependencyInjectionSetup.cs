using Microsoft.Extensions.DependencyInjection;
using MySchool.Data;
using MySchool.Data.Interfaces;
using MySchool.Service;
using MySchool.Service.Interfaces;

namespace MySchool.IoC
{
    public static class DependencyInjectionSetup
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //Repositories
            services.AddScoped<IStudentRepository, StudentRepository>();

            //Services
            services.AddTransient<IStudentService, StudentService>();
        }
    }
}