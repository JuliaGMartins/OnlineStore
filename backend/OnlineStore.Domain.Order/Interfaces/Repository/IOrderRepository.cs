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
        void Create(Order order);

        void UpdateStatusCancelled(String code);

        void UpdateStatusAccepted(String code);

        Order GetOrderByCode(String code);

        void Delete(Order order);

        void Commit();
    }
}
