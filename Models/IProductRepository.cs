using System;

namespace Uppfinnaren.Models;

public interface IProductRepository
{
    IEnumerable<Product> ProductList {get;}
    Product? GetProductById(int id);
}
