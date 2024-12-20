using System;

namespace Uppfinnaren.Models;

public class CategoryRepository : ICategoryRepository
{
    private readonly AppDbContext _appDbContext;

    public CategoryRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public IEnumerable<Category> AllCategories
    {
        get
        {
            return _appDbContext.Categories;
        }
    }

    public Category GetCategoryById(int id)
    {
        return _appDbContext.Categories.FirstOrDefault(c => c.CategoryId == id);
    }
}
