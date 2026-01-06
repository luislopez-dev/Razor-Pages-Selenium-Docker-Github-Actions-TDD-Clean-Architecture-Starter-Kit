using Application.Extensions;
using Infrastructure.Data;
using Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Presentation.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddPersistenceServiceExtensions(builder.Configuration);

builder.Services.AddRazorPages();

var app = builder.Build();

// Initializing database and executing migrations
using (var serviceScope = app.Services.GetService<IServiceScopeFactory>().CreateScope())
{
    var logger = serviceScope
        .ServiceProvider
        .GetRequiredService<ILogger<Program>>();

    var db = serviceScope
        .ServiceProvider
        .GetRequiredService<DataContext>()
        .Database;
    
    logger.LogInformation("Migrating database...");

    try
    {
        db.Migrate();
        
        logger.LogInformation("Database migrated successfully.");
    }
    catch (Exception e)
    {
        logger.LogError(e, "An error occurred while migrating the database.");
    }
}

app.UseMiddleware<ExceptionMiddleware>();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.Use(async (context, next) =>
{
    await next();
    if (context.Response.StatusCode == 404)
    {
        context.Request.Path = "/NotFound";
        await next();
    }
});

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: default,
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();