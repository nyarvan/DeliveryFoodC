using System.Collections.Generic;

namespace DataBase
{
    public class Set
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public List<Food> foods { get; set; }

        public int? DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
    }
}
