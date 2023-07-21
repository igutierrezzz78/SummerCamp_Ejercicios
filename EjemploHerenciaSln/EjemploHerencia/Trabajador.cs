using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class Trabajador : Empleado
    {
        public Trabajador(string nombre, string turno) : base(nombre)
        {
            Turno = turno;
        }

        public string Turno { get; set; }

        public override void CalculoVacaciones()
        {
            base.CalculoVacaciones();
            diasVacaciones += 15;
        }
        public override string ToString()
        {
            string mensaje = "  Trabajador: \n" + base.ToString() + "\n     Turno: " + Turno;

            return mensaje;
        }
    }
}