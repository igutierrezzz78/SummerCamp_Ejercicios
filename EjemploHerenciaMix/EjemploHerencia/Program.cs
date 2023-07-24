
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
            Empleado luisNull = new Externo("Luis", null);

            var lista = new List<Empleado>() {
                    juan,
                    jose,
                    maria,
                    new Trabajador("luis","Mañana"),
                    luis,
                    luisNull
            };


            foreach (var empleado in lista)
            {
                var tipo = empleado.GetType().Name;

                switch (tipo)
                {
                    case "Trabajador":
                        var trabajador = (Trabajador)empleado;
                        Console.WriteLine(trabajador.Turno);
                        break;
                    case "Administrador":
                        //TODO: Mostrar plaza de parking
                        var administrador = (Administrador)empleado;

                        try
                        {
                            if (administrador.TieneParking)
                            {
                                Console.WriteLine(administrador.PlazaParking());
                            }
                        }
                        catch (ErrorBaseDatos ex)
                        {
                            Console.WriteLine("Fecha y hora de la excepción: " + ex.FechaHora);
                            Console.WriteLine("Mensaje personalizado: " + ex.MensajePersonalizado);
                        }

                        break;
                    case "Externo":
                        //TODO: Mostrar nombre de empresa
                        var externo = (Externo)empleado;
                        Console.WriteLine(externo.empresa?.Nombre);
                        break;

                }
            }

            // SELECT * FROM empleados where empleados.Nombre.StartsWith("J")

            IEnumerable<Empleado> listaEmpleadosJ = from empleadoConsulta in lista
                               where empleadoConsulta.Nombre.StartsWith("J")
                               orderby empleadoConsulta.Nombre
                               select empleadoConsulta;


            foreach (var empleadoJ in listaEmpleadosJ)
            {
               
             
                    empleadoJ.CalculoVacaciones();

                var tipoJ = empleadoJ.GetType().Name;

                switch (tipoJ)
                {
                    case "Trabajador":
                        var trabajador = (Trabajador)empleadoJ;
                        Console.WriteLine(trabajador.Turno);
                        break;
                    case "Administrador":
                        //TODO: Mostrar plaza de parking
                        var administrador = (Administrador)empleadoJ;

                        try
                        {
                            if (administrador.TieneParking)
                            {
                                Console.WriteLine(administrador.PlazaParking());
                            }
                        }
                        catch (ErrorBaseDatos ex)
                        {
                            Console.WriteLine("Fecha y hora de la excepción: " + ex.FechaHora);
                            Console.WriteLine("Mensaje personalizado: " + ex.MensajePersonalizado);
                        }

                        break;
                    case "Externo":
                        //TODO: Mostrar nombre de empresa
                        var externo = (Externo)empleadoJ;
                        Console.WriteLine(externo.empresa?.Nombre);
                        break;
                }


            }



            






        }
    }
}