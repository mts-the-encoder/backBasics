using Microsoft.AspNetCore.Mvc;

namespace ASPNETMVPCRUD.Controllers
{
    public class EmployeesController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


    }
}
