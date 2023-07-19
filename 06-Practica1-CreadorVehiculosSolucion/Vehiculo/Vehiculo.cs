namespace Entidades
{
    public class Vehiculo
    {
        public Vehiculo()
        {

        }
        public Vehiculo(int anioCompra, string color)
        {
            AnioCompra = anioCompra;
            Color = color;
        }
        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public Vehiculo(int anioCompra, string marca, string modelo, string color)
        {
            AnioCompra = anioCompra;
            Marca = marca;
            Modelo = modelo;
            Color = color;
        }
        public int AnioCompra { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        
    }
}