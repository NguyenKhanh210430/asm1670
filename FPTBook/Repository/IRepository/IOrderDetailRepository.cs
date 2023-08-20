using FPTBook.Models;
using FPTBook.ViewModel;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FPTBook.Repository.IRepository
{
    public interface IOrderDetailRepository
    {
        Task<List<OrderDetailModel>> OrderDetails(string userId);
        Task<OrderModel> Order(string id);
        Task<UserResponse> CreateOrder(OrderModel orderModel);

         Task<UserResponse> Update(OrderModel orderModel);

    }
}
