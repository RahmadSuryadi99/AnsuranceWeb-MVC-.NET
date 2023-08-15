using AsuransiXYZ.DataAcces.Models;

namespace AsuransiXYZ.Repository
{
    public class NasabahRepository : IRepository<Nasabah>
    {
        private static NasabahRepository instance = new NasabahRepository();
        public static NasabahRepository GetRepository() { return instance; }
        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Nasabah> GetAll()
        {
            var _context = new AsuransiXyzContext();

            return _context.Nasabahs;

        }

        public Nasabah GetSingle(object id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Nasabah model)
        {
            throw new NotImplementedException();
        }

        public bool Update(Nasabah model)
        {
            throw new NotImplementedException();
        }
    }
}