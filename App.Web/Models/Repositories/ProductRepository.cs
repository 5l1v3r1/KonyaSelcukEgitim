namespace App.Web.Models.Repositories
{
    public class ProductRepository
    {
        private List<Product> products= new List<Product>();

        public ProductRepository()
        {
            products.Add(new(){ Id=1, Name = "kalem 1", Price=100, Created = DateTime.Now});
            products.Add(new() { Id = 2, Name = "kalem 2", Price = 200, Created = DateTime.Now });
            products.Add(new() { Id = 3, Name = "kalem 3", Price = 300, Created = DateTime.Now });
        }



    }
}
