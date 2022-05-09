using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Orders.Entities;

namespace OnlineStore.Domain.Orders.Interfaces.Repository
{
    public interface IOrderRepository
    {
        Order Create(Order order);

        void UpdateStatusCancelled(Guid id);

        void UpdateStatusAccepted(Guid id);
        
        void UpdateStatusCancelPending(Guid id);

        Order GetOrderByCode(Guid id);

        void Delete(Order order);

        void Commit();
    }
}
