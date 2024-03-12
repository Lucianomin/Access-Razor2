using RazorPagesMovie.Models;
using System.ComponentModel.DataAnnotations;

namespace ACCESS_Razor.Models
{
    public class Review
    {
        public int Id { get; set; }

        public int MovieId { get; set; }
        [Required]
        [StringLength(130)]
        public string Comment { get; set; }
        [Range( 1,5)]
        public int NumStars {  get; set; }

        public virtual Movie? Movie { get; set; }
    }
}
