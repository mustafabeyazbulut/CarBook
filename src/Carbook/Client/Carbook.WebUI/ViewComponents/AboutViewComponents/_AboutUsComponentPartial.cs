using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebUI.ViewComponents.AboutViewComponents
{
    public class _AboutUsComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutUsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task< IViewComponentResult> InvokeAsync()
        {
            var client= _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("");
            return View();
        }
    }
}
