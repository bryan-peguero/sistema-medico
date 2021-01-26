using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class RPacientes : Form
    {
        public RPacientes()
        {
            InitializeComponent();
        }

        private void RPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SistemaMédicoDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.PacientesTableAdapter.Fill(this.SistemaMédicoDataSet.Pacientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
