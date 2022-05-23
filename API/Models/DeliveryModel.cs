using System;
using System.Collections.Generic;

namespace API
{
    public class DeliveryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime DeliveryTime { get; set; }
        public List<FoodModel> Foods { get; set; }
        public List<SetModel> Sets { get; set; }
    }
}
