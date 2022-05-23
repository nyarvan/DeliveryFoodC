namespace API
{
    public class FoodModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int? SetId { get; set; }

        public SetModel Set { get; set; }

        public int? DeliveryId { get; set; }
        public DeliveryModel Delivery { get; set; }
    }
}
