namespace Models.Entities
{
    public class Basket
    {
        public int id { get; set; }
        public string name { get; set; }
        public double total { get; set; }

        public Basket() { }

        public Basket(int id, string name, double total)
        {
            this.id = id;
            this.name = name;
            this.total = total;
        }
    }
}
