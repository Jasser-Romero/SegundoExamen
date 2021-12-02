using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infraestructure.Repository
{
    public class NotasRepository:BaseRepository<Nota>,INotasRepository
    {
        public int GetLastId()
        {
            return registro.Count == 0 ? 0 : registro.Last().Estudiante.Id;
        }

        public List<Nota> GetNotasById(int id)
        {
            List<Nota> notas = registro.Where(x => x.Estudiante.Id == id).ToList();
            return notas;
        }

        public ICollection<Nota> MejoresTres()
        {
            var mejores = registro.OrderByDescending(x => x.NotaFinal).ToList();

            return mejores.Take(3).ToList();
        }

        public decimal Promedio(List<Nota> notas)
        {
            if (notas is null)
            {
                throw new ArgumentNullException(nameof(notas));
            }

            var suma = notas.Sum(x => x.NotaFinal);
            return suma / 6;
        }
    }
}
