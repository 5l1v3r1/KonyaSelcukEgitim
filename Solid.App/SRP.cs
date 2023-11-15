using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.SRP
{

    internal class ProductRepository
    {

        public List<Product> Products { get; set; }

        public ProductRepository()
        {
            Products.Add(new() { Id = 1, Name = "kalem 1" });
            Products.Add(new() { Id = 2, Name = "kalem 2" });
        }

       


        public void SaveOrUpdate()
        {
        }
        public void Delete() { }

    }

    internal class ProductPresent
    {
        public void WriteToConsole(List<Product> products)
        {

            products.ForEach(x =>
            {
                Console.WriteLine(x.Name);
            });
        }

    }

    internal class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }

      

      

    }
}
