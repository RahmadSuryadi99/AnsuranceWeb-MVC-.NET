using AsuransiXYZ.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsuransiXYZ.Repository
{
    public class KendaraanRepository : IRepository<Kendaraan>
    {
        public static KendaraanRepository instance = new KendaraanRepository();
        public static KendaraanRepository GetRepository() { return instance; }
        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Kendaraan> GetAll()
        {
            throw new NotImplementedException();
        }

        public Kendaraan GetSingle(object id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Kendaraan model)
        {
            throw new NotImplementedException();
        }

        public bool Update(Kendaraan model)
        {
            throw new NotImplementedException();
        }
    }
}
