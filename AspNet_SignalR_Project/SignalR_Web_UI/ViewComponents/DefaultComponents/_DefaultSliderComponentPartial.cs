﻿using Microsoft.AspNetCore.Mvc;

namespace SignalR_Web_UI.ViewComponents.DefaultComponents
{
	public class _DefaultSliderComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
