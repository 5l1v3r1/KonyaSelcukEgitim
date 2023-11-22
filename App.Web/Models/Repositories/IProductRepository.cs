
namespace App.Web.Models.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetProducts2 { get; }

        void DeleteById(int id);
        Product? GetById(int id);
        int Save(Product productToCreate);
        void Update(Product productToUpdate);
    }
}