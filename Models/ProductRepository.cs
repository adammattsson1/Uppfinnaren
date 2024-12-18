using System;

namespace Uppfinnaren.Models;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _appDbContext;

    public ProductRepository(AppDbContext appDbContext)
    {
        this._appDbContext = appDbContext;
    }

    public IEnumerable<Product> ProductList 
    {
        get
        {
            return _appDbContext.ProductList;
        }
    }

    public Product? GetProductById(int id)
    {
        return _appDbContext.ProductList.FirstOrDefault(p => p.ProductId == id);
    }
}
