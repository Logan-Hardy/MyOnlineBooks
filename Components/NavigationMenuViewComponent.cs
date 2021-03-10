using Microsoft.AspNetCore.Mvc;
using MyOnlineBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineBooks.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBooksRepository repository;

        public NavigationMenuViewComponent (IBooksRepository r)
        {
            repository = r;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.Selectedcategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.BookCategory)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
