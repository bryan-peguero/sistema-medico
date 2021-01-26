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
    public partial class RAltaMédica : Form
    {
        public RAltaMédica()
        {
            InitializeComponent();
        }

        private void RAltaMédica_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SistemaMédicoDataSet.Alta_Médica' Puede moverla o quitarla según sea necesario.
            this.Alta_MédicaTableAdapter.Fill(this.SistemaMédicoDataSet.Alta_Médica);
            // TODO: esta línea de código carga datos en la tabla 'SistemaMédicoDataSet.AltaM' Puede moverla o quitarla según sea necesario.
            this.reportViewer1.RefreshReport();
        }
    }
}
