using System;

namespace Uppfinnaren.Models;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _appDbContext;

    public ProductRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public IEnumerable<Product> GetProductsFromCategory(int id)
    {
        return _appDbContext.Products.Where(p => p.CategoryId == id);
    }

    public Product? SaveNewProduct(Product newProduct)
    {
        _appDbContext.Products.Add(newProduct);
        _appDbContext.SaveChanges();

        return newProduct;
    }










    public Product? UpdateDescription(string updatedDescription, int id)
    {
        var product = _appDbContext.Products.FirstOrDefault(i => i.ProductId == id);

        if (product == null)
        {
            return null;
        }

        product.Description = updatedDescription;
        _appDbContext.SaveChanges();

        return product;
    }

    public Product? UpdateName(string updatedName, int id)
    {
        throw new NotImplementedException();
    }

    public Product? UpdatePrice(int updatedPrice, int id)
    {
        throw new NotImplementedException();
    }
}
