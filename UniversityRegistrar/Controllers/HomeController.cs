using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar;

namespace UniversityRegistrar.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
