
namespace EjemploHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var juan = new Empleado("Juan");

            Administrador maria = new Administrador("Maria");

            Trabajador jose = new Trabajador("Jose");
            var lista =  new List<Empleado>();

            lista.Add(juan);
            lista.Add(jose);
            lista.Add(maria);
            Console.WriteLine("******************************\n" +
                "******** TRABAJADORES ********\n" +
                "******************************\n");
            foreach (Empleado empleado in lista)
            {
                Console.WriteLine(empleado.ToString());
            }
        }
    }
}