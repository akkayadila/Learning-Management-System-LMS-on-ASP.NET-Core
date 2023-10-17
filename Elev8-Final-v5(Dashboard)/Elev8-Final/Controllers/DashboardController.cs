using Microsoft.AspNetCore.Mvc;

namespace Elev8_Final.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
