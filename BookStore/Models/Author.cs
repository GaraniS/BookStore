using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Author name cannot exceed 100 characters")]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Email not valid")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
        public string Email { get; set; }
        [Required]
        [Phone(ErrorMessage = "Phone number not valid")]
        [StringLength(15, ErrorMessage = "Phone number cannot exceed 15 characters")]
        public string PhoneNumber { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
