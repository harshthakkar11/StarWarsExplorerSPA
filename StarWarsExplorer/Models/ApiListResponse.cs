namespace StarWarsExplorer.Models
{
    public class ApiListResponse<T>
    {
        public List<T> Results { get; set; }
    }
    public class ApiItemResponse<T>
    {
        public T Result { get; set; }
    }

}
