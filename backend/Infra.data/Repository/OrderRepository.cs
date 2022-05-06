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

        public void Create(Order order)
        {
            orderContext.Orders.Add(order);
        }

        public void Commit()
        {
            orderContext.SaveChanges();
        }

        public void Delete(Order order)
        {
            orderContext.Orders.Remove(order);
        }

        public Order GetOrderByCode(string code)
        {
            return orderContext.Orders.FirstOrDefault(order => order.Code.Equals(code));
        }

        public void UpdateStatusAccepted(string code)
        {
            var order = new Order() { Code = code};
            using (var db = orderContext)
            {
                db.Orders.Attach(order).Property(Status => "Accepted");
            }
        }

        public void UpdateStatusCancelled(string code)
        {
            var order = new Order() { Code = code };
            using (var db = orderContext)
            {
                db.Orders.Attach(order).Property(Status => "Cancelled");
            }
        }
    }
}
