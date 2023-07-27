using EjemploDelegados.Medios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados
{
    public class InventarioMedios
    {
        public delegate bool ProbarMediosDelegado();

        public delegate string InfoMediosDelegado(string id);

        public void ResultadoProbarMedios(ProbarMediosDelegado probarMediosDelegado)
        {
            var resultadoPrueba = probarMediosDelegado();
            if (resultadoPrueba)
            {
                Console.WriteLine("El medio funciona, " + " hay que agregarlo al inventario");
            }
            else
            {
                Console.WriteLine("El medio no funciona, destruidlo");
            }
        }

        public void ResultadoInfoMedios(InfoMediosDelegado infoMediosDelegado, string codigo)
        {
            var resultadoInfo = infoMediosDelegado(codigo);
            if (resultadoInfo != null)
            {
                Console.WriteLine(resultadoInfo);
            }
            else
            {
                Console.WriteLine("No hay contenido");
            }
        }
    }


}
