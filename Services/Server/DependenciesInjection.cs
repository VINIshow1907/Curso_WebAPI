using ReserveiAPI.Repositories.Entities;
using ReserveiAPI.Repositories.Interfaces;
using ReserveiAPI.Services.Entities;
using ReserveiAPI.Services.Interfaces;


namespace ReserveiAPI.Services.Server
{
    public static class DependenciesInjection
    {
        public static void AdduserDependencies(this IServiceCollection services)
        {
            //Dependência: Usuário
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
