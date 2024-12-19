using System;

namespace Uppfinnaren.Models;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _appDbContext;

    public ProductRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public IEnumerable<Product> ProductList 
    {
        get
        {
            return _appDbContext.ProductList;
        }
    }

    public IEnumerable<Product> Category1 => throw new NotImplementedException();

    public IEnumerable<Product> Category2 => throw new NotImplementedException();

    public IEnumerable<Product> Category3 => throw new NotImplementedException();

    public IEnumerable<Product> Category4 => throw new NotImplementedException();

    public IEnumerable<Product> Category5 => throw new NotImplementedException();

    public Product? GetProductById(int id)
    {
        return _appDbContext.ProductList.FirstOrDefault(p => p.ProductId == id);
    }
}
