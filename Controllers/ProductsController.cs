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
}
