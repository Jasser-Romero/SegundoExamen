using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Interfaces;

namespace AppCore.Services
{
    public class BaseService<T> : IService<T>
    {
        public IRepository<T> repository;
        public BaseService(IRepository<T> repository)
        {
            this.repository = repository;
        }
        public void Create(T t)
        {
            repository.Create(t);
        }

        public ICollection<T> GetAll()
        {
            return repository.GetAll();
        }
    }
}
