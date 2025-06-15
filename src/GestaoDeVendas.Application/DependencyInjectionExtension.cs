using GestaoDeVendas.Application.Automapper;
using GestaoDeVendas.Application.UseCases.Costumers.Delete;
using GestaoDeVendas.Application.UseCases.Costumers.GetByName;
using GestaoDeVendas.Application.UseCases.Costumers.GetCostumerByName;
using GestaoDeVendas.Application.UseCases.Costumers.GetCostumersList;
using GestaoDeVendas.Application.UseCases.Costumers.Register;
using GestaoDeVendas.Application.UseCases.Costumers.Update;
using GestaoDeVendas.Application.UseCases.Products.Delete;
using GestaoDeVendas.Application.UseCases.Products.GetAllProducts;
using GestaoDeVendas.Application.UseCases.Products.GetProductById;
using GestaoDeVendas.Application.UseCases.Products.GetProductByName;
using GestaoDeVendas.Application.UseCases.Products.Register;
using GestaoDeVendas.Application.UseCases.Products.Update;
using GestaoDeVendas.Application.UseCases.Sales.Delete;
using GestaoDeVendas.Application.UseCases.Sales.FilterSalesByDate;
using GestaoDeVendas.Application.UseCases.Sales.GetSaleById;
using GestaoDeVendas.Application.UseCases.Sales.Register;
using GestaoDeVendas.Application.UseCases.Sales.Update;
using GestaoDeVendas.Application.UseCases.SoldProducts;
using GestaoDeVendas.Application.UseCases.Users.Register;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoDeVendas.Application;
public static class DependencyInjectionExtension
{
	public static void AddInfrastructure_Application(this IServiceCollection services)
	{
		AddAutomapper(services);
		AddDependencyInjection(services);
	}
	
	private static void AddDependencyInjection(IServiceCollection services)
	{
		#region Costumers Dependency Injection

		services.AddScoped<IRegisterCostumerUseCase, RegisterCostumerUseCase>();
		services.AddScoped<IGetCostumersListUseCase, GetCostumersListUseCase>();
		services.AddScoped<IGetCostumerByIdUseCase, GetCostumerByIdUseCase>();
		services.AddScoped<IGetByNameUseCase, GetByNameUseCase>();
		services.AddScoped<IDeleteCostumerUseCase, DeleteCostumerUseCase>();
		services.AddScoped<IUpdateCostumerUseCase, UpdateCostumerUseCase>();

		#endregion

		#region Products Dependency Injection

		services.AddScoped<IRegisterProductUseCase, RegisterProductUseCase>();
		services.AddScoped<IUpdateProductUseCase, UpdateProductUseCase>();
		services.AddScoped<IDeleteProductUseCase, DeleteProductUseCase>();
		services.AddScoped<IGetProductByIdUseCase, GetProductByIdUseCase>();
		services.AddScoped<IGetProductsListUseCase, GetProductsListUseCase>();
		services.AddScoped<IGetProductByNameUseCase, GetProductByNameUseCase>();

		#endregion

		#region Sales Dependency Injection

		services.AddScoped<IRegisterSaleUseCase, RegisterSaleUseCase>();
		services.AddScoped<IGetSaleByIdUseCase, GetSaleByIdUseCase>();
		services.AddScoped<IDeleteSaleUseCase, DeleteSaleUseCase>();
		services.AddScoped<IGetProductsListOfASaleUseCase, GetProductsListOfASaleUseCase>();
		services.AddScoped<IFilterSalesByDateUseCase, FilterSalesByDateUseCase>();
		services.AddScoped<IUpdateSaleUseCase, UpdateSaleUseCase>();

		#endregion

		#region Users Dependency Injection

		services.AddScoped<IRequestRegisterUserUseCase, RequestRegisterUserUseCase>();

		#endregion
	}

	private static void AddAutomapper(IServiceCollection services)
	{
		services.AddAutoMapper(typeof(Automapping));
	}
}
