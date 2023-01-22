using Application.IServices;
using Domain.IUnitOfWork;
using Domain.Repositories.CompanyRepositories;
using Domain.Repositories.CompanyRepositories›;
using Domain.Repositories.OrderRepositories;
using Domain.Repositories.ProductRepositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using Persistance.Repositories.CompanyRepositories;
using Persistance.Repositories.OrderRepositories;
using Persistance.Repositories.ProductRepositories;
using Persistance.Services;
using Persistance.UnitOfWork;
using Presentation;

var builder = WebApplication.CreateBuilder(args);
#region DbContext
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
#endregion

#region Dependency Injection
builder.Services.AddScoped<IProductCommandRepository, ProductCommandRepository>();
builder.Services.AddScoped<IProductQueryRepository, ProductQueryRepository>();
builder.Services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
builder.Services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
builder.Services.AddScoped<IOrderCommandRepository, OrderCommandRepository>();
builder.Services.AddScoped<IOrderQueryRepository, OrderQueryRepository>();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

#endregion


builder.Services.AddMediatR(typeof(Application.AssemblyReference).Assembly);

builder.Services.AddControllers().AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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