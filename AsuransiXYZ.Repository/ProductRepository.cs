using AsuransiXYZ.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsuransiXYZ.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        public static ProductRepository instance = new ProductRepository();
        public static ProductRepository GetRepository() { return instance; }
        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetSingle(object id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Product model)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product model)
        {
            throw new NotImplementedException();
        }
    }
}
