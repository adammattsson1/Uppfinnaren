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
            TempData["SuccessfulAdditionMessage"] = $"Produkten {name} har skapats i kategorin {category.Name}.";
        }
        else
        {
            TempData["SuccessfulAdditionMessage"] = null;
        }

        return RedirectToAction("NewProductForm");
    }

    public IActionResult UpdateProductForm()
    {
        ViewBag.products = _productRepository.AllProducts;
        return View(_categoryRepository.AllCategories);
    }
    
    [HttpPost]
    public IActionResult SaveUpdatedProduct(string name, string description, int price, int productId)
    {
        System.Console.WriteLine($"{name}, {description}, {price}, {productId}");
    
        _productRepository.UpdateProduct(name, description, price, productId);
        
        TempData["SuccessfulUpdateMessage"] = $"Produkten {name} har uppdaterats.";

        return RedirectToAction("UpdateProductForm");
    }
}
