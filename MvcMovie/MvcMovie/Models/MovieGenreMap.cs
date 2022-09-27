namespace MvcMovie.Models
{
    public class MovieGenreMap
    {
        public Movie movie { get; set; }
        public int MovieId { get; set; }


        public Genre genre { get; set; }
        public int GenreId { get; set; }
        
    }
}
