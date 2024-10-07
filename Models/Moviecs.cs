using System.ComponentModel.DataAnnotations;

namespace Ch04EX1MovieList.Models
{
    public class Moviecs
    {
        public int MovieId { get; set; }
        [Required(ErrorMessage="Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter a year.")]
        [Range(1889,2999, ErrorMessage ="Year mist be after 1889.")]
        public int? Year { get; set; }

        [Required(ErrorMessage ="Please Enter a rating.")]
        [Range(1,5, ErrorMessage ="Rating must be between 1 and 5")]
        public int? Rating { get; set; }

        [Required(ErrorMessage ="Please Enter a Genre.")]
        public string GenreID { get; set; }
        public Genre Genre { get; set; }

    }
}
