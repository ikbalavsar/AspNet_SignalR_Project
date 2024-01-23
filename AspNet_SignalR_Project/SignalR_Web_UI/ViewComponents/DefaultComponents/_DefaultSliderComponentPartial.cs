using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR_Web_UI.Dtos.SliderDtos;

namespace SignalR_Web_UI.ViewComponents.DefaultComponents
{
	public class _DefaultSliderComponentPartial : ViewComponent
	{

        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultSliderComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IViewComponentResult> InvokeAsync()
		{
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7067/api/Sliders");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSliderDto>>(jsonData);
                return View(values);
            }
            return View();
           
		}
	}
}
