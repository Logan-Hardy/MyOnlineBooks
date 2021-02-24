using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Logan Hardy 
//IS 413 
//Assignment 6
//24 Feb 2021

//Primary file to handle interaction with database


namespace MyOnlineBooks.Models
{
    public class OnlineBooksDBContext : DbContext
    {
        //Constructor
        public OnlineBooksDBContext (DbContextOptions<OnlineBooksDBContext> options) : base (options)
        {

        }

        //Pull data from database
        public DbSet<Book> Books { get; set; }

    }
}
