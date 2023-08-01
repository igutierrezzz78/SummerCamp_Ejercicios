using Extensiones;

namespace EjemploMetodosExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var juan = "JuAN LUis".ConvertirCadena();
            var luis = "LUIs MaRTinez".ConvertirCadena();

            Console.WriteLine(juan + " " + luis);
            //juan = Utilidades.ConvertirCadena(juan);
            //luis = Utilidades.ConvertirCadena(luis);

            //Agregar metodo de extension para comparar dos enteros

            int a = 1;
            int b = 2;

            a.EsMayorQue(b);
            if (a.EsMayorQue(b))
            {
                Console.WriteLine("Es mayor");
            }
            else
            {
                Console.WriteLine("Es menor");
            }

            var lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var primero = lista.Primero();
            Console.WriteLine(primero);
        }

        
    }
}