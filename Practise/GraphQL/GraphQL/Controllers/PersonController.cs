using Microsoft.AspNetCore.Mvc;

namespace GraphQL.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
