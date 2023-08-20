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
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace FPTBook.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize("RequireCustomer")]

    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepos;
        private readonly ICartRepository _cartRepos;
        public HomeController(IBookRepository bookRepos, ICartRepository cartRepos)
        {
            _bookRepos = bookRepos;
            _cartRepos = cartRepos;
        }

        // GET: Customer/Home
        public async Task<IActionResult> Index()
        {
            var books = await _bookRepos.GetBooks();
            return View(books);
        }

        // GET: Customer/Home/Details/5
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
        public async Task<IActionResult> Search(string key)
        {

            var books = await _bookRepos.Search(key);
            ViewBag.SearchTerm = key;

            return View(books);
        }
        public async Task<IActionResult> AddToCart(string bookISBN)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var res = await _cartRepos.AddToCart(bookISBN, userId);
            TempData["SuccessAlert"] = res.Messsage;

            return RedirectToAction(nameof(Index));
        }
    }
}
