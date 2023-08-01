namespace EjemLinQ
{
    public class EjemploOperador1
    {
        public EjemploOperador1()
        {
        }
        public void Ejecutar()
        {
            // Lista de empleados
            IEnumerable<Empleado> Empleados = new List<Empleado>()
         {

             new Empleado
             {
                 Nombre = "Jose",
                 Apellidos = "Hernandez",
                 Ciudad = "Madrid",
                 Telefono = "123456789",
                 Departamento = Departamento.Soporte
             },
             new Empleado
             {
                 Nombre = "Luis",
                 Apellidos = "Conde",
                 Ciudad = "Madrid",
                 Telefono = "423456789",
                 Departamento = Departamento.Desarrollo
             },
             new Empleado
             {
                 Nombre = "Juan",
                 Apellidos = "Nuñez",
                 Ciudad = "Barcelona",
                 Telefono = "9123456789",
                 Departamento = Departamento.Admin
             },
             new Empleado
             {
                 Nombre = "Maria",
                 Apellidos = "Castillo",
                 Ciudad = "Valencia",
                 Telefono = "8123456789",
                 Departamento = Departamento.RH
             }
          };

            List<Empleado> empladosDesarolloSoporte = Empleados
                                           .Where(empleado =>
                                                        (empleado.Departamento == Departamento.Soporte ||
                                                        empleado.Departamento == Departamento.Desarrollo) 
                                                        &&
                                                        empleado.Apellidos.StartsWith("C")
                                                  )
                                           .OrderByDescending(empleado => empleado.Nombre)
                                           .Select(empleado => empleado)
                                           .ToList();

            List<Empleado> empleadosDesarolloSoporteConsulta = (from empleado in Empleados
                                                    where (empleado.Departamento == Departamento.Soporte ||
                                                        empleado.Departamento == Departamento.Desarrollo)
                                                        &&
                                                        empleado.Apellidos.StartsWith("C")
                                                    orderby empleado.Nombre descending
                                                    select empleado).ToList();

            List<string> empleadosMadridApellidoA = (from empleado in Empleados
                                                                where empleado.Ciudad == "Madrid"
                                                                      &&
                                                                      empleado.Apellidos.Contains("a")
                                                                orderby empleado.Nombre descending
                                                                select empleado.Telefono ).ToList();

            var empleadosMadridApellidoA2 = (from empleado in Empleados
                                                     where empleado.Ciudad == "Madrid"
                                                           &&
                                                           empleado.Apellidos.Contains("a")
                                                     orderby empleado.Nombre descending
                                                     select new { Telefono = empleado.Telefono,
                                                                  Ciudad = empleado.Ciudad}).ToList();

            foreach (var resultado in empleadosMadridApellidoA2)
            {
                Console.WriteLine(resultado.Ciudad);
            }


            var empleadosNuevos = new List<Empleado>            {                new Empleado                {                    Nombre = "Fabricio",                    Apellidos = "Cordero",                    Departamento = Departamento.Desarrollo                },                new Empleado                {                    Nombre = "Julia",                    Apellidos = "Lombardo",                    Departamento = Departamento.Admin                },            };

            List<Empleado> empladosAntiguos = Empleados
                                           .Select(empleado => empleado)
                                           .ToList();
            empladosAntiguos.AddRange(empleadosNuevos);


        }
    }
}