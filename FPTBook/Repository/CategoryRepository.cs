using FPTBook.Data;
using FPTBook.Models;
using FPTBook.Repository.IRepository;
using FPTBook.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FPTBook.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserResponse> AddCategory(CategoryModel model)
        {
            model.IsApprove = false;
            model.Id = Guid.NewGuid().ToString();
            _context.Add(model);
            await _context.SaveChangesAsync();
            return new UserResponse
            {
                IsSuccess = true,
                Messsage= "Added",
            };
        }

        public async Task<List<CategoryModel>> Categories()
        {
            var result = await _context.Categories.Where(c => c.IsApprove == true).ToListAsync();
            return result;
        }

        public async Task<CategoryModel> Category(string id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(m => m.Id == id);
            return category;
        }
    }
}
