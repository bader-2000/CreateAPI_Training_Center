using LarningHub.Core.Common;
using LarningHub.Core.Repository;
using LarningHub.Core.Services;
using LarningHub.Infra.Common;
using LarningHub.Infra.Repository;
using LarningHub.Infra.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDBContext, DBContext>();
builder.Services.AddScoped<IRepositoryCourse, RepositoryCourse>();
builder.Services.AddScoped<ICourseServices, CourseServices>();
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
