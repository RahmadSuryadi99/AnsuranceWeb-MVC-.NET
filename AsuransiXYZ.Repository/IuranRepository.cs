using AsuransiXYZ.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsuransiXYZ.Repository
{
    public class IuranRepository : IRepository<IuranProduct>
    {
        public static IuranRepository instance = new IuranRepository();
        public static IuranRepository GetRepository() { return instance; }
        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<IuranProduct> GetAll()
        {
            throw new NotImplementedException();
        }

        public IuranProduct GetSingle(object id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(IuranProduct model)
        {
            throw new NotImplementedException();
        }

        public bool Update(IuranProduct model)
        {
            throw new NotImplementedException();
        }
    }
}
