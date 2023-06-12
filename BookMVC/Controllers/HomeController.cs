using BookMVC.Models;
using BookMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookMVC.Controllers;

public class HomeController : Controller
{
    private readonly List<Book> books;
    private readonly List<Author> authors;

    public HomeController()
    {
        this.books = Book.GetAllBooks().ToList();
        authors=Author.AllAuthors();
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult GetAllBooks()
    {
        BookAuthorViewModel model = new BookAuthorViewModel()
        {
            authors = authors,
            books = books
        };
        return View("BooksList", model);
    }

    public IActionResult GetBookById(int id)
    {
        Book? book = books.Find(x => x.Id == id);
       
        return View(book);
    }

    public IActionResult DeleteBook(int id)
    {
        books.Remove(books.FirstOrDefault(x => x.Id == id));
        return RedirectToAction("GetAllBooks");
    }
}
