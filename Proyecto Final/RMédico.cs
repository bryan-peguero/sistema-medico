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
    public partial class RMédico : Form
    {
        public RMédico()
        {
            InitializeComponent();
        }

        private void RMédico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetMédico.Médicos' Puede moverla o quitarla según sea necesario.
            this.MédicosTableAdapter.Fill(this.DataSetMédico.Médicos);

            this.reportViewer1.RefreshReport();
        }
    }
}
