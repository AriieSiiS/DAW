using Microsoft.EntityFrameworkCore;
using Proyecto_Razor.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

builder.Services.AddDbContext<MisDatos>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MiDataBase") ?? throw new InvalidOperationException
        ("Conecction string 'MiDataBase' not found.")));

var app = builder.Build();


app.UseAuthorization();
app.MapRazorPages();
app.UseStaticFiles();
app.Run();
