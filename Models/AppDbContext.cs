using System;
using Microsoft.EntityFrameworkCore;

namespace Uppfinnaren.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
    {

    }

    public DbSet<Product> ProductList {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // mock products
        modelBuilder.Entity<Product>().HasData
        (
            new Product{ProductId = 1, Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100},
            new Product{ProductId = 2, Name = "name2", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 101},
            new Product{ProductId = 3, Name = "name3", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 102}
        );
    }
}
