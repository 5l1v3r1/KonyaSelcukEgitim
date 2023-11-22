using App.Web.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Models.Services
{

    public class ProductService
    {

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public int  Save(ProductSaveViewModel productSaveViewModel)
        {

          return  _productRepository.Save(new(productSaveViewModel.Name, productSaveViewModel.Price, DateTime.Now));

        }

    }
}
