﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WomenAccessoriesShop.Models.Repositories
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
