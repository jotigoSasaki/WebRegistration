using Microsoft.AspNetCore.Mvc;
using WebRegistration.models;
namespace WebRegistration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public ViewResult SignIn() => View();


        [HttpGet]
        public ViewResult SignUp() => View();

        [HttpPost]
        public ViewResult SignUp(User user)
        {


          return View();
        }
    }
}