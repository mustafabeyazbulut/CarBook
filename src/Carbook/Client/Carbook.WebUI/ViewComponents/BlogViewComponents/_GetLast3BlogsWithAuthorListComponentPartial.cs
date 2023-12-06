using Carbook.Dto.BlogDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Carbook.WebUI.ViewComponents.BlogViewComponents
{
    public class _GetLast3BlogsWithAuthorListComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _contextFactory;
        public _GetLast3BlogsWithAuthorListComponentPartial(IHttpClientFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client= _contextFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7166/api/Blogs/GetLast3BlogsWithAuthorsList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values= JsonConvert.DeserializeObject<List<ResultLast3BlogsWithAuthorsDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
