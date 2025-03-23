using GestaoDeVendas.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoDeVendas.Infrastructure.Migrations;
public static class ApllyMigration
{
	public static async Task ApplyCommandMigration(IServiceProvider service)
	{
		var scope = service.CreateAsyncScope();

		var db = scope.ServiceProvider.GetRequiredService<SaleManagerDbContext>();

		await db.Database.MigrateAsync();
	}
}
