﻿namespace DSS_1_Assignment.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MovieGenreMap> MovieGenreMap { get; set; }
        

    }
}
