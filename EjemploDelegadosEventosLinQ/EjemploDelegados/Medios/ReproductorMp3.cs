using EjemploDelegados.Medios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados
{
    public class ReproductorMp3
    {
        public ReproductorMp3() { }

        public bool ProbarMp3()
        {
            Console.WriteLine("Por favor, busque la cancion en el buscador");
            Console.WriteLine("Pulse el boton de reproduccion");
            Console.WriteLine("Indique si ha eschuchado algo S/N");


            var result = Console.ReadLine();
            return result == "S";
        }

        public string ObtenerCantantesMp3(string codigo)
        {
            return "Lista de cantantes visible al pulsar en 'Mas Información'";
        }
    }
}
