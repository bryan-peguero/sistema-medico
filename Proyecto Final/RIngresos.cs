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
    public partial class RIngresos : Form
    {
        public RIngresos()
        {
            InitializeComponent();
        }

        private void RIngresos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SistemaMédicoDataSet.Internamientos' Puede moverla o quitarla según sea necesario.
            this.InternamientosTableAdapter.Fill(this.SistemaMédicoDataSet.Internamientos);

            this.reportViewer1.RefreshReport();
        }
    }
}
