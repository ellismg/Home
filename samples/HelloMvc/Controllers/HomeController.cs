using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;

namespace MvcSample.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name)
        {
            return View(CreateUser(name ?? "world"));
        }

        public User CreateUser(string name)
        {
            User user = new User()
            {
                Name = name,
            };

            return user;
        }
    }
}
