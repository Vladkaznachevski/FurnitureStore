﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.OrderSer
{
    public interface IOrderService
    {
        void CreateOrder(Order order);

    }
}
