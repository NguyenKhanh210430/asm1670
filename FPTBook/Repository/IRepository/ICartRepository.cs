using FPTBook.Models;
using FPTBook.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FPTBook.Repository.IRepository
{
    public interface ICartRepository
    {
        Task<UserResponse> AddToCart(string bookISBN,string userId);
        Task<UserResponse> CheckOut(string userId);
        Task<List<CartModel>> Carts();
        Task<UserResponse> UpdateCartQuantity(string id,int quantity);
        Task<UserResponse>  RemoveCart(string id);

    }
}
