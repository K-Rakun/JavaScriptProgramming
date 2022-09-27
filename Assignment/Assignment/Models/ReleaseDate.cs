namespace Assignment.Models
{
    public class ReleaseDate
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
