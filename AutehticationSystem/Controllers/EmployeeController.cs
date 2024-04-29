using Microsoft.AspNetCore.Mvc;

namespace AutehticationSystem.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
