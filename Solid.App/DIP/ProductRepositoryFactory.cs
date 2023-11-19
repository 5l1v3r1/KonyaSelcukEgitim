namespace Solid.App.DIP
{
    internal class ProductRepositoryFactory
    {

        public IProductRepository GetInstance()
        {
            return new ProductRepository();
        }
        public IProductRepository GetPostgreInstance()
        {
            return new ProductRepositoryWithPostgreSQL();
        }
    }
}
