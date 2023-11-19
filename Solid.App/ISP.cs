using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.ISP
{
    public class ProductRepository : IReadProductRepository,IWriteProductRepository
    {
        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetById()
        {
            throw new NotImplementedException();
        }

        public void Where()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }

    public interface IReadProductRepository
    {
        void Get();
        void GetById();
        void Where();
    }

    public interface IWriteProductRepository
    {
        void Save();
        void Update();
        void Delete();
    }

   public interface IProductRepository
   {
     
     
   }


}
