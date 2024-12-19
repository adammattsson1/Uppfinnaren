using System;
using Microsoft.AspNetCore.Mvc;
using Uppfinnaren.Models;

namespace Uppfinnaren.Controllers;

public class ProductsController : Controller
{
    private readonly IProductRepository _productRepository;

    public ProductsController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IActionResult Index()
    {
        return View(_productRepository.ProductList);
    }
    public IActionResult Category1()
    {
        return View();
    }
    public IActionResult Category2()
    {
        return View();
    }
    public IActionResult Category3()
    {
        return View();
    }
    public IActionResult Category4()
    {
        return View();
    }
    public IActionResult Category5()
    {
        return View();
    }
}
