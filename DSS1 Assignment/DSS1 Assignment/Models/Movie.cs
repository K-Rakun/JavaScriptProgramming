namespace DSS1_Assignment.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }


        public List<MovieGenreMap> MovieGenreMap { get; set; }


    }
}
