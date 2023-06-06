using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Inquiries
    {
        [Key]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
