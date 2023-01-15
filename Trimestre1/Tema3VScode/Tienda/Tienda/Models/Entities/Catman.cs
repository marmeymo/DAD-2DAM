namespace Models
{
    public class Catman
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public Catman() { }

        public Catman(int id, string name, string category, string description, double price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
