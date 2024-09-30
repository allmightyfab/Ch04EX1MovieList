using Microsoft.EntityFrameworkCore;

namespace Ch04EX1MovieList.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        { }

        public DbSet<Moviecs> Movies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Moviecs>().HasData(
                new Moviecs
                {
                    MovieId = 1,
                    Name = "Casablanka",
                    Year = 1942,
                    Rating = 5
                },
                new Moviecs
                {
                    MovieId = 2,
                    Name = "Wonder Woman",
                    Year = 2017,
                    Rating = 3
                },
                new Moviecs
                {
                    MovieId = 3,
                    Name = "Moonstruck",
                    Year = 1988,
                    Rating = 4
                }
             );
        }
    }
}
