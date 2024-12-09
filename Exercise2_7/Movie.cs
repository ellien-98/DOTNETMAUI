namespace Exercise2_7
{
    public class Movie : IMovie
    {
        public string Name { set; get; }
        public double Rating { set; get; }
        //public List<Movie> MList; // to be deleted
        
        public List<Movie> CreateMovieList()
        {
            return new List<Movie>() // or return MList ??
            {
                new Movie()
                {
                    Name = "The Shawshank Redemption",
                    Rating = 9.2
                },
                new Movie()
                {
                    Name = "The Godfather",
                    Rating = 9.2
                },
                new Movie()
                {
                    Name = "The Dark Knight",
                    Rating = 9.0
                },
                new Movie()
                {
                    Name = "The Godfather Part II",
                    Rating = 9.0
                },
                new Movie()
                {
                    Name = "12 Angry Men",
                    Rating = 9.0
                },
                new Movie()
                {
                    Name = "The Lord of the Rings: The Return of the King",
                    Rating = 9.0
                },
                new Movie()
                {
                    Name = "Schindler's List",
                    Rating = 9.0
                },
                new Movie()
                {
                    Name = "Pulp Fiction",
                    Rating = 8.9
                },
                new Movie()
                {
                    Name = "The Lord of the Rings: The Fellowship of the Ring",
                    Rating = 8.9
                },
                new Movie()
                {
                    Name = "The Good, the Bad and the Ugly",
                    Rating = 8.8
                }
            };
        }
    }
}
