using FPTBook.Models;
using FPTBook.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FPTBook.Repository.IRepository
{
    public interface ICategoryRepository
    {
        Task<CategoryModel> Category(string id);
        Task<List<CategoryModel>> Categories();
        Task<UserResponse> AddCategory(CategoryModel id);
    }
}
