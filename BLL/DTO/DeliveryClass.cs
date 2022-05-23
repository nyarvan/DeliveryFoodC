using System;
using System.Collections.Generic;

namespace BLL
{
    public class DeliveryClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime DeliveryTime { get; set; }
        public List<FoodClass> Foods { get; set; }
        public List<SetClass> Sets { get; set; }
    }
}
