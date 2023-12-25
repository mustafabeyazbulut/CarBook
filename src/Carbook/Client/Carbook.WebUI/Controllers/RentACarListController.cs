using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebUI.Controllers
{
    public class RentACarListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
