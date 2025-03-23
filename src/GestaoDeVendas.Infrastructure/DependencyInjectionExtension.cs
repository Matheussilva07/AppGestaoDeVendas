using GestaoDeVendas.Domain;
using GestaoDeVendas.Domain.Repositories.Costumers;
using GestaoDeVendas.Domain.Repositories.Products;
using GestaoDeVendas.Domain.Repositories.Sales;
using GestaoDeVendas.Domain.Repositories.SoldProducts;
using GestaoDeVendas.Infrastructure.DataAccess;
using GestaoDeVendas.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoDeVendas.Infrastructure;
public static class DependencyInjectionExtension
{
	public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
	{
		AddDbContext(services, configuration);
		AddDependencyInjection(services);
	}
	private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
	{
		string connectionString = configuration.GetConnectionString("connection")!;
		
		services.AddDbContext<SaleManagerDbContext>(config => config.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
	}
	private static void AddDependencyInjection(IServiceCollection services)
	{
		services.AddScoped<IWriteOnlyCostumersRepository, CostumersRepository>();
		services.AddScoped<IWriteOnlyProductsRepository, ProductsRepository>();
		services.AddScoped<IReadOnlyProductsRepository, ProductsRepository>();
		services.AddScoped<IUpdateOnlyProductsRepository, ProductsRepository>();

		services.AddScoped<IWriteOnlySalesRepository, SalesRepository>();
		services.AddScoped<IReadOnlySalesRepository, SalesRepository>();

		services.AddScoped<IUnitOfWork, UnitOfWork>();
		services.AddScoped<IReadOnlySoldProductsRepository, SoldProductsRepository>();
	}
}
