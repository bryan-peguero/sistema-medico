using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    abstract class ClasePadre: IClase
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public abstract void Agregado();

        public abstract void Incorrecto();

    }
}
