namespace StarWarsExplorer.Models;

public class Species
{
    public string Uid { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public SpeciesProperties Properties { get; set; }
}

public class SpeciesProperties
{
    public string Name { get; set; }
    public string Classification { get; set; }
    public string Designation { get; set; }
    public string Language { get; set; }
}
