using System;

namespace Uppfinnaren.Models;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _appDbContext;

    public ProductRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    
    public IEnumerable<Product> AllProducts
    {
        get
        {
            return _appDbContext.Products;
        }
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

    public Product? UpdateProduct(string name, string description, int price, int productId)
    {
        var product = _appDbContext.Products.FirstOrDefault(i => i.ProductId == productId);

        if (product == null)
        {
            return null;
        }
        
        product.Name = name;
        product.Description = description;
        product.Price = price;
        
        _appDbContext.SaveChanges();

        return product;
    }
}
