var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Alejandro - Proyecto ASP.NET Core Vac�o");

app.Run();
