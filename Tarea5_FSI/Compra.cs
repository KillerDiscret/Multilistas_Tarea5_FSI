﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5_FSI
{
    public class Compra
    {
        public int DNI { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }

        public Compra()
        {
            Fecha = new DateTime();
        }

    }
}
