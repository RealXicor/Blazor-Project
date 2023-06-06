using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class ContactForm
    {
        [Required]
        public string name { get; set; }
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Subject can not exceed 50 characters.")]
        public string subject { get; set; }
        [Required]
        [StringLength(700, ErrorMessage = "Word Limit Exceeded! (700 Characters at MAX)")]
        public string message { get; set; }
    }
}
