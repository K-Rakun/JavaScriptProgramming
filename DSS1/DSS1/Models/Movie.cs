namespace DSS1.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ReleaseDateId { get; set; }
        public ReleaseDate ReleaseDate { get; set; }
        public List<MovieGenreMap> MovieGenreMap { get; set; }
    }
}
