using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailParagraphComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
