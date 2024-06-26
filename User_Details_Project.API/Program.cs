using Microsoft.Extensions.Configuration;
using User_Details_Project.DataAccess;
using User_Details_Project.Entities;
using User_Details_Project.Infrastructure.DataAccess;
using User_Details_Project.Infrastructure.Services;
using User_Details_Project.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySql.EntityFrameworkCore.Extensions;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFrameworkMySQL()
    .AddDbContext<UserDetailsContext>(options =>
        options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection"))
    );

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IUserService, UserService>();

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
