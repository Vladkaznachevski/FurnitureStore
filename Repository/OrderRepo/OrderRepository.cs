using Data;
using Repository.ShopCartRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.OrderRepo
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationContext _context;

        private readonly ShopCartRepository shopCart;
        public OrderRepository(ApplicationContext context, ShopCartRepository shopCart)
        {
            _context = context;
            this.shopCart = shopCart;
        }


        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now; // Задаём время заказа
            order.ModifiedDate = DateTime.Now;
            order.CreatedDate = DateTime.Now;
            _context.Orders.Add(order); // Добавляем заказ в SQL таблицу
            _context.SaveChanges();

            var items = shopCart.listShopItems; // Получаем список товаров из корзины
            foreach (var el in items)  // Перебираем корзину
            {
                var orderDetail = new OrderDetail() // создаём класс информации о заказе
                {
                    ProductId = el.Product.Id, // Заполняем айди Еды
                    OrderId = order.Id, // заполняем айди Заказа
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                };
                _context.OrderDetails.Add(orderDetail);
            }
            _context.SaveChanges();

        }

    }
}