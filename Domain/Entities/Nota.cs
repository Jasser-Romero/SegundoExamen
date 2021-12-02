using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Nota
    {
        public Estudiante Estudiante { get; set; }
        public Asignatura Asignatura { get; set; }
        public int Sistematico { get; set; }
        public int PrimerParcial { get; set; }
        public int SegundoParcial { get; set; }
        public int Tarea { get; set; }
        public int NotaFinal => Sistematico + PrimerParcial + SegundoParcial+Tarea;
    }
}
