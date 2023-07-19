

using System.Drawing;

namespace ImpuestoCiriculacionProyecto
{
    public class Vehiculo
    {
        public Vehiculo()
        {

        }
        public Vehiculo(int anioMatriculacion, string marca, int valorBase)
        {
            AnioMatriculacion = anioMatriculacion;
            Marca = marca;
            ValorBase = valorBase;
        }

        public int AnioMatriculacion { get; set; }
        public string Marca { get; set; }
        public int ValorBase { get; set; }
        public enum Etiqueta
        {
            sin,
            b,
            c,
            eco,
            cero
        }
        private Etiqueta _etiqueta;

        public void FijarEtiqueta(Etiqueta etiqueta)
        {
            this._etiqueta = etiqueta;
        }

        public double CalcularIC(Vehiculo coche)
        {
            double IC;
            int anioActual = 2023;
            double porcentaje = 0;
            int valorBase = coche.ValorBase;
            int anio = coche.AnioMatriculacion;
            porcentaje += anioActual - anio;
            switch (coche._etiqueta)
            {
                case Etiqueta.sin:
                    porcentaje += 25;
                    break;
                case Etiqueta.b:
                    porcentaje += 15;
                    break;
                case Etiqueta.c:
                    porcentaje += 10;
                    break;
                case Etiqueta.eco:
                    porcentaje += 5;
                    break;
                default:
                    porcentaje += 0;
                    break;
            }
            double porcentajeDecimal = porcentaje / 100;
            IC = valorBase * porcentajeDecimal; 
            return IC;
        }
    }
}
