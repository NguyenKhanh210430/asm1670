using FPTBook.Data;
using FPTBook.Models;
using FPTBook.Repository.IRepository;
using FPTBook.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FPTBook.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderDetailRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserResponse> CreateOrder(OrderModel orderModel)
        {

            _context.Add(orderModel);
            await _context.SaveChangesAsync();
            return new UserResponse
            {
                IsSuccess = true,
            };
        }

        public async Task<OrderModel> Order(string id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(m => m.Id == id);
            return order;
        }

        public async Task<List<OrderDetailModel>> OrderDetails(string userId)
        {

            var store = await _context.Stores.SingleOrDefaultAsync(s => s.StoreOwnerId == userId);
            var OrderDetails = await _context.OrderDetails
                .Include(o => o.Book)
                .ThenInclude(book => book.Category)
                .Include(o => o.Order)
                .ThenInclude(order => order.User)
                .Where(o => o.Book.StoreID == store.Id)
                .ToListAsync();

            return OrderDetails;    
        }

        public async Task<UserResponse> Update(OrderModel orderModel)
        {
            _context.Update(orderModel);
            await _context.SaveChangesAsync();

            return new UserResponse { IsSuccess = true };
        }
    }
}
