using System;

namespace Uppfinnaren.Models;

public interface IProductRepository
{
    IEnumerable<Product> ProductList {get;}
    IEnumerable<Product> Category1 {get;}
    IEnumerable<Product> Category2 {get;}
    IEnumerable<Product> Category3 {get;}
    IEnumerable<Product> Category4 {get;}
    IEnumerable<Product> Category5 {get;}
    Product? GetProductById(int id);
}
