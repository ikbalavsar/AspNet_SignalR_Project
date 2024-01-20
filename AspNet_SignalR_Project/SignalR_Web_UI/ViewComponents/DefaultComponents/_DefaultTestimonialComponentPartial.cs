using Microsoft.AspNetCore.Mvc;

namespace SignalR_Web_UI.ViewComponents.DefaultComponents
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
