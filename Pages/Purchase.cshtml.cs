using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyOnlineBooks.Infrastructure;
using MyOnlineBooks.Models;

namespace MyOnlineBooks.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBooksRepository repository;

        //Constructor 
        public PurchaseModel(IBooksRepository repo, Cart cartServices)
        {
            repository = repo;
            Cart = cartServices;
        }

        //Properties
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        //Methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";

        }

        //Add book to cart
        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(b => b.BookId == bookId);

            //add selected book to cart
            Cart.AddItem(book, 1);


            return RedirectToPage(new { returnUrl = returnUrl });
        }

        //Remove book from cart
        public IActionResult OnPostRemove(long bookid, string returnUrl)
        {
            //remove selected book info from cart 
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Book.BookId == bookid).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
