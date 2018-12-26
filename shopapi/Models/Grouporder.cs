using System.Collections.Generic;

namespace shopapi.Models
{
     public class Grouporder
    {
        public List<Order> OrderGroup { get; set; }
        public double Average { get; set; }
    }

}