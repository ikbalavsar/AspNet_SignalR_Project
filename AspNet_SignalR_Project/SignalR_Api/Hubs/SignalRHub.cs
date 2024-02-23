﻿using AutoMapper.Configuration.Annotations;
using Microsoft.AspNetCore.SignalR;
using SignalR_BusinessLayer.Abstract;
using SignalR_DataAccessLayer.Concrete;

namespace SignalR_Api.Hubs
{
	//The server of the application 
	public class SignalRHub : Hub
	{
		
		private readonly ICategoryService _categoryService;
		private readonly IProductService _productService;
		private readonly IOrderDetailService _orderDetailService;
		private readonly IOrderService _orderService;
		private readonly IRestaurantTableService _restaurantTableService;
        private readonly IMoneyCaseService _moneyCaseService;
        private readonly IBookingService _bookingService;
        private readonly INotificationService _notificationService;


        public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderDetailService orderDetailService,
            IOrderService orderService, IRestaurantTableService restaurantTableService, IMoneyCaseService moneyCaseService, IBookingService bookingService, INotificationService notificationService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderDetailService = orderDetailService;
            _orderService = orderService;
            _restaurantTableService = restaurantTableService;
            _moneyCaseService = moneyCaseService;
            _bookingService = bookingService;
            _notificationService = notificationService;
        }

        public async Task SendStatistic()
		{
			var value = _categoryService.TCategoryCount();
			await Clients.All.SendAsync("ReceiveCategoryCount", value);

            var value2 = _productService.TProductCount();
            await Clients.All.SendAsync("ReceiveProductCount", value2);

            var value3 = _categoryService.TActiveCategoryCount();
            await Clients.All.SendAsync("ReceiveActiveCategoryCount", value3);

            var value4 = _categoryService.TPassiveCategoryCount();
            await Clients.All.SendAsync("ReceivePassiveCategoryCount", value4);

            var value5 = _productService.TProductCountByCategoryNameByHamburger();
            await Clients.All.SendAsync("ReceiveProductCountByNameHamburger", value5);


            var value6 = _productService.TProductCountByCategoryNameByDrink();
            await Clients.All.SendAsync("ReceiveProductCountByNameDrink", value6);

            var value7 = _productService.TProductPriceAvg();
            await Clients.All.SendAsync("ReceiveProductPriceAvg", value7.ToString("0.00") + "₺");

            var value8 = _productService.TProductNameByMaxPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMaxPrice", value8);


            var value9 = _productService.TProductNameByMinPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMinPrice", value9);

            var value10 = _productService.TProductAvgPriceByBurger();
            await Clients.All.SendAsync("ReceiveProductAvgPriceByBurger", value10.ToString("0.00") + "₺");

            var value11 = _orderService.TTotalOrderCount();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", value11);

            var value12 = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value12);


            var value13 = _orderService.TLastOrderPrice();
            await Clients.All.SendAsync("ReceiveLastOrderPrice", value13.ToString("0.00") + "₺");

            var value14 = _moneyCaseService.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value14.ToString("0.00") + "₺");

            var value16 = _restaurantTableService.TTableCount();
            await Clients.All.SendAsync("ReceiveTableCount", value16);
        }


        public async Task SendProgress()
        {
            var value = _moneyCaseService.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value.ToString("0.00") + "₺");

            var value2 = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value2);

            var value3 = _restaurantTableService.TTableCount();
            await Clients.All.SendAsync("ReceiveTableCount", value3);
        }
		
        public async Task GetBookingList()
        {
            var values = _bookingService.TGetListAll();
            await Clients.All.SendAsync("ReceiveBookingList", values);
        }

        public async Task SendNotification()
        {
            var values = _notificationService.TNotificationCountByStatusFalse();
            await Clients.All.SendAsync("ReceiveNotificationCountByStatusFalse", values);

            var values1 = _notificationService.TGetAllNotificationsByFalse();
            await Clients.All.SendAsync("ReceiveGetAllNotificationsByFalse", values1);
        }
    }
}
