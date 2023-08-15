using AsuransiXYZ.DataAcces.Models;

namespace AsuransiXYZ.Repository
{
    public class ProspectRepository : IRepository<Prospect>
    {
        private static ProspectRepository instance = new ProspectRepository();
        public static ProspectRepository GetRepository() { return instance; }
        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Prospect> GetAll()
        {
            var _context = new AsuransiXyzContext();
            
             return _context.Prospects;
            
        }

        public Prospect GetSingle(object id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Prospect model)
        {
            throw new NotImplementedException();
        }

        public bool Update(Prospect model)
        {
            throw new NotImplementedException();
        }
    }
}