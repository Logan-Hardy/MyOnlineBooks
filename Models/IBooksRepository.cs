using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Logan Hardy 
//IS 413 
//Assignment 6
//24 Feb 2021

namespace MyOnlineBooks.Models
{
    public interface IBooksRepository
    {
        //Allows user to obtain a sequence of Books objects
        IQueryable<Book> Books { get;  }
    }
}
