using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Orders.Entities;

namespace OnlineStore.Domain.Orders.Interfaces.Services
{
    public interface IOrderService
    {
        Order CreateOrder(Order order);

        void CancelOrder(Guid id);

        Order FindOrder(Guid id);

        void UpdateOrderStatusFinished(Guid id);

        void UpdateOrderStatusCancelPending(Guid id);
    }
}
