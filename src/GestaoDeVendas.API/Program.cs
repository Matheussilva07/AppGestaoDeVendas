using GestaoDeVendas.Infrastructure;
using GestaoDeVendas.Application;
using GestaoDeVendas.Infrastructure.Migrations;

namespace GestaoDeVendas.API;

public class Program
{
	public static async Task Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.

		builder.Services.AddControllers();
		// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen();

		builder.Services.AddRouting(options => options.LowercaseUrls = true);
		builder.Services.AddInfrastructure_Application();
		builder.Services.AddInfrastructure(builder.Configuration);

		var app = builder.Build();

		// Configure the HTTP request pipeline.
		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		}

		app.UseHttpsRedirection();

		app.UseAuthorization();

		await ApllyMigration.ApplyCommandMigration(app.Services);

		app.MapControllers();

		app.Run();
	}
}
