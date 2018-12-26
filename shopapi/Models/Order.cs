namespace shopapi.Models
{
    public class Order
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public int Sum { get; set; }
        public string Group { get; set; }

    }

}