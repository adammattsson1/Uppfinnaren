using System;
using Microsoft.AspNetCore.Mvc;

namespace Uppfinnaren.Controllers;

public class ContactsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
