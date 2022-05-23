
namespace DataBase
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int? SetId { get; set; }

        public Set Set { get; set; }

        public int? DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
    }
}
