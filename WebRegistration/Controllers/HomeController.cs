using Microsoft.AspNetCore.Mvc;
namespace WebRegistration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public ViewResult SignIn() => View();

        public ViewResult SignUp() => View();
    }
}