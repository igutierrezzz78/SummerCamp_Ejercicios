using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extensiones
{
    public static class Utilidades
    {
        public static string ConvertirCadena(this string cadena)
        {
            return cadena.Trim().ToUpper() + ".";
        }
        public static bool EsMayorQue(this int numero1, int numero2)
        {
            return numero1 > numero2;
        }
        public static int Primero(this List<int> lista)
        {
            #region TIPICA
            var primero = int.MinValue;
            foreach (var item in lista)
            {
                if (item > primero)
                {
                    primero = item;
                }
            }
            return primero;
            #endregion
        }
    }
}
