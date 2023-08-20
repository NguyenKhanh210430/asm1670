using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPTBook.Models
{
    public class AppUserModel : IdentityUser<string>
    {
        public string FullName { get; set; }


        public List<CartModel> Carts { get; set; }
        public List<OrderModel> Orders { get; set; }

        public StoreModel Store { get; set; }
        public string Address { get; set; }
    }
}
