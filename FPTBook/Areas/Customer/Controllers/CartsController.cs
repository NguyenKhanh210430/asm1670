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

namespace FPTBook.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize("RequireCustomer")]

    public class CartsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICartRepository _cartRepos;
        public CartsController(ICartRepository cartRepository, ApplicationDbContext context)
        {
            _context = context;
            _cartRepos = cartRepository;
        }

        // GET: Customer/Carts
        public async Task<IActionResult> Index()
        {
            var result = await _cartRepos.Carts();
       
            return View(result);
        }

        
         public async Task<IActionResult> QuantityUpdate(string id, int quantity)
         {

            await _cartRepos.UpdateCartQuantity(id, quantity);

            return RedirectToAction(nameof(Index));
         }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            await _cartRepos.RemoveCart(id);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> CheckOut()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var res = await _cartRepos.CheckOut(userId);
            TempData["SuccessAlert"] = res.Messsage;
            return RedirectToAction(nameof(Index));

        }

    }
}
