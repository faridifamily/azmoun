using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using teeeest.DAL;
using teeeest.Models;

namespace teeeest.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Book book)
        {
            var lastBookId = BookRepo.List().Last().Id;
            book.Id = lastBookId+1;
            BookRepo.Add(book);
            return View();
        }
    }
}
