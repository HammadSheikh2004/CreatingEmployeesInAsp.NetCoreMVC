using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutehticationSystem.Controllers
{
    public class UserController : Controller
    {
        [Authorize (Roles = "User")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
