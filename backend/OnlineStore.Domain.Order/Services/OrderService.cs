using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Orders.Entities;
using OnlineStore.Domain.Orders.Interfaces.Repository;
using OnlineStore.Domain.Orders.Interfaces.Services;

namespace OnlineStore.Domain.Orders.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;

        }
        public void CancelOrder(string code)
        {
            throw new NotImplementedException();
        }

        public Order CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Order FindOrder(string code)
        {
            throw new NotImplementedException();
        }

        public Order UpdateOrderStatus(string code, OrderStatus orderStatus)
        {
            throw new NotImplementedException();
        }
    }
}
