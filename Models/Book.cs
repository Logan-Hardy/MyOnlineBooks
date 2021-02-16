using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineBooks.Models
{
    public class Book
    {
        [Required]
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookTitle { get; set; }
        [Required]
        public string BookAuthor { get; set; }
        [Required]
        public string BookPublisher { get; set; }
        [Required]
        [RegularExpression("^([0-9]{3}-[0-9]{10})$", ErrorMessage = "Please enter a valid ISBN with a hyphin: XXX-XXXXXXXXXX")]
        public string BookISBN { get; set; }
        [Required]
        public string BookCategory { get; set; }
        [Required]
        public double BookPrice { get; set; }



    }
}
