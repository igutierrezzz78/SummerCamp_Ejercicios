namespace Entidades
{
    //public - Visible en todo el proyecto
    //private - No es visible
    //protected - 
    //internal - 
    public class Empleado
    {
        public Empleado()
        {

        }
        public Empleado(string nombre, double salario, DateTime fechaAlta, bool alta)
        {
            Nombre = nombre;
            Salario = salario;
            FechaAlta = fechaAlta;
            Alta = alta;
        }
        public string Nombre { get; set; }
        public double Salario { get; set; }
        public DateTime FechaAlta { get; set; } = DateTime.Now;
        public bool Alta { get; set; }

        public enum Nivel
        {
            normal, 
            bueno,
            excelente
        }
        private Nivel _nivel;

        public void FijarNivel(Nivel nivel)
        {
            this._nivel = nivel;
        }

        public void calcularAumentoSalario()
        {
            //throw new NotImplementedException();

        }
    }
}
