using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemLinQ
{
    public class EjemploBasico
    {
        public void Ejecutar()
        {
            string[] niveles = { "Basico", "Intermedio", "Avanzado" };
            int nc = niveles.Count();

            // Sintaxis C#
            var listaConsultaForeach = new List<string>();
            foreach (var nivel in niveles)
            {
                if (nivel.Length > 6)
                {
                    listaConsultaForeach.Add(nivel);
                }
            }

            // Sintaxis SQL
            var consultaLinq = from nivel in niveles where nivel.Length > 6 orderby nivel select nivel;

            List<string> listaResultados = consultaLinq.ToList();

            // Sintaxis de Metodos
            var consultaLinqMetodos = niveles.Where(nivel => nivel.Length > 6)
                                             .OrderBy(nivel => nivel)
                                             .Select(nivel => nivel);
            List<string> listaResultadosMetodos = consultaLinqMetodos.ToList();
        }
    }
    
}
