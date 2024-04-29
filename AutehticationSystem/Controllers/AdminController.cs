using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.WebUtilities;
using System.Text.Encodings.Web;
using AutehticationSystem.Areas.Identity.Data;
using AutehticationSystem.Areas.Identity.Pages.Account;
using System.Text;
using System.Threading.Tasks; // Add this for Task
using System.Security.Principal;

namespace AuthenticationSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<AutehticationSystemUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AutehticationSystemUser> _signInManager;
        private readonly IEmailSender _emailSender;

        public AdminController(UserManager<AutehticationSystemUser> userManager, RoleManager<IdentityRole> roleManager, IEmailSender emailSender, SignInManager<AutehticationSystemUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _emailSender = emailSender;
            _signInManager = signInManager;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateEmployee(RegisterModel.InputModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new AutehticationSystemUser { UserName = model.Email, Email = model.Email, Name = model.Name };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    if (!await _roleManager.RoleExistsAsync("Employee"))
                    {
                        await _roleManager.CreateAsync(new IdentityRole("Employee"));
                    }
                    await _userManager.AddToRoleAsync(user, "Employee");

                    user.EmailConfirmed = true;
                    await _userManager.UpdateAsync(user);
                }


                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                TempData["employeeCreate"] = "Employee Create Successfully";

                model.Name = "";
                model.Email = "";
            }

            return View(model);
        }
    }
}
