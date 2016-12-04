using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP.Contract.Services
{
    public interface IBaseService<T> where T : class
    {

        T GetById(int id);

        IEnumerable<T> GetAll();

        void Insert(T entity);

        void Update(T entity);

        void Delete(int id);

    }
}
