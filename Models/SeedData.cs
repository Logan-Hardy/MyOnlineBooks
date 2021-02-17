using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                        BookPrice = 15.03
                    }

                 );

                //save any changes
                context.SaveChanges();
            }
        }
    }
}
