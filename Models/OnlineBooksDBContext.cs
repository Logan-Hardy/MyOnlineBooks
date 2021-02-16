using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineBooks.Models
{
    public class OnlineBooksDBContext : DbContext
    {
        //Constructor
        public OnlineBooksDBContext (DbContextOptions<OnlineBooksDBContext> options) : base (options)
        {

        }

        public DbSet<Book> Books { get; set; }

    }
}
