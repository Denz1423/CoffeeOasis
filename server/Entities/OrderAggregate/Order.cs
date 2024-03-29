using System.ComponentModel.DataAnnotations;

namespace server.Entities.OrderAggregate
{
    public class Order
    {
        public int Id { get; set; }
        public string  BuyerId { get; set; }
        [Required]
        public ShippingAddress ShippingAddress { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public List<OrderItem> OrderItems { get; set; }
        public double Subtotal { get; set; }
        public double DeliveryFee { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;

        public long GetTotal()
        {
            return (long)(Subtotal + DeliveryFee);
        }
    }
}