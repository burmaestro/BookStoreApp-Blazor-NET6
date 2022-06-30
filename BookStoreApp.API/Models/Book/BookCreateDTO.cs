using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.Book
{
    public class BookCreateDTO
    {
        [Required]
        public int AuthorId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [Range(1800, int.MaxValue)]
        public int Year { get; set; }

        [Required]
        public string Isbn { get; set; }

        [Required]
        [StringLength(250), MinLength(10)]
        public string Summmary { get; set; }

        public string? ImageData { get; set; }
        public string? OriginalImageName { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }
    }
}
