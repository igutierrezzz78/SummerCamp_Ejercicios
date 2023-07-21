using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre, bool tieneParking) : base(nombre)
        {
            TieneParking = tieneParking;
        }

        public bool TieneParking { get;  set; }


        public string PlazaParking()
        {
            throw new ErrorBaseDatos("Error al contectar a BBDD", DateTime.Now);
            return TieneParking ? "Plaza A-1" : "No tiene plaza";
        }

        public override void CalculoVacaciones()
        {
            diasVacaciones += 9;
        }
    }
}