using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.OrderRepo
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
