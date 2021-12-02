using AppCore.Interfaces;
using Domain.Entities;
using Domain.Enums;
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
    public partial class FrmEstudiante : Form
    {
        public INotaService notasService { get; set; }
        int contador = 0;
        Asignatura asignatura1 = Asignatura.ContabilidadCosto;
        Asignatura asignatura2 = Asignatura.Sociologia;
        Asignatura asignatura3 = Asignatura.MatematicaII;
        Asignatura asignatura4 = Asignatura.InglesII;
        Asignatura asignatura5 = Asignatura.AlgebraLineal;
        Asignatura asignatura6 = Asignatura.ProgramacionI;
        public List<Estudiante> estudiantes = new List<Estudiante>();
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtNombre.ReadOnly = true;
            txtApellidos.ReadOnly = true;
            txtCarnet.ReadOnly = true;
            txtDepartamento.ReadOnly = true;
            txtMunicipio.ReadOnly = true;

            nudSistematico.Value = 0;
            nudPrimerParcial.Value = 0;
            nudSegundoParcial.Value = 0;
            nudTarea.Value = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                Estudiante estudiante = new Estudiante()
                {
                    Id = notasService.GetLastId() + 1,
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    Carnet = txtCarnet.Text,
                    Departamento = txtDepartamento.Text,
                    Municipio = txtMunicipio.Text
                };
                estudiantes.Add(estudiante);

                Nota notas1 = new Nota()
                {
                    Asignatura = asignatura1,
                    Estudiante = estudiante,
                    Sistematico = (int)nudSistematico.Value,
                    PrimerParcial = (int)nudPrimerParcial.Value,
                    SegundoParcial = (int)nudSegundoParcial.Value
                };
                notasService.Create(notas1);
                lblClase.Text = asignatura2.ToString();
                txtId.Text = estudiante.Id.ToString();
            }

            if (contador == 1)
            {
                Estudiante estudiante = new Estudiante()
                {
                    Id = Convert.ToInt32(txtId.Text),
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    Carnet = txtCarnet.Text,
                    Departamento = txtDepartamento.Text,
                    Municipio = txtMunicipio.Text
                };
                Nota notas1 = new Nota()
                {
                    Asignatura = asignatura2,
                    Estudiante = estudiante,
                    Sistematico = (int)nudSistematico.Value,
                    PrimerParcial = (int)nudPrimerParcial.Value,
                    SegundoParcial = (int)nudSegundoParcial.Value,
                    Tarea = (int)nudTarea.Value
                };
                notasService.Create(notas1);
                lblClase.Text = asignatura3.ToString();
                txtId.Text = estudiante.Id.ToString();
            }
            if (contador == 2)
            {
                Estudiante estudiante = new Estudiante()
                {
                    Id = Convert.ToInt32(txtId.Text),
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    Carnet = txtCarnet.Text,
                    Departamento = txtDepartamento.Text,
                    Municipio = txtMunicipio.Text
                };
                Nota notas1 = new Nota()
                {
                    Asignatura = asignatura3,
                    Estudiante = estudiante,
                    Sistematico = (int)nudSistematico.Value,
                    PrimerParcial = (int)nudPrimerParcial.Value,
                    SegundoParcial = (int)nudSegundoParcial.Value,
                    Tarea = (int)nudTarea.Value
                };
                notasService.Create(notas1);
                lblClase.Text = asignatura4.ToString();
                txtId.Text = estudiante.Id.ToString();
            }
            if (contador == 3)
            {
                Estudiante estudiante = new Estudiante()
                {
                    Id = Convert.ToInt32(txtId.Text),
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    Carnet = txtCarnet.Text,
                    Departamento = txtDepartamento.Text,
                    Municipio = txtMunicipio.Text
                };
                Nota notas1 = new Nota()
                {
                    Asignatura = asignatura4,
                    Estudiante = estudiante,
                    Sistematico = (int)nudSistematico.Value,
                    PrimerParcial = (int)nudPrimerParcial.Value,
                    SegundoParcial = (int)nudSegundoParcial.Value,
                    Tarea = (int)nudTarea.Value
                };
                notasService.Create(notas1);
                lblClase.Text = asignatura5.ToString();
                txtId.Text = estudiante.Id.ToString();
            }
            if (contador == 4)
            {
                Estudiante estudiante = new Estudiante()
                {
                    Id = Convert.ToInt32(txtId.Text),
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    Carnet = txtCarnet.Text,
                    Departamento = txtDepartamento.Text,
                    Municipio = txtMunicipio.Text
                };
                Nota notas1 = new Nota()
                {
                    Asignatura = asignatura5,
                    Estudiante = estudiante,
                    Sistematico = (int)nudSistematico.Value,
                    PrimerParcial = (int)nudPrimerParcial.Value,
                    SegundoParcial = (int)nudSegundoParcial.Value,
                    Tarea = (int)nudTarea.Value
                };
                notasService.Create(notas1);
                lblClase.Text = asignatura6.ToString();
                txtId.Text = estudiante.Id.ToString();
            }
            if (contador == 5)
            {
                Estudiante estudiante = new Estudiante()
                {
                    Id = Convert.ToInt32(txtId.Text),
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    Carnet = txtCarnet.Text,
                    Departamento = txtDepartamento.Text,
                    Municipio = txtMunicipio.Text
                };
                Nota notas1 = new Nota()
                {
                    Asignatura = asignatura6,
                    Estudiante = estudiante,
                    Sistematico = (int)nudSistematico.Value,
                    PrimerParcial = (int)nudPrimerParcial.Value,
                    SegundoParcial = (int)nudSegundoParcial.Value,
                    Tarea = (int)nudTarea.Value
                };
                notasService.Create(notas1);
                lblClase.Text = asignatura6.ToString();
                MessageBox.Show("Todas las clases agregadas correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
                txtId.Text = estudiante.Id.ToString();
            }
            contador++;
            LimpiarCampos();

        }

        private void FrmEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
