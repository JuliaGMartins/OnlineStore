﻿namespace OnlineStore.Domain.Carts.Entities
{
    public class CartItem
    {
        public Guid Id { get; set; }

        public Guid CartId { get; set; }

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Total { get; set; }
    }
}