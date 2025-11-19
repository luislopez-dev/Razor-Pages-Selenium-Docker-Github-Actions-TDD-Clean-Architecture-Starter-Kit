/*
 * Author: Luis López
 * Website: https://github.com/luislopez-dev
 * Description:  Open source project: Enterprise-.Net-Architecture-Template
 */

using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Presentation.Extensions;
using Presentation.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add application services
builder.Services.AddApplicationServices(builder.Configuration);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Initialize database and execute migrations
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

/*    
    while (!db.CanConnect())
    {
        logger.LogInformation("Database not ready yet; waiting...");
    
        Thread.Sleep(1000);
    }
*/
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

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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