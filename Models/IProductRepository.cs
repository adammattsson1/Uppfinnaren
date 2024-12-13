using System;

namespace Uppfinnaren.Models;

public interface IProductRepository
{
    IEnumerable<Product> Products {get;}
    Product? GetProductByName(string name);
    void AddProduct(Product product);
}
