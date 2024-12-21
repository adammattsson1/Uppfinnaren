using System;
using Microsoft.AspNetCore.Mvc;
using Uppfinnaren.Models;

namespace Uppfinnaren.Controllers;

public class ProductsController : Controller
{
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;

    public ProductsController(IProductRepository productRepository, ICategoryRepository categoryRepository)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
    }

    public IActionResult Index()
    {
        return View(_categoryRepository.AllCategories);
    }

    public IActionResult Category(int id)
    {
        ViewBag.category = _categoryRepository.GetCategoryById(id);
        return View(_productRepository.GetProductsFromCategory(id));
    }

    public IActionResult NewProductForm()
    {
        return View(_categoryRepository.AllCategories);
    }

    [HttpPost]
    public IActionResult SaveNewProduct(string name, string description, int price, int categoryid)
    {
        System.Console.WriteLine($"saved new product: {name}, {description}, {price}, {categoryid}");

        var newProduct = new Product{ Name = name, Description = description, Price = price, CategoryId = categoryid };
        
        _productRepository.SaveNewProduct(newProduct);

        var category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == categoryid);
        if(category != null)
        {
            TempData["AdditionMessage"] = $"Produkten {name} har skapats i kategorin {category.Name}.";
        }
        else
        {
            TempData["AdditionMessage"] = null;
        }

        return RedirectToAction("NewProductForm");
    }
}
