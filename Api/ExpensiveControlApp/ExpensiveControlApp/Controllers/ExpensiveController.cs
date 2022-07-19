using ExpensiveControlApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ExpensiveControlApp.Services;

namespace ExpensiveControlApp.Controllers
{
    public class ExpensiveController : Controller
    {
        private readonly ILogger<ExpensiveController> _logger;
        private readonly IExpensiveServices _expensiveServices;

        public ExpensiveController(ILogger<ExpensiveController> logger,
            IExpensiveServices expensiveServices)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}