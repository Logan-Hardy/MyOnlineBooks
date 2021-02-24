using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//Logan Hardy 
//IS 413 
//Assignment 6
//24 Feb 2021

namespace MyOnlineBooks.Models
{
    public class Book
    {
        [Required]
        [Key]
        //BookId is the primary key
        public int BookId { get; set; }

        [Required]
        public string BookTitle { get; set; }
        [Required]
        public string BookAuthorFirstName { get; set; }
        //Optional 
        public string BookAuthorMiddleName { get; set; }
        [Required]
        public string BookAuthorLastName { get; set; }
        [Required]
        public string BookPublisher { get; set; }
        [Required]
        [MaxLength(14)]
        //BookISBN must be entered in the following format: XXX-XXXXXXXXXX
        [RegularExpression("^([0-9]{3}-[0-9]{10})$", ErrorMessage = "Please enter a valid ISBN with a hyphin: XXX-XXXXXXXXXX")]
        public string BookISBN { get; set; }
        [Required]
        public string BookClassification { get; set; }
        [Required]
        public string BookCategory { get; set; }
        [Required]
        public int BookNumberOfPages { get; set; }
        [Required]
        public double BookPrice { get; set; }

    }
}
