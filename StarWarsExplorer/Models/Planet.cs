namespace StarWarsExplorer.Models
{
    public class Planet
    {
        public string Uid { get; set; }
        public string Name { get; set; }
        public PlanetProperties Properties { get; set; }
    }

    public class PlanetProperties
    {
        public string Name { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Terrain { get; set; }
        public string Population { get; set; }
    }

}
