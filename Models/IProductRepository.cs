using System;

namespace Uppfinnaren.Models;

public interface IProductRepository
{
    IEnumerable<Product> GetProductsFromCategory(int id);
}
