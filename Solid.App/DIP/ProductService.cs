namespace Solid.App.DIP
{
    internal class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public List<Product> GetList()
        {

            

            var productListWithKdv = _productRepository.GetList().Select(x => new Product()
            {
                Name = x.Name,
                Id = x.Id,
                Price = x.Price * (decimal)1.20
            }).ToList();



            return productListWithKdv;
        }
    }
}
