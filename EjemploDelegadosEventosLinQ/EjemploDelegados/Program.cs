using EjemploDelegados.Medios;
using static EjemploDelegados.InventarioMedios;

namespace EjemploDelegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inventarioMedios = new InventarioMedios();
            
            var reproductorCds = new ReproductorCds();
            var tocadiscos = new Tocadiscos();
            var reproductorMp3 = new ReproductorMp3();

            ProbarMediosDelegado probarDiscosDelegado = 
                new ProbarMediosDelegado(tocadiscos.ProbarVinilo);
            InfoMediosDelegado infoDiscosDelegado =
                        new InfoMediosDelegado(tocadiscos.ObtenerCancionesDisco);
            ProbarMediosDelegado probarCdsDelegado = 
                new ProbarMediosDelegado(reproductorCds.ProbarCd);
            ProbarMediosDelegado probarMp3Delegado = 
                new ProbarMediosDelegado(reproductorMp3.ProbarMp3);


            inventarioMedios.ResultadoProbarMedios(probarDiscosDelegado);
            inventarioMedios.ResultadoInfoMedios(infoDiscosDelegado,"sad");
        }
    }
}