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
using Microsoft.AspNetCore.Authorization;

namespace FPTBook.Areas.StoreOwner.Controllers
{
    [Area("StoreOwner")]
    [Authorize("RequireStoreOwner")]

    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository, ApplicationDbContext context)
        {
            _context = context;
            _categoryRepository = categoryRepository;
        }

        // GET: StoreOwner/Categories
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryRepository.Categories();
            return View(categories);
        }

        // GET: StoreOwner/Categories/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = await _categoryRepository.Category(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: StoreOwner/Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StoreOwner/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] CategoryModel categoryModel)
        {
            if (ModelState.IsValid)
            {
                var category = await _categoryRepository.AddCategory(categoryModel);           
                if(category.IsSuccess == false){
                    TempData["SuccessAlert"] = "Requested";
                }
                return RedirectToAction(nameof(Index));
            }
            return View(categoryModel);
        }

     
    }
}
