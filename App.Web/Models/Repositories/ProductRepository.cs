namespace App.Web.Models.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private static List<Product> products = new List<Product>();

        static ProductRepository()
        {
            products.Add(new(1, "kalem 1", 100, DateTime.Now));
            products.Add(new(2, "kalem 2", 200, DateTime.Now));
            products.Add(new(3, "kalem 3", 300, DateTime.Now));
        }

        public int Save(Product productToCreate)
        {

            var newId = new Random().Next(4, 10000);
            productToCreate.Id = newId;
            products.Add(productToCreate);
            return productToCreate.Id;

        }

        public List<Product> GetProducts2 => products;

        public Product? GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
        public void Update(Product productToUpdate)
        {

            var productIndex = products.FindIndex(x => x.Id == productToUpdate.Id);

            if (productIndex >= 0)
            {
                products[productIndex].Name = productToUpdate.Name;
                products[productIndex].Price = productToUpdate.Price;

            }
        }
        public void DeleteById(int id)
        {
            var hasProduct = GetById(id);

            if (hasProduct is not null)
            {
                products.Remove(hasProduct);
            }

        }





    }
}
