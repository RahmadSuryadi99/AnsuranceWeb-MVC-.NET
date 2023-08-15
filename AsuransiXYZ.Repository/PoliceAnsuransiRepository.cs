using AsuransiXYZ.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsuransiXYZ.Repository
{
    public class PoliceAsuransiRepository : IRepository<PoliceAnsuransi>
    {
        public static PoliceAsuransiRepository instance = new PoliceAsuransiRepository();
        public static PoliceAsuransiRepository GetRepository() { return instance; }
        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PoliceAnsuransi> GetAll()
        {
            throw new NotImplementedException();
        }

        public PoliceAnsuransi GetSingle(object id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PoliceAnsuransi model)
        {
            throw new NotImplementedException();
        }

        public bool Update(PoliceAnsuransi model)
        {
            throw new NotImplementedException();
        }
    }
}
