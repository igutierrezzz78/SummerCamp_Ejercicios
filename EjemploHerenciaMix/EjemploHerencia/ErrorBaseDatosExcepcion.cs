using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    public class ErrorBaseDatos : Exception
    {
        public DateTime FechaHora { get; }
        public string MensajePersonalizado { get; }
        public DateTime Fecha { get; }

        public ErrorBaseDatos(string mensaje, DateTime fecha) : base(mensaje)
        {
            FechaHora = fecha;
            MensajePersonalizado = mensaje;
        }
    }
}
