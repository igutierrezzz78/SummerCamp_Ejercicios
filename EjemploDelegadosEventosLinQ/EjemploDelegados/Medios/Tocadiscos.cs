using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados.Medios
{
    public class Tocadiscos
    {
        public Tocadiscos() { }

        public bool ProbarVinilo()
        {
            Console.WriteLine("Por favor, inserte el disco y ponga la guja en posicion");
            Console.WriteLine("Pulse el boton de reproduccion");
            Console.WriteLine("Indique si ha eschuchado algo S/N");

            var result = Console.ReadLine();
            return result == "S";
        }

        public string ObtenerCancionesDisco(string codigo)
        {
            return "Lista de canciones estan en la contraportada";
        }
    }
}
