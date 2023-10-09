namespace Dump_Catastro_CORE.Entities
{
    public class GeoJsonPolygon
    {
        public string Type { get; set; }
        public List<List<List<List<double>>>> Coordinates { get; set; }
    }
}
