using System;
using Microsoft.EntityFrameworkCore;

namespace Uppfinnaren.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
    {

    }

    public DbSet<Product> Products {get; set;}
    public DbSet<IProductRepository> ProductRepository {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // mock products

        // mock productrepository
    }
}
