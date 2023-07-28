using System.Net.Http.Headers;

namespace EjemploEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reloj = new Reloj();
            var relojDigital = new RelojDigital();
            relojDigital.Suscribir(reloj);
            var log = new Registro();
            log.Suscribir(reloj);
            reloj.IniciaReloj();
        }
    }
}