using System;

namespace Uppfinnaren.Models;

public interface IProductRepository
{
    IEnumerable<Product> AllProducts {get;}
    IEnumerable<Product> GetProductsFromCategory(int id);
    Product? SaveNewProduct(Product newProduct);
    Product? UpdateProduct(string name, string description, int price, int productId);
}
