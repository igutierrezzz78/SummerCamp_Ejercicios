using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados.Medios
{
    public class ReproductorCds
    {
        public bool ProbarCd()
        {
            Console.WriteLine("Ponga el cd en el reproductor");
            Console.WriteLine("Pulse el boton de reproduccion");
            Console.WriteLine("Indique si ha eschuchado algo S/N");

            var result = Console.ReadLine();

            return result == "S";
        }

        public string ObtenerPosterDisco(string codigo)
        {
            return "El poster esta adentro de la caratula del CD";
        }
    }
}
