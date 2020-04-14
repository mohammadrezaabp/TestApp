using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Contracts;
using TestApp.Data;

namespace TestApp.Repository
{
    public class UrlRepository : IUrlRepository
    {
        private readonly ApplicationDbContext _db;

        public UrlRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Url entity)
        {
            _db.Urls.Add(entity);
            return Save();
        }

        public bool Delete(Url entity)
        {
            _db.Urls.Remove(entity);
            return Save();
        }

        public ICollection<Url> FindAll()
        {
            var Urls = _db.Urls.ToList();
            return Urls;
        }

        public Url FindById(int id)
        {
            var Url = _db.Urls.Find(id);
            return Url;
        }

        public ICollection<Url> GetUrlByCode(string code)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Url entity)
        {
            _db.Urls.Update(entity);
            return Save();
        }
    }
}
