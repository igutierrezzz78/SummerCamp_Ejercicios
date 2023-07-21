using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre, int? plazaParking) : base(nombre)
        {
            PlazaParking = plazaParking;
        }

        public int? PlazaParking { get; set; }

        public override void CalculoVacaciones()
        {
            diasVacaciones += 9;
        }
        public override string ToString()
        {
            string plaza = (PlazaParking != null) ? "\n     Plaza de parking numero " + PlazaParking : "";
            string mensaje = "  Administrativo: \n" + base.ToString() + plaza;

            return mensaje;
        }
    }
}