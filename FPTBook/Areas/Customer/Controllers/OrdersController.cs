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

namespace FPTBook.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize("RequireCustomer")]

    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IOrderRepository _orderRepository;


        public OrdersController(IOrderRepository orderRepository, ApplicationDbContext context)
        {
            _context = context;
            _orderRepository = orderRepository;
        }

        public async Task<IActionResult> Index()
        {
            var result =  await _orderRepository.Orders();
            return View(result);
        }

        public async Task<IActionResult> Orders(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var orderDetails = await _orderRepository.OrderDetails(id);

             
            if (orderDetails == null)
            {
                return NotFound();
            }

            return View(orderDetails);
        }

       
      
    }
}
