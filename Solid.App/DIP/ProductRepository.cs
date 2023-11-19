namespace Solid.App.DIP
{
    internal class ProductRepository:IProductRepository
    {

        public List<Product> GetList()
        {

            return new List<Product>()
            {
                new() { Id = 1, Name = "Kalem 1", Price = 100 },
                new() { Id = 1, Name = "Kalem 2", Price = 200 }
            };
        }
    }
}
