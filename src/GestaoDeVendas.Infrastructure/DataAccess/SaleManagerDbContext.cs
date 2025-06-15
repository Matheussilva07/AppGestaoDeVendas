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

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
        modelBuilder.Entity<Sale>()
            .HasOne(s => s.Costumer)
            .WithMany(s => s.Sales)
            .HasForeignKey(s => s.CostumerId)
            .OnDelete(DeleteBehavior.Cascade);

		modelBuilder.Entity<SoldProduct>()
	        .HasOne(sp => sp.Sale)
	        .WithMany(s => s.Products)
	        .HasForeignKey(sp => sp.SaleId)
	        .OnDelete(DeleteBehavior.Cascade);

	}


}
