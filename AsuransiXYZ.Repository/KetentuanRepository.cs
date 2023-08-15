using AsuransiXYZ.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsuransiXYZ.Repository
{
    public class KetentuanRepository : IRepository<KetentuanProduct>
    {
        public static KetentuanRepository instance = new KetentuanRepository();
        public static KetentuanRepository GetRepository() { return instance; }
        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<KetentuanProduct> GetAll()
        {
            throw new NotImplementedException();
        }

        public KetentuanProduct GetSingle(object id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(KetentuanProduct model)
        {
            throw new NotImplementedException();
        }

        public bool Update(KetentuanProduct model)
        {
            throw new NotImplementedException();
        }
    }
}
