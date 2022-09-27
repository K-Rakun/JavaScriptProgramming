namespace AssignmentDSS1.Models
{
    public class MovieGenreMap
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie movie { get; set; }
        public int GenreId { get; set; }
        public Genre genre { get; set; }
    }
}
