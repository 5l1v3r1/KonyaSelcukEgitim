namespace Solid.App.DIP
{
    internal class ProductController
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public List<Product> GetAll()
        {
           
            return _productService.GetList();

        }


    }
}
