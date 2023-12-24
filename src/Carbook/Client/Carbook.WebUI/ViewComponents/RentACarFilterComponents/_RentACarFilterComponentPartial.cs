using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebUI.ViewComponents.RentACarFilterComponents
{
    public class _RentACarFilterComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
