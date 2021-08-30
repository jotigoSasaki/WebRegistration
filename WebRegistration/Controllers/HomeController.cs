using Microsoft.AspNetCore.Mvc;
using WebRegistration.models;
using System.Collections.Generic;
namespace WebRegistration.Controllers
{
    public class HomeController : Controller
    {
        public static List<User> SignInUsers = new List<User>();
        public IActionResult Index() => View();

        public ViewResult SignIn() => View();


        [HttpGet]
        public ViewResult SignUp() => View();

        [HttpPost]
        public ViewResult SignUp(User user)
        {

          
          return View("UserProfile",user);
        }
    }
}