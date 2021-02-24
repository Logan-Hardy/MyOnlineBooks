using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyOnlineBooks.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MyOnlineBooks.Models.ViewModels;

//Logan Hardy 
//IS 413 
//Assignment 6
//24 Feb 2021

namespace MyOnlineBooks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBooksRepository _repository;
        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, IBooksRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(int page = 1)
        {
            //Get everything within the return (could also be done beforehand)
            return View(new BookListViewModel
            {
                //get book information, order by Book Price
                Books = _repository.Books
                    .OrderBy(b => b.BookPrice)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)
                    ,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = _repository.Books.Count()
                }
            });
                
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AddBook()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
