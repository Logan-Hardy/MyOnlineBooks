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
                        BookAuthor = "Victor Hugo",
                        BookPublisher = "Signet",
                        BookISBN = "978-0451419439",
                        BookCategory = "Fiction, Classic",
                        BookPrice = 9.95
                    },
                    new Book
                    {
                        BookTitle = "Team of Rivals",
                        BookAuthor = "Doris Kearns Goodwin",
                        BookPublisher = "Simon & Schuster",
                        BookISBN = "978-0743270755",
                        BookCategory = "Non-Fiction, Biography",
                        BookPrice = 14.58
                    },
                    new Book
                    {
                        BookTitle = "The Snowball",
                        BookAuthor = "Alice Schroeder",
                        BookPublisher = "Bantam",
                        BookISBN = "978-0553384611",
                        BookCategory = "Non-Fiction, Biography",
                        BookPrice = 21.54
                    },
                    new Book
                    {
                        BookTitle = "American Ulysses",
                        BookAuthor = "Ronald C. White",
                        BookPublisher = "Random House",
                        BookISBN = "978-0812981254",
                        BookCategory = "Non-Fiction, Biography",
                        BookPrice = 11.61
                    },
                    new Book
                    {
                        BookTitle = "Unbroken",
                        BookAuthor = "Laura HillenBrand",
                        BookPublisher = "Random House",
                        BookISBN = "978-0812974492",
                        BookCategory = "Non-Fiction, Historical",
                        BookPrice = 13.33
                    },
                    new Book
                    {
                        BookTitle = "The Great Train Robbery",
                        BookAuthor = "Michael Crichton",
                        BookPublisher = "Vintage",
                        BookISBN = "978-0804171281",
                        BookCategory = "Fiction, Historical Fiction",
                        BookPrice = 15.95
                    },
                    new Book
                    {
                        BookTitle = "Deep Work",
                        BookAuthor = "Cal Newport",
                        BookPublisher = "Grand Central Publishing",
                        BookISBN = "978-1455586691",
                        BookCategory = "Non-Fiction, Self-Help",
                        BookPrice = 14.99
                    },
                    new Book
                    {
                        BookTitle = "It's Your Ship",
                        BookAuthor = "Michael Abrashoff",
                        BookPublisher = "Grand Central Publishing",
                        BookISBN = "978-1455523023",
                        BookCategory = "Non-Fiction, Self-Help",
                        BookPrice = 21.66
                    },
                    new Book
                    {
                        BookTitle = "The Virgin Way",
                        BookAuthor = "Richard Branson",
                        BookPublisher = "Portfolio",
                        BookISBN = "978-1591847984",
                        BookCategory = "Non-Fiction, Business",
                        BookPrice = 29.16
                    },
                    new Book
                    {
                        BookTitle = "Sycamore Row",
                        BookAuthor = "John Grisham",
                        BookPublisher = "Bantam",
                        BookISBN = "978-0553393613",
                        BookCategory = "Fiction, Thrillers",
                        BookPrice = 15.03
                    }

                 );

                context.SaveChanges();
            }
        }
    }
}
