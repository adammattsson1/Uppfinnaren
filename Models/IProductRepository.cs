using System;

namespace Uppfinnaren.Models;

public interface IProductRepository
{
    IEnumerable<Product> GetProductsFromCategory(int id);
    Product? SaveNewProduct(Product newProduct);
    Product? UpdateName(string updatedName, int id);
    Product? UpdateDescription(string updatedDescription, int id);
    Product? UpdatePrice(int updatedPrice, int id);
}
