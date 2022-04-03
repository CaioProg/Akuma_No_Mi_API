using AkumaNoMi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string FrutaConnection = builder.Configuration.GetConnectionString("FrutaConnection");

builder.Services.AddDbContextPool<FrutaContext>(options =>
                options.UseMySql(FrutaConnection,
                      ServerVersion.AutoDetect(FrutaConnection)));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
