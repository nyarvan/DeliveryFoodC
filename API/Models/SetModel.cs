using System.Collections.Generic;

namespace API
{
    public class SetModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<FoodModel> foods { get; set; }

        public int? DeliveryId { get; set; }
        public DeliveryModel Delivery { get; set; }
    }
}
