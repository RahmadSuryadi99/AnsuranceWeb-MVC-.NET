using AsuransiXYZ.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsuransiXYZ.Repository
{
    public class PaymentRepository : IRepository<PaymentMethod>
    {
        public static PaymentRepository instance = new PaymentRepository();
        public static PaymentRepository GetRepository() { return instance; }
        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PaymentMethod> GetAll()
        {
            throw new NotImplementedException();
        }

        public PaymentMethod GetSingle(object id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PaymentMethod model)
        {
            throw new NotImplementedException();
        }

        public bool Update(PaymentMethod model)
        {
            throw new NotImplementedException();
        }
    }
}
