using FPTBook.Data;
using FPTBook.Models;
using FPTBook.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FPTBook.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<BookModel> GetBook(string id)
        {
            var book =  await _context.Books
               .Include(b => b.Category)
               .Include(b => b.Store)
               .FirstOrDefaultAsync(m => m.ISBN == id);
            return book;
        }

        public async Task<List<BookModel>>  GetBooks()
        {
            var books =  await _context.Books.Include(b => b.Category).Include(b => b.Store).ToListAsync();
            return books;
        }

        public async Task<List<BookModel>> GetBooksOfStore(string userId)
        {

            var store = await _context.Stores.SingleOrDefaultAsync(s => s.StoreOwnerId == userId);
            var books = await _context.Books
                .Where(b => b.StoreID == store.Id)
                .Include(b => b.Category)
                .Include(b => b.Store).ToListAsync();
            return books;
        }

        public async Task<List<BookModel>> Search(string key)
        {
            var results = await _context.Books.Where(p => p.Title.Contains(key)).ToListAsync();
            return results;
        }
    }
}
