using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Carts.Entities
{
    public class Cart
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public List<CartItem> Item { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
