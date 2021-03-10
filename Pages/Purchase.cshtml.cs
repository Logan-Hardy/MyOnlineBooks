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
        public PurchaseModel (IBooksRepository repo, Cart cartServices)
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
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(b => b.BookId == bookId);

            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(book, 1);
            //HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookid, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Book.BookId == bookid).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
