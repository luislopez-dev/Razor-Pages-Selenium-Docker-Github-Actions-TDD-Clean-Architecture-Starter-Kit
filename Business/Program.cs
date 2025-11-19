/*
 * Author: Luis René López
 * Website: https://github.com/luislopez-dev
 * Description: Open source project: Enterprise-.Net-Architecture-Template
 */

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();