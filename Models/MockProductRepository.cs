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

    public Product? GetProductByName(string name) => ProductList.FirstOrDefault(p => p.Name == name);

    public void AddProduct(Product product) => ProductList.Append(product);
}
