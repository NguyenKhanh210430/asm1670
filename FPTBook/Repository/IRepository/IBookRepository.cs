using FPTBook.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FPTBook.Repository.IRepository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetBooks();
        Task<BookModel> GetBook(string id);
        Task<List<BookModel>> Search(string key);
        Task<List<BookModel>> GetBooksOfStore(string userId);
    }
}
