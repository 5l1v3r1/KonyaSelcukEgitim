using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.DIP
{
    internal class ProductRepositoryWithPostgreSQL:IProductRepository
    {
        public List<Product> GetList()
        {
            return new List<Product>()
            {
                new() { Id = 1, Name = "Kalem 1(postgre)", Price = 100 },
                new() { Id = 1, Name = "Kalem 2(postgre)", Price = 200 }
            };
        }
    }
}
