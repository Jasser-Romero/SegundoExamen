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
    public partial class FrmVerNotas : Form
    {
        public INotaService notaService { get; set; }
        public List<Nota> notas = new List<Nota>();
        public int Id { get; set; }
        public FrmVerNotas()
        {
            InitializeComponent();
        }

        private void FrmVerNotas_Load(object sender, EventArgs e)
        {

        }
    }
}
