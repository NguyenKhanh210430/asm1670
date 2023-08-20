using FPTBook.Data;
using FPTBook.Models;
using FPTBook.Repository.IRepository;
using FPTBook.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FPTBook.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _context;

        public CartRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserResponse> AddToCart(string bookISBN, string userId)
        {

            var cart = await _context.Carts.SingleOrDefaultAsync(c => c.BookISBN == bookISBN);
            if(cart != null)
            {
                cart.Quantity +=  1;
                _context.Carts.Update(cart);
                _context.SaveChanges();
                return new UserResponse
                {
                    Messsage = "Updated Quantity",
                    IsSuccess = true,
                };
            }

            _context.Carts.Add(new CartModel
            {
                Id = Guid.NewGuid().ToString(),
                BookISBN = bookISBN,
                UserId = userId,
                Quantity = 1
                
            });
            await _context.SaveChangesAsync();

            return new UserResponse
            {
                Messsage = "Added To Cart",
                IsSuccess = true,
            };
        }

        public async Task<List<CartModel>> Carts()
        {
            var carts = await _context.Carts.Include(c => c.Book)
                            .Include(c => c.User)
                            .Include(c => c.Book.Category)
                            .ToListAsync();
            return carts;
        }

        public async Task<UserResponse> CheckOut(string userId)
        {
            var carts = _context.Carts.Where(c => c.UserId == userId).Include(c => c.Book).ToList();
            if(carts.Count == 0)
            {
                return new UserResponse
                {
                    Messsage = "Not thing in cart",
                    IsSuccess = false,
                };
            }

            double total = 0;
            foreach (var cart in carts)
            {
                total += cart.Quantity * cart.Book.Cost;
            }
            var newOrder = new OrderModel
            {
                Id = Guid.NewGuid().ToString(),
                UserID = userId,
                Total = total,
                Date = DateTime.Now,
            };

            _context.Orders.Add(newOrder);
            _context.SaveChanges();


            foreach (var cart2 in carts)
            {
                _context.OrderDetails.Add(new OrderDetailModel
                {
                    Id = Guid.NewGuid().ToString(),
                    OrderId = newOrder.Id,
                    BookISBN= cart2.BookISBN,
                    Quantity = cart2.Quantity
                });
            }
            _context.Carts.RemoveRange(carts);
            await _context.SaveChangesAsync();

            return new UserResponse
            {
                Messsage = "Checked Out ... Thank you !!!",
                IsSuccess = true,
            };
        }

        public async Task<UserResponse> RemoveCart(string id)
        {
            var cart = await _context.Carts.FirstOrDefaultAsync(m => m.Id == id);
            _context.Remove(cart);
            _context.SaveChanges();
            return new UserResponse
            {
                Messsage = "Removed !!!",
                IsSuccess = true,
            };
        }

        public async Task<UserResponse> UpdateCartQuantity(string id, int quantity)
        {

            var cart = await _context.Carts.SingleOrDefaultAsync(b => b.Id == id);
            cart.Quantity = quantity;
            _context.Update(cart);
            await _context.SaveChangesAsync();
            return new UserResponse
            {
                Messsage = "Updated !!!",
                IsSuccess = true,
            };  
        }
    }
}
