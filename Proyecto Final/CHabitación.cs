using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    class CHabitación : ClasePadre
    {
        public int Precio { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
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
