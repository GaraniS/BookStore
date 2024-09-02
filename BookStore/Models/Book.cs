using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Book title cannot exceed 100 characters")]
        public string Title { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Author? Author { get; set; }

        public Category? Category { get; set; }
    }
}
