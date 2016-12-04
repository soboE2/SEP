using SEP.Model.Model;
using System.Collections.Generic;

namespace SEP.Contract.Repositories
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        T GetById(int id);

        IEnumerable<T> GetAll();

        void Insert(T entity);

        void Update(T entity);

        void Delete(int id);
    }
}