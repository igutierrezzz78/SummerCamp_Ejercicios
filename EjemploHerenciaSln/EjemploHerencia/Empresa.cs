using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class Empresa
    {
        public Empresa() { }
        public Empresa(string nombre, string numero) {
            Nombre = nombre;
            Numero = numero;
        }

        public string Nombre { get; set;}
        public string Numero { get; set;}
    }
}