using Application.Interfaces;
using Application.Services;
using Application.Validations;
using Domain.Entities;
using FluentValidation;

namespace Application.Extensions;

/// <summary>
/// DEPENDENCY INJECTION EXTENSION FOR APPLICATION LAYER
/// </summary>
/// <remarks>
/// Author: Luis López  
/// GitHub: https://github.com/luislopez-dev
/// </remarks>
public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IInvoiceService, InvoiceService>();
        services.AddScoped<IValidator<Product>, ProductValidator>();
        services.AddScoped<IValidator<Invoice>, InvoiceValidator>();
        
        return services;
    }
}