using Microsoft.EntityFrameworkCore;

namespace Ch04EX1MovieList.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        { }

        public DbSet<Moviecs> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Moviecs>()
        .HasKey(m => m.MovieId);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "A", Name = "Action" },
                new Genre { GenreId = "C", Name = "Comdey" },
                new Genre { GenreId = "D", Name = "Drama" },
                new Genre { GenreId = "H", Name = "Horror" },
                new Genre { GenreId = "M", Name = "Musical" },
                new Genre { GenreId = "R", Name = "RomCom" },
                new Genre { GenreId = "S", Name = "SciFi" });

            modelBuilder.Entity<Moviecs>().HasData(
                new Moviecs
                {
                    MovieId = 1,
                    Name = "Casablanka",
                    Year = 1942,
                    Rating = 5,
                    GenreID = "D"
                },
                new Moviecs
                {
                    MovieId = 2,
                    Name = "Wonder Woman",
                    Year = 2017,
                    Rating = 3,
                    GenreID = "A"
                },
                new Moviecs
                {
                    MovieId = 3,
                    Name = "Moonstruck",
                    Year = 1988,
                    Rating = 4,
                    GenreID = "R"
                }
             );
        }
    }
}
