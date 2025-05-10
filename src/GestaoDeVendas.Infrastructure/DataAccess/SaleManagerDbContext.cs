using GestaoDeVendas.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeVendas.Infrastructure.DataAccess;
internal class SaleManagerDbContext: DbContext
{
    public SaleManagerDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
    {
        
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Costumer> Costumers { get; set; }
    public DbSet<Sale> Sales { get; set; }
	public DbSet<SoldProduct> SoldProducts { get; set; }

	
}
