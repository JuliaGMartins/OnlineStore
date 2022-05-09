using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.data.Context;
using OnlineStore.Domain.Orders.Entities;
using OnlineStore.Domain.Orders.Interfaces.Repository;

namespace Infra.data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderContext orderContext;

        public OrderRepository(OrderContext orderContext)
        {
            this.orderContext = orderContext;
        }

        public Order Create(Order order)
        {
            orderContext.Orders.Add(order);
            return order;
        }

        public void Commit()
        {
            orderContext.SaveChanges();
        }

        public void Delete(Order order)
        {
            orderContext.Orders.Remove(order);
        }

        public Order GetOrderByCode(Guid id)
        {
            return orderContext.Orders.FirstOrDefault(order => order.Id.Equals(id));
        }

        public void UpdateStatusAccepted(Guid id)
        {
            var order = new Order() { Id = id };
            using (var db = orderContext)
            {
                db.Orders.Attach(order).Property(Status => "Accepted");
            }
        }

        public void UpdateStatusCancelPending(Guid id)
        {
            var order = new Order() { Id = id };
            using (var db = orderContext)
            {
                db.Orders.Attach(order).Property(Status => "CancelPending");
            }
        }

        public void UpdateStatusCancelled(Guid id)
        {
            var order = new Order() { Id = id };
            using (var db = orderContext)
            {
                db.Orders.Attach(order).Property(Status => "Cancelled");
            }
        }
    }
}
