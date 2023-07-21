using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class Externo : Empleado
    {
        private Empresa empresa;

        public Externo(string nombre, Empresa empresa) : base(nombre)
        {
            this.empresa = empresa;
        }
    }
}