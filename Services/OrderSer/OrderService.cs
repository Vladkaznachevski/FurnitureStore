using Data;
using Repository.OrderRepo;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.OrderSer
{
    public class OrderService : IOrderService
    {

        private IOrderRepository _repository;


        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public void CreateOrder(Order order)
        {
            _repository.CreateOrder(order);
        }


    }
}
