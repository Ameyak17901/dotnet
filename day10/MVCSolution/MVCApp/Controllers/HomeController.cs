using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using System.Collections.Generic;
using BLL;
using BOL;

namespace MVCApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Products()
    {
        CatalogManager mgr = new CatalogManager();
        List<Product> products = mgr.GetAllProducts();
        ViewData["products"] = products;
        return View();
    }

    // [HttpPost]
    public IActionResult Edit()
    {
        return View();
    }

    // [HttpPost]
    // public IActionResult Edit(int id)
    // {
    //     // CatalogManager mgr = new CatalogManager();
    //     // bool status = mgr.UpdateProductDetails(id);
    //     // if(status) {
    //     //     this.RedirectToAction("Products");
    //     // }
    //     return View();
    // }
    // [HttpPost]
    public IActionResult Insert()
    {
        return View();
    }
    // [HttpPost]
    public IActionResult Delete()
    {
        return View();
    }
}
