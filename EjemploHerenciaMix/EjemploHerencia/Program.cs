
namespace EjemploHerencia

{
    internal class Program
    {
        static void Main(string[] args)
        {

            Empleado juan = new Empleado("Juan");
            Console.WriteLine(juan.ToString());

            Administrador maria = new Administrador("Maria", true);

            juan.Jefe = maria;

            Empleado jose = new Trabajador("jose", "Tarde");
            jose.Jefe = maria;


            Empleado luis = new Externo("Luis", new Empresa { Nombre = "ACME", Telefono = "555-123123" });

            var lista = new List<Empleado>() {
                    juan,
                    jose,
                    maria,
                    new Trabajador("luis","Mañana"),
                    luis
            };


            foreach (var empleado in lista)
            {
                if (empleado.Nombre.StartsWith("J"))
                {
                    empleado.CalculoVacaciones();

                    
                }

            }

            // SELECT * FROM empleados where empleados.Nombre.StartsWith("J")

            IEnumerable<Empleado> listaEmpleadosJ = from empleado in lista
                               where empleado.Nombre.StartsWith("J")
                               orderby empleado.Nombre
                               select empleado;


            foreach (var empleado in listaEmpleadosJ)
            {
               
             
                    empleado.CalculoVacaciones();


            }



            try
            {
                if (maria.TieneParking)
                {
                    Console.WriteLine(maria.PlazaParking());
                }
            }
            catch (ErrorBaseDatos ex)
            {
                Console.WriteLine("Fecha y hora de la excepción: " + ex.FechaHora);
                Console.WriteLine("Mensaje personalizado: " + ex.MensajePersonalizado);
            }






        }
    }
}