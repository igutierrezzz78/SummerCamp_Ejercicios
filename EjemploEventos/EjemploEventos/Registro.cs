namespace EjemploEventos
{
    internal class Registro
    {
        
        public Registro()
        {
            fechaInicio = DateTime.Now;
        }

        public DateTime fechaInicio { get; set; }

        internal void Suscribir(Reloj reloj)
        {
            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento;
        }

        private void Reloj_CambioSegundoEvento(object reloj, InformacionTiempoEventArgs e)
        {
            
            TimeSpan diferencia = DateTime.Now - fechaInicio;
            int segundosDiferencia = (int)diferencia.TotalSeconds;
            if(segundosDiferencia >= 10)
            {
                Console.WriteLine($"Hora Actual GUARDADA:  {e.Hora.ToString()}" + $" :{e.Minuto.ToString()} " + $" :{e.Segundo.ToString()}");
                fechaInicio = DateTime.Now;
            }
        }
    }
}