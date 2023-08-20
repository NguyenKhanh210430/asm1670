using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FPTBook.Data;
using FPTBook.Models;
using System.Security.Claims;
using FPTBook.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;

namespace FPTBook.Areas.StoreOwner.Controllers
{
    [Area("StoreOwner")]
    [Authorize("RequireStoreOwner")]
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IBookRepository _bookRepository;
        public BooksController(IBookRepository bookRepository, ApplicationDbContext context)
        {
            _context = context;
            _bookRepository = bookRepository;
        }

        // GET: StoreOwner/Books
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var books = await _bookRepository.GetBooksOfStore(userId);
            return View(books);
        }

        // GET: StoreOwner/Books/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookModel = await _bookRepository.GetBook(id);

            if (bookModel == null)
            {
                return NotFound();
            }

            return View(bookModel);
        }

        // GET: StoreOwner/Books/Create
        public IActionResult Create()
        {
            ViewData["CategoryName"] = _context.Categories.Select(c => c.Name).ToList();
            ViewData["StoreName"] = _context.Stores.Select(c => c.Name).ToList();
            return View();
        }

        // POST: StoreOwner/Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ISBN,Title,Cost,Author,CategoryName,ImageURL,Description")] BookModel bookModel)
        {
            var book = await _bookRepository.GetBook(bookModel.ISBN);
            if (book != null)
            {
                TempData["FailAlert"] = "book already exist";

                return RedirectToAction(nameof(Index));

            }
            if (ModelState.IsValid)
            {
                var category = _context.Categories.SingleOrDefault(c => c.Name == bookModel.CategoryName);
                bookModel.CategoryID = category.Id;
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var store = await _context.Stores.SingleOrDefaultAsync(s => s.StoreOwnerId == userId);
                bookModel.StoreID = store.Id;
                _context.Add(bookModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryName"] = _context.Categories.Select(c => c.Name).ToList();
            ViewData["StoreName"] = _context.Stores.Select(c => c.Name).ToList();
            return View(bookModel);
        }

        // GET: StoreOwner/Books/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookModel = await _context.Books.FindAsync(id);
            if (bookModel == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "Id", "Id", bookModel.CategoryID);
            ViewData["StoreID"] = new SelectList(_context.Stores, "Id", "Id", bookModel.StoreID);
            return View(bookModel);
        }

        // POST: StoreOwner/Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ISBN,Title,Cost,Author,CategoryID,ImageURL,Description,StoreID")] BookModel bookModel)
        {
            if (id != bookModel.ISBN)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {         
                        throw;                    
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "Id", "Id", bookModel.CategoryID);
            ViewData["StoreID"] = new SelectList(_context.Stores, "Id", "Id", bookModel.StoreID);
            return View(bookModel);
        }

        // GET: StoreOwner/Books/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookModel = await _context.Books
                .Include(b => b.Category)
                .Include(b => b.Store)
                .FirstOrDefaultAsync(m => m.ISBN == id);
            if (bookModel == null)
            {
                return NotFound();
            }

            return View(bookModel);
        }

        // POST: StoreOwner/Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string ISBN)
        {
            var bookModel = await _context.Books.FindAsync(ISBN);
            _context.Books.Remove(bookModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
