using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Repository
{
    public abstract class BaseRepository<T>:IRepository<T>
    {
        protected List<T> registro;
        public BaseRepository()
        {
            registro = new List<T>();
        }

        public void Create(T t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            registro.Add(t);
        }

        public void Delete(int index)
        {
            registro.RemoveAt(index);
        }

        public ICollection<T> GetAll()
        {
            return registro;
        }
    }
}
