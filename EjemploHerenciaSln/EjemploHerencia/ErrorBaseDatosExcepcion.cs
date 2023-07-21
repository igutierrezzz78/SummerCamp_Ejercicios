using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    public class ErrorBaseDatosExcepcion : Exception
    {
        public ErrorBaseDatosExcepcion(string mensaje, DateTime fechaHoraExcepcion)  : base(mensaje)
        {
            FechaHoraExcepcion = fechaHoraExcepcion;
        }

        public DateTime FechaHoraExcepcion { get; set; }
    }
}
