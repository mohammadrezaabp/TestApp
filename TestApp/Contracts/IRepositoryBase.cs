using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        //CRUD

        ICollection<T> FindAll();
        T FindById(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();


    }
}
