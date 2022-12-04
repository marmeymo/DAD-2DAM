namespace Models
{
    public class Category
    {
        public int id_category { get; set; }
        public string description { get; set; }

        public Category() { }
        public Category(int id_category, string description)
        {
            this.id_category = id_category;
            this.description = description;
        }
    }
}
