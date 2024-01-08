using IdentityProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        [HttpGet]
       //[Route("signup")]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(SignUpUserModel userModel)
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
