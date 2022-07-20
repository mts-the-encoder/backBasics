using ExpensiveControlApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ExpensiveControlApp.DTOs;
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
            _expensiveServices = expensiveServices;
        }

        public async Task<IActionResult> Index()
        {
            var listExpensiveDto = new ListExpensiveDTO();

            listExpensiveDto.Items = await _expensiveServices.FindBy(listExpensiveDto.StartDate,
                listExpensiveDto.EndDate);

            return View(listExpensiveDto);
        }

        [HttpPost]
        public async Task<IActionResult> Index(ListExpensiveDTO listExpensiveDto)
        {
            try
            {
                listExpensiveDto.Items = await _expensiveServices.FindBy(listExpensiveDto.StartDate,
                    listExpensiveDto.EndDate);

                return View(listExpensiveDto);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("CustomError", ex.Message);
                return View(listExpensiveDto);

            }
        }

        public async Task<IActionResult> Create()
        {
            var createtExpensiveDto = new CreateExpensiveDTO(); 

            return View(createtExpensiveDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateExpensiveDTO createExpensiveDto)
        {
            try
            {
                await _expensiveServices.Create(createExpensiveDto);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("CustomError", e.Message);
                return View(createExpensiveDto);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}