using Entidades;

namespace _06_Practica1_CreadorVehiculosProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string selection = String.Empty;

            while (selection != "S" && selection != "s")
            {
                Console.Write("Elige: \n" +
                    "           A) Crear vehículos especificando el año de compra y el color\n" +
                    "           B) Crear vehículos especificando marca y modelo\n" +
                    "           C) Crear vehículos especificando año de compra, marca, modelo y color\n" +
                    "           S --> SALIR\n");

                selection = Console.ReadLine();
                int anioCompra;
                string color = "";
                string modelo = "";
                string marca = "";

                switch (selection)
                {
                    case "a":
                    case "A":
                        Console.WriteLine("*********** CREADOR CON AÑO Y COLOR ***********");
                        Console.Write("Escriba su año de compra: ");
                        string input = Console.ReadLine();
                        try
                        {
                            anioCompra = int.Parse(input);
                            Console.Write("Escriba su color: ");
                            color = Console.ReadLine();
                            var vehiculo = new Vehiculo(anioCompra, color);
                            Console.WriteLine("*********** El vehiculo ha sido creado con exito ***********");
                            Console.WriteLine("Caracteristicas del vehiculo creado:");
                            Console.WriteLine("     Año de Compra: " + vehiculo.AnioCompra.ToString());
                            Console.WriteLine("     Color: " + vehiculo.Color.ToString());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("El valor ingresado no es un número entero válido.");
                        }
                        break;

                    case "b":
                    case "B":
                        Console.WriteLine("*********** CREADOR CON MARCA Y MODELO ***********");
                        Console.Write("Escriba su marca: ");
                        marca = Console.ReadLine();
                        Console.Write("Escriba su modelo: ");
                        modelo = Console.ReadLine();
                        var vehiculo1 = new Vehiculo(marca, modelo);
                        Console.WriteLine("El vehiculo ha sido creado con exito");
                        Console.WriteLine("*********** El vehiculo ha sido creado con exito ***********");
                        Console.WriteLine("Caracteristicas del vehiculo creado:");
                        Console.WriteLine("     Marca: " + vehiculo1.Marca.ToString());
                        Console.WriteLine("     Modelo: " + vehiculo1.Modelo.ToString());
                        break;
                    case "c":
                    case "C":
                        Console.WriteLine("*********** CREADOR COMPLETO ***********");
                        Console.Write("Escriba su año de compra: ");
                        input = Console.ReadLine();
                        try
                        {
                            anioCompra = int.Parse(input);
                            Console.Write("Escriba su color: ");
                            color = Console.ReadLine();
                            Console.Write("Escriba su marca: ");
                            marca = Console.ReadLine();
                            Console.Write("Escriba su modelo: ");
                            modelo = Console.ReadLine();
                            var vehiculo2 = new Vehiculo(anioCompra, color, marca, modelo);
                            Console.WriteLine("*********** El vehiculo ha sido creado con exito ***********");
                            Console.WriteLine("Caracteristicas del vehiculo creado:");
                            Console.WriteLine("     Año de Compra: " + vehiculo2.AnioCompra.ToString());
                            Console.WriteLine("     Color: " + vehiculo2.Color.ToString());
                            Console.WriteLine("     Marca: " + vehiculo2.Marca.ToString());
                            Console.WriteLine("     Modelo: " + vehiculo2.Modelo.ToString());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("El valor ingresado no es un número entero válido.");
                        }
                        break;

                    case "s":
                    case "S":
                        break;

                    default:
                        Console.WriteLine("Por favor, intentalo de nuevo");
                        break;
                }
            }
            
        }
    }
}