using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5_FSI
{
    public class Caja
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public List<Compra> Compras { get; set; }
        public Caja()
        {
            Compras = new List<Compra>();
        }
    }
}
