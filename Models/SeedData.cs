using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Logan Hardy 
//IS 413 
//Assignment 6
//24 Feb 2021

//file used to seed data (hard code initial values) into database
namespace MyOnlineBooks.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            OnlineBooksDBContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<OnlineBooksDBContext>();

           //run migrations if needed
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //add hardcoded entries if there isn't any contents already
            if(!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        BookTitle = "Les Miserables",
                        BookAuthorFirstName = "Victor",
                        BookAuthorLastName = "Hugo",
                        BookPublisher = "Signet",
                        BookISBN = "978-0451419439",
                        BookClassification = "Fiction",
                        BookCategory = "Classic",
                        BookNumberOfPages = 1488,
                        BookPrice = 9.95
                    },
                    new Book
                    {
                        BookTitle = "Team of Rivals",
                        BookAuthorFirstName = "Doris",
                        BookAuthorMiddleName = "Kearnes",
                        BookAuthorLastName = "Goodwin",
                        BookPublisher = "Simon & Schuster",
                        BookISBN = "978-0743270755",
                        BookClassification = "Non-Fiction",
                        BookCategory = "Biography",
                        BookNumberOfPages = 944,
                        BookPrice = 14.58
                    },
                    new Book
                    {
                        BookTitle = "The Snowball",
                        BookAuthorFirstName = "Alice",
                        BookAuthorLastName = "Schroeder",
                        BookPublisher = "Bantam",
                        BookISBN = "978-0553384611",
                        BookClassification = "Non-Fiction",
                        BookCategory = "Biography",
                        BookNumberOfPages = 832,
                        BookPrice = 21.54
                    },
                    new Book
                    {
                        BookTitle = "American Ulysses",
                        BookAuthorFirstName = "Ronald",
                        BookAuthorMiddleName = "C.",
                        BookAuthorLastName = "White",
                        BookPublisher = "Random House",
                        BookISBN = "978-0812981254",
                        BookClassification = "non-Fiction",
                        BookCategory = "Biography",
                        BookNumberOfPages = 864,
                        BookPrice = 11.61
                    },
                    new Book
                    {
                        BookTitle = "Unbroken",
                        BookAuthorFirstName = "Laura",
                        BookAuthorLastName = "HillenBrand",
                        BookPublisher = "Random House",
                        BookISBN = "978-0812974492",
                        BookClassification = "Non-Fiction",
                        BookCategory = "Historical",
                        BookNumberOfPages = 528,
                        BookPrice = 13.33
                    },
                    new Book
                    {
                        BookTitle = "The Great Train Robbery",
                        BookAuthorFirstName = "Michael",
                        BookAuthorLastName = "Crichton",
                        BookPublisher = "Vintage",
                        BookISBN = "978-0804171281",
                        BookClassification = "Fiction",
                        BookCategory = "Historical Fiction",
                        BookNumberOfPages = 288,
                        BookPrice = 15.95
                    },
                    new Book
                    {
                        BookTitle = "Deep Work",
                        BookAuthorFirstName = "Cal",
                        BookAuthorLastName = "Newport",
                        BookPublisher = "Grand Central Publishing",
                        BookISBN = "978-1455586691",
                        BookClassification = "Non-Fiction",
                        BookCategory = "Self-Help",
                        BookNumberOfPages = 304,
                        BookPrice = 14.99
                    },
                    new Book
                    {
                        BookTitle = "It's Your Ship",
                        BookAuthorFirstName = "Michael",
                        BookAuthorLastName = "Abrashoff",
                        BookPublisher = "Grand Central Publishing",
                        BookISBN = "978-1455523023",
                        BookClassification = "Non-Fiction",
                        BookCategory = "Self-Help",
                        BookNumberOfPages = 240,
                        BookPrice = 21.66
                    },
                    new Book
                    {
                        BookTitle = "The Virgin Way",
                        BookAuthorFirstName = "Richard",
                        BookAuthorLastName = "Branson",
                        BookPublisher = "Portfolio",
                        BookISBN = "978-1591847984",
                        BookClassification = "Non-Fiction",
                        BookCategory = "Business",
                        BookNumberOfPages = 400,
                        BookPrice = 29.16
                    },
                    new Book
                    {
                        BookTitle = "Sycamore Row",
                        BookAuthorFirstName = "John",
                        BookAuthorLastName = "Grisham",
                        BookPublisher = "Bantam",
                        BookISBN = "978-0553393613",
                        BookClassification = "Fiction",
                        BookCategory = "Thrillers",
                        BookNumberOfPages = 642,
                        BookPrice = 15.03
                    },
                    new Book
                    {
                        BookTitle = "The Two Towers",
                        BookAuthorFirstName = "J.",
                        BookAuthorMiddleName = "R. R.",
                        BookAuthorLastName = "Tolkein",
                        BookPublisher = "Allen & Unwin",
                        BookISBN = "978-0618002238",
                        BookClassification = "Fiction",
                        BookCategory = "Fantasy",
                        BookNumberOfPages = 352,
                        BookPrice = 5.71
                    },
                    new Book
                    {
                        BookTitle = "Chicka Chicka Boom Boom",
                        BookAuthorFirstName = "John",
                        BookAuthorLastName = "Archambault",
                        BookPublisher = "Simon & Schuster Books for Young Readers",
                        BookISBN = "978-1442438910",
                        BookClassification = "Fiction",
                        BookCategory = "Children",
                        BookNumberOfPages = 40,
                        BookPrice = 10.99
                    },
                    new Book
                    {
                        BookTitle = "The Hardy Boys: Hunting for Hidden Gold",
                        BookAuthorFirstName = "Franklin",
                        BookAuthorMiddleName = "W.",
                        BookAuthorLastName = "Dixon",
                        BookPublisher = "Gosset & Dunlap",
                        BookISBN = "978-0448089058",
                        BookClassification = "Fiction",
                        BookCategory = "Mystery",
                        BookNumberOfPages = 192,
                        BookPrice = 8.99
                    }



                 );

                //save any changes
                context.SaveChanges();
            }
        }
    }
}
