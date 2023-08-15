using AsuransiXYZ.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsuransiXYZ.Repository
{
    public class JenisRepository : IRepository<JenisProduct>
    {
        public static JenisRepository instance = new JenisRepository();
        public static JenisRepository GetRepository() { return instance; }
        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<JenisProduct> GetAll()
        {
            throw new NotImplementedException();
        }

        public JenisProduct GetSingle(object id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(JenisProduct model)
        {
            throw new NotImplementedException();
        }

        public bool Update(JenisProduct model)
        {
            throw new NotImplementedException();
        }
    }
}
