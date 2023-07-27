using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Historico
    {
        public int MonedaOrigenId { get; set; }
        public int MonedaDestinoId { get; set; }
        public double Factor { get; set; }
        public double Cantidad { get; set; }
        public double Resultado { get; set; }
        public DateTime FechaConversion { get; set; }

        public int UsuarioId { get; set; }


    }
}