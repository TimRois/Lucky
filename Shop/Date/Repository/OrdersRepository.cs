using Lucky.Date.interfaces;
using Lucky.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky.Date.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDbContent appDBContent;

        public OrdersRepository(AppDbContent appDBContnent)
        {
            this.appDBContent = appDBContnent;
        }

        public void createOrder(Order order)
        {
            //appDBContent.Order.Add(order);
            //appDBContent.SaveChanges();
            //var items = shopCart.listShopItems;
            //foreach (var el in items)
            //{
            //    var orderDeteil = new OrderDetail()
            //    {
            //        PetId = el.pet.Id,
            //        orderId = order.id
            //    };
            //    appDBContent.OrderDeteil.Add(orderDeteil);
            //}
            appDBContent.SaveChanges();
        }
    }
}
