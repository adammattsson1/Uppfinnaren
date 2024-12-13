using System;

namespace Uppfinnaren.Models;

public class MockProductRepository : IProductRepository
{
    public IEnumerable<Product> Products => new List<Product>();

    public Product? GetProductByName(string name) => Products.FirstOrDefault(p => p.Name == name);

    public void AddProduct(Product product) => Products.Append(product);
}
