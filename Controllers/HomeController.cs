using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Act2MVC.Models;

namespace Act2MVC.Controllers;

public class HomeController : Controller
{
    private readonly SalesContext _context;

    public HomeController(SalesContext context)
    {
        _context = context;
    }

    // GET: Sales
        public async Task<IActionResult> Index()
        {
              return _context.Sale != null ? 
                          View(await _context.Sale.ToListAsync()) :
                          Problem("Entity set 'SalesContext.Sale'  is null.");
        }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
