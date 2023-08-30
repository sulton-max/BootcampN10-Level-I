using N33_T1.Models.Entities;
using N33_T1.Services.Accounts.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();