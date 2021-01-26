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
    public partial class RCitas : Form
    {
        public RCitas()
        {
            InitializeComponent();
        }

        private void RCitas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SistemaMédicoDataSet.Citas' Puede moverla o quitarla según sea necesario.
            this.CitasTableAdapter.Fill(this.SistemaMédicoDataSet.Citas);

            this.reportViewer1.RefreshReport();
        }
    }
}
