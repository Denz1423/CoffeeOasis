using server.Entities.OrderAggregate;

namespace server.DTOs
{
    public class CreateOrderDto
    {
        public bool SaveAddress { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        
    }
}