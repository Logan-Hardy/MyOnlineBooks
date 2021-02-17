using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineBooks.Models
{
    public class EFBooksRepository : IBooksRepository
    {
        private OnlineBooksDBContext _context;

        //Empty Constructor 
        public EFBooksRepository()
        {

        }
        //Contsructor that receives an OnlineBooksDBContext object as a parameter and sets context to the private variable
        public EFBooksRepository (OnlineBooksDBContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
