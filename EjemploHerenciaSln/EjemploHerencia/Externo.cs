using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class Externo : Empleado
    {
        public Externo(string nombre,string nombreEmpresa, string numeroEmpresa) : base(nombre)
        {
            Nombre = nombre;
            Empresa empresa = new Empresa(nombreEmpresa,numeroEmpresa);
            NombreEmpresa = nombreEmpresa;
            NumeroEmpresa = numeroEmpresa;
        }
        public override void CalculoVacaciones()
        {
            base.CalculoVacaciones();
            diasVacaciones += 5;
        }
        public string Empresa { get; set; }
        public string NombreEmpresa { get; }
        public string NumeroEmpresa { get; }

        public override string ToString()
        {

            string mensaje = "  Externo: \n" + base.ToString() +"\n     Empresa : " + 
                NombreEmpresa + " ("+NumeroEmpresa+")";

            return mensaje;
        }
    }
}