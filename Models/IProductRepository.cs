using System;

namespace Uppfinnaren.Models;

public interface IProductRepository
{
    IEnumerable<Product> ProductList {get;}
    Product? GetProductByName(string name);
    void AddProduct(Product product);
}
