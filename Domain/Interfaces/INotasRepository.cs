using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface INotasRepository:IRepository<Nota>
    {
        int GetLastId();
        decimal Promedio(List<Nota> notas);
        List<Nota> GetNotasById(int id);
        ICollection<Nota> MejoresTres();
    }
}
