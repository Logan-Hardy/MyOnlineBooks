using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineBooks.Models
{
    public class EFBooksRepository : IBooksRepository
    {
        private OnlineBooksDBContext _context;

        //Constructor 
        public EFBooksRepository()
        {

        }
        public EFBooksRepository (OnlineBooksDBContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
