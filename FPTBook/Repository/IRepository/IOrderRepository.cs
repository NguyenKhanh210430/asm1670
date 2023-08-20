using FPTBook.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FPTBook.Repository.IRepository
{
    public interface IOrderRepository
    {
        Task<List<OrderModel>> Orders();
        Task<List<OrderDetailModel>> OrderDetails(string id);
    }
}
