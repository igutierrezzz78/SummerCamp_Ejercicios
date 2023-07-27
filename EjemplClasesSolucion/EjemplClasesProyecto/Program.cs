using Entidades;

namespace EjemplClasesProyecto
{
    //Calcular salario de empleados
    internal class Program
    {
        static void Main(string[] args)
        {
            var jose = new Empleado();
            jose.Nombre = "Jose";
            jose.FechaAlta = new DateTime(2021, 01, 10);
            jose.Salario = 20000;
            jose.Alta = true;
            jose.FijarNivel(Empleado.Nivel.excelente);
            var maria = new Empleado()
            {
                Nombre = "Maria",
                FechaAlta = new DateTime(2021, 02, 15),
                Salario = 20000,
                Alta = true
            };
            var juan = new Empleado("Juan", 20000, new DateTime(2023, 01, 15), true);


            var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            numeros.Add(9);


            var lista = new List<Empleado>();
            lista.Add(maria);
            lista.Add(jose);
            lista.Add(juan);
            lista.Add(new Empleado("iñigo", 30000, new DateTime(2023, 01, 15), true));
            
            foreach (var empleado in lista)
            {
                empleado.calcularAumentoSalario();
            }
        }
    }
}