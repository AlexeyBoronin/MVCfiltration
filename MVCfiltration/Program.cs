using Microsoft.EntityFrameworkCore;
using MVCfiltration.Models;

var builder = WebApplication.CreateBuilder(args);

string connection = "Server = (localdb)\\MSSQLLocalDB;Database = usersfiltrationdb;Trusted_Connection=true";
builder.Services.AddDbContext<UsersContext>(options => options.UseSqlServer(connection));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();