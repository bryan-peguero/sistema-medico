using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    class CPacientes : ClasePadre
    {
        public long Cedula { get; set; }
        public string Asegurado { get; set; }
        public override void Agregado()
        {
            MessageBox.Show("Se ha completado correctamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public override void Incorrecto()
        {
            MessageBox.Show("Campo(s) sin completar, por favor intentarlo nuevamente.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
    }
}
