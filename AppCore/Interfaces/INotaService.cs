using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface INotaService : IService<Nota>
    {
        int GetLastId();
        decimal Promedio(List<Nota> notas);
        List<Nota> GetNotasById(int id);
        ICollection<Nota> MejoresTres();
    }
}
