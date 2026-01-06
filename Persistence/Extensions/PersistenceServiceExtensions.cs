using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.Extensions;

using Application.Repositories;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// DEPENDENCY INJECTION CONTAINER FOR PERSISTENCE LAYER
/// </summary>
/// <remarks>
/// Author: Luis López  
/// GitHub: https://github.com/luislopez-dev
/// </remarks>
public static class PersistenceServiceExtensions
{
    public static IServiceCollection AddPersistenceServiceExtensions(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("appDb"));
            }   
        );        
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        
        return services;
    }
}