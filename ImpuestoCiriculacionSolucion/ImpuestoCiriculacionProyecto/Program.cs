namespace ImpuestoCiriculacionProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Coche1 =  new Vehiculo(DateTime.Now.Year,"Coche1",2000);
            Coche1.FijarEtiqueta(Vehiculo.Etiqueta.cero);
            var Coche2 = new Vehiculo(new DateTime(2000,01,10).Year, "Coche2", 1000);
            Coche2.FijarEtiqueta(Vehiculo.Etiqueta.b);
            var Coche3 = new Vehiculo(new DateTime(2010, 03, 04).Year, "Coche3", 1000);
            Coche3.FijarEtiqueta(Vehiculo.Etiqueta.c);
            var Coche4 = new Vehiculo(new DateTime(1995, 01, 10).Year, "Coche4", 1000);
            Coche4.FijarEtiqueta(Vehiculo.Etiqueta.sin);
            var Coche5 = new Vehiculo(new DateTime(2015, 08, 15).Year, "Coche5", 1000);
            Coche5.FijarEtiqueta(Vehiculo.Etiqueta.eco);

            var coches =  new List<Vehiculo>();
            coches.Add(Coche1);
            coches.Add(Coche2);
            coches.Add(Coche3);
            coches.Add(Coche4);
            coches.Add(Coche5);

            foreach (var coche in coches)
            {
                double IC = coche.CalcularIC(coche);
                Console.WriteLine(coche.Marca + " del año "+coche.AnioMatriculacion+" tiene el impuesto de ciculacion de " + IC + " euros");
            }
        }
    }
}