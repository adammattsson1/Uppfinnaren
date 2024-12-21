using System;
using Microsoft.EntityFrameworkCore;

namespace Uppfinnaren.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
    {

    }

    public DbSet<Product> Products {get; set;}
    public DbSet<Category> Categories {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData
        (
            new Product{ProductId = 1, CategoryId = 1, Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100},
            new Product{ProductId = 2, CategoryId = 2, Name = "name2", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 101},
            new Product{ProductId = 3, CategoryId = 3, Name = "name3", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 102},
            new Product{ProductId = 4, CategoryId = 4, Name = "name4", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 103},
            new Product{ProductId = 5, CategoryId = 5, Name = "name5", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 104}
        );

        modelBuilder.Entity<Category>().HasData
        (
            new Category{CategoryId = 1, Name = "Kategori1"},
            new Category{CategoryId = 2, Name = "Kategori2"},
            new Category{CategoryId = 3, Name = "Kategori3"},
            new Category{CategoryId = 4, Name = "Kategori4"},
            new Category{CategoryId = 5, Name = "Kategori5"}
        );
    }
}
