using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPTBook.Models
{
    public class OrderModel
    {
        public string Id { get; set; }

        public string UserID { get; set; }
        public AppUserModel User { get; set; }  
        public double Total { get; set; }
        public DateTime Date { get; set; }
         
        public List<OrderDetailModel> OrderDetails { get; set; }
    }
}
