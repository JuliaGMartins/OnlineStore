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
        public void CancelOrder(Guid id)
        {
            orderRepository.UpdateStatusCancelled(id);
        }

        public Order CreateOrder(Order order)
        {
            return orderRepository.Create(order);
        }

        public Order FindOrder(Guid id)
        {
            return orderRepository.GetOrderByCode(id);
        }

        public void UpdateOrderStatusFinished(Guid id)
        {
            orderRepository.UpdateStatusAccepted(id);
        }

        public void UpdateOrderStatusCancelPending(Guid id)
        {
            orderRepository.UpdateStatusCancelPending(id);
        }
    }
}
