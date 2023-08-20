using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FPTBook.Data;
using FPTBook.Models;
using FPTBook.Repository.IRepository;

namespace FPTBook.Areas.Unauthenticated.Controllers
{
    [Area("Unauthenticated")]
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepos;
        public HomeController(IBookRepository bookRepos, ICartRepository cartRepos)
        {
            _bookRepos = bookRepos;
        }

        // GET: Unauthenticated/Home
        public async Task<IActionResult> Index()
        {
            var books = await _bookRepos.GetBooks();
            return View(books);
        }

        // GET: Unauthenticated/Home/Details/5
        public async Task<IActionResult> Details(string ISBN)
        {
            if (ISBN == null)
            {
                return NotFound();
            }

            var book = await _bookRepos.GetBook(ISBN);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

       
    }
}
