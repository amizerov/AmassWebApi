using AmassWebApi.DataAccess.Data;
using AmassWebApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AmassDb>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

Category.Map(app);
Income.Map(app);
Log.Map(app);

app.Run();
