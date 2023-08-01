using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFuncAction
{
    public class Ejemplo
    {
        //FUNC
        //expresion
        internal void EjemploFunc()
        {
            //expresion Lambda 
            Func<string> holaMundoExpresion =
                //parameters
                ()
                //lambda
                =>
                //delegado
                "Hola Mundo";
            Console.WriteLine(holaMundoExpresion);
            Console.WriteLine(holaMundoExpresion());

        }
        //bloque
        internal void EjemploFuncBloque()
        {
            //expresion Lambda 
            Func<string> holaMundoBloque =
                //parameters
                ()
                //lambda
                =>
                //delegado
                {
                    var cadena = "Hola Mundo";
                    return cadena;
                };
            Console.WriteLine(holaMundoBloque());
        }
        //parametros
        internal void EjemploFuncSumar()
        {
            //expresion Lambda 
            Func<int, int, int> Sumar =
                //parameters
                (a, b)
                //lambda
                =>
                //delegado
                {
                    return a + b;
                };
            Console.WriteLine(Sumar(10, 20));
        }

        //ACTION
        internal void EjemploAction()
        {
            TestAction(Accion, 1);

            TestAction((x) => Console.WriteLine($"En el metodo Accion {x}"), 1);

            Action<int> accion = (y) =>
            {
                Console.WriteLine($"En el metodo Accion {y}");
            };
            TestAction(accion, 1);
        }

        public void TestAction(Action<int> accion, int numero)
        {
            accion(numero);
        }
        public void Accion(int numero)
        {
            Console.WriteLine($"En el metodo Accion {numero}");
        }

        //    Lista de Acciones

        //    List<Action<int>> listaAcciones = new List<Action<int>>();
        //    listaAcciones.Add(accion );
        //    listaAcciones.Add(AccionMetodo );

        //    foreach (var elementoAccion in listaAcciones){
        //        elementoAccion(1);
        //}
    }
}
