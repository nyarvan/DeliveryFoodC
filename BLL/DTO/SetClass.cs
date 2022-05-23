using System.Collections.Generic;

namespace BLL
{
    public class SetClass
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<FoodClass> foods { get; set; }

        public int? DeliveryId { get; set; }
        public DeliveryClass Delivery { get; set; }
    }
}
