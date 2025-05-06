namespace StarWarsExplorer.Models
{
    public class Character
    {
        public string Uid { get; set; }
        public string Name { get; set; }
        public CharacterProperties Properties { get; set; }
    }

    public class CharacterProperties
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string Gender { get; set; }
        public string BirthYear { get; set; }
        public string Homeworld { get; set; } // This is usually a URL
    }

}
