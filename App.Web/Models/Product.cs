namespace App.Web.Models
{
    public class Product
    {
        public Product(string name, decimal price, DateTime created)
        {
            Name = name;
            Price = price;
            Created = created;
        }

        public Product(int id, string name, decimal price, DateTime created)
        {
            Id = id;
            Name = name;
            Price = price;
            Created = created;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public DateTime Created { get; set; }

        
    }
}
