
namespace EjemploHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var juan = new Empleado("Juan");

            Administrador maria = new Administrador("Maria",33);
            Administrador mariaSinPlaza = new Administrador("Maria Sinplaza",null);


            Trabajador jose = new Trabajador("Jose","mañana");
            Externo jimmy = new Externo("Jimmy","BCS","780-324-234");
            var lista =  new List<Empleado>();

            lista.Add(juan);
            lista.Add(jose);
            lista.Add(maria);
            lista.Add(jimmy);
            lista.Add(mariaSinPlaza);
            Console.WriteLine("******************************\n" +
                "******** TRABAJADORES ********\n" +
                "******************************\n");
            foreach (Empleado empleado in lista)
            {     
                Console.WriteLine(empleado.ToString());
            }

            //SELECT * FORM empleados WHERE empleados.Nombre.StartsWith("J")

            IOrderedEnumerable<Empleado> listaEmpleadosJ = from empleado in lista
                                  where empleado.Nombre.StartsWith("J")
                                  orderby empleado.Nombre
                                  select empleado;


            Console.WriteLine("****** Nombres que empiezan con 'J': ******");
            foreach (Empleado empleado1 in listaEmpleadosJ)
            {
                Console.WriteLine(empleado1.ToString());
            }
        }
    }
}