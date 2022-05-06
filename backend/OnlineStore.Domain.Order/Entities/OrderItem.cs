namespace OnlineStore.Domain.Orders.Entities
{
    public class OrderItem
    {
        public Guid Id { get; set; }

        public string OrderCode { get; set; }

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Total { get; set; }

    }
}