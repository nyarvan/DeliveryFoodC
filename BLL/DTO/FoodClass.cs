namespace BLL
{
    public class FoodClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int? SetId { get; set; }

        public SetClass Set { get; set; }

        public int? DeliveryId { get; set; }
        public DeliveryClass Delivery { get; set; }
    }
}
