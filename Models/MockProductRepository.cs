using System;

namespace Uppfinnaren.Models;

public class MockProductRepository : IProductRepository
{
    public IEnumerable<Product> ProductList => new List<Product>
    {
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100},
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100},
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100},
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100},
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100},
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100},
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100},
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100}
    };

    public IEnumerable<Product> Category1 => new List<Product>
    {
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100},
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100}
    };
    public IEnumerable<Product> Category2 => new List<Product>
    {
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100},
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100}
    };
    public IEnumerable<Product> Category3 => new List<Product>
    {
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100},
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100}
    };
    public IEnumerable<Product> Category4 => new List<Product>
    {
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100},
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100}
    };
    public IEnumerable<Product> Category5 => new List<Product>
    {
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100},
        new Product{Name = "name", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 100}
    };

    public Product? GetProductById(int id) => ProductList.FirstOrDefault(p => p.ProductId == id);
}
