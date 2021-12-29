﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using prak.eduhome._28._12._2021.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prak.eduhome._28._12._2021.Services
{
    public class LayoutService
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public LayoutService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }


        public List<BasketItemVM> GetBasketItems()
        {
            var itemsStr = _contextAccessor.HttpContext.Request.Cookies["Books"];

            List<BasketItemVM> items = new List<BasketItemVM>();
            if (itemsStr != null)
            {
                items = JsonConvert.DeserializeObject<List<BasketItemVM>>(itemsStr);
            }

            return items;
        }
    }
}
