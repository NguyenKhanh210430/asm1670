using FPTBook.Data;
using FPTBook.Models;
using FPTBook.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FPTBook.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<OrderDetailModel>> OrderDetails(string id)
        {
            var orderDetails = await _context.OrderDetails.Where(o => o.OrderId == id).Include(o => o.Book).ToListAsync();
            return orderDetails;
        }

        public async Task<List<OrderModel>> Orders()
        {
            var orders = await _context.Orders.ToListAsync();
            return orders;
        }

    }
}
