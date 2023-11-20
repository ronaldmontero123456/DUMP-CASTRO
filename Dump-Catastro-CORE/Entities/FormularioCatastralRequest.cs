
namespace Dump_Catastro_CORE.Entities
{
    public class FormularioCatastralRequest
    {
       public Catastral[] FormularioCatastral { get; set; }
    }

    public class Catastral
    {
        public string antiguedad { get; set; }
        public Caractedificacion[] caractEdificacion { get; set; }
        public string codigo { get; set; }
        public Edificacionesepesciales edificacionesEpesciales { get; set; }
        public string estadoConservacion { get; set; }

        public object[] imagen { get; set; }
        public Mejoras mejoras { get; set; }
        public string numBloque { get; set; }
        public int numConstruccion { get; set; }
        public int numPlanta { get; set; }
        public string tipoConstruccion { get; set; }
    }

    public class Edificacionesepesciales
    {
        public int centroComunitario { get; set; }
        public int centroEducativo { get; set; }
        public int cine { get; set; }
        public int clubDeportivo { get; set; }
        public int clubSocial { get; set; }
        public int comercio { get; set; }
        public int galeriaCubierta { get; set; }
        public int garageColectivo { get; set; }
        public int gasolineria { get; set; }
        public int hospital { get; set; }
        public int hotel { get; set; }
        public int industrial { get; set; }
        public int restaurante { get; set; }
        public int supermercado { get; set; }
        public int templo { get; set; }
    }

    public class Mejoras
    {
        public int areaDeportiva { get; set; }
        public int garage { get; set; }
        public int muroperimetral { get; set; }
        public int parrillero { get; set; }
        public int piscina { get; set; }
    }

    public class Caractedificacion
    {
        public string acabadoPiso { get; set; }
        public string carpienteriaVentanPuerta { get; set; }
        public string cimiento { get; set; }
        public string cubiertaTecho { get; set; }
        public string estructura { get; set; }
        public string muroTabiques { get; set; }
        public string revestimientoMuroExt { get; set; }
        public string revestimientoMuroInt { get; set; }
    }

}
