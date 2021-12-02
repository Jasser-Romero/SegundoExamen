using AppCore.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoExamen.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public INotaService notaService;
        public List<Estudiante> estudiantes = new List<Estudiante>();
        public FrmPrincipal(INotaService notaService)
        {
            this.notaService = notaService;
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmEstudiante frmAgregar = new FrmEstudiante();
            frmAgregar.notasService = notaService;
            frmAgregar.estudiantes = estudiantes;
            frmAgregar.ShowDialog();

            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = estudiantes;
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            if(dgvEstudiantes.SelectedRows.Count < 0)
            {
                MessageBox.Show("Seleccione estudiante","Error");
                return;
            }
            List<Nota> notaList = notaService.GetNotasById((int)dgvEstudiantes.CurrentRow.Cells[0].Value);
            decimal total = notaService.Promedio(notaList);
            MessageBox.Show($"El promedio es de: {total}");
        }

        private void btnMejores_Click(object sender, EventArgs e)
        {
            List<Nota> mejores = notaService.MejoresTres().ToList();
            decimal promedio = notaService.Promedio(mejores);
            if (mejores == null)
            {
                return;
            }
            MessageBox.Show($"Las mejores notas pertenecen a los estudiantes: \n" +
                            $"{mejores[0].Estudiante.Nombre}  {promedio}\n" +
                            $"{mejores[1].Estudiante.Nombre}   {promedio}\n" +
                            $"{mejores[2].Estudiante.Nombre}   {promedio}");
        }

        private void btnVerNotas_Click(object sender, EventArgs e)
        {
            FrmVerNotas frmVerNotas = new FrmVerNotas();
            frmVerNotas.notaService = notaService;
            frmVerNotas.ShowDialog();
        }
    }
}
