using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebUI.ViewComponents.AboutViewComponents
{
	public class _BecomeADriveComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
