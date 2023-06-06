using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Project.Models
{
    public class Product
    {
        [Key]
        [Required]
        public string title { get; set; }
        [Required]
        public double price { get; set; }
        public string img { get; set; }
    }
}
