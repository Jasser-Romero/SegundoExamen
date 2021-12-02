using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class NotasService : BaseService<Nota>, INotaService
    {
        private INotasRepository repository1;
        public NotasService(INotasRepository repository) : base(repository)
        {
            this.repository1 = repository;
        }

        public int GetLastId()
        {
            return repository1.GetLastId();
        }

        public List<Nota> GetNotasById(int id)
        {
            return repository1.GetNotasById(id);
        }

        public ICollection<Nota> MejoresTres()
        {
            return repository1.MejoresTres();
        }

        public decimal Promedio(List<Nota> notas)
        {
            return repository1.Promedio(notas);
        }
    }
}
