using SEP.Contract.Repositories;
using SEP.Contract.Services;
using SEP.Model.Model;
using System;
using System.Collections.Generic;

namespace SEP.Service.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseModel
    {
        private readonly IBaseRepository<T> _baseRepository;


        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public T GetById(int id)
        {
            return _baseRepository.GetById(id) as T;
        }

        public IEnumerable<T> GetAll()
        {
            return _baseRepository.GetAll() as IEnumerable<T>;
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}