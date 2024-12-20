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
}
