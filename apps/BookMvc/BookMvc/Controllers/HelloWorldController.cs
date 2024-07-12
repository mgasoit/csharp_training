using Microsoft.AspNetCore.Mvc;
using BookMvc.Models;

namespace BookMvc.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "This is my hello world default page.";
        //}

        public string Welcome()
        {
            return "This is my welcome page.";
        }

        public IActionResult Books()
        {

            IList<Book> bookList = new List<Book>();
            bookList.Add(new Book() { Id = 1, Author = "John", Title="C# ASP.NET Core", ISBN="9831234567890" });
            bookList.Add(new Book() { Id = 2, Author = "Doe", Title = "C# Windows Forms", ISBN = "9831234345891" });
            bookList.Add(new Book() { Id = 3, Author = "Mike", Title = "C# Console App", ISBN = "9830988765678" });
            ViewData["books"] = bookList;

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBook(Book book)
        {
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);
            Console.WriteLine(book.ISBN);

            return RedirectToAction("Index");
        }

    }
}
