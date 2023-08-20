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

namespace FPTBook.Areas.StoreOwner.Controllers
{
    [Area("StoreOwner")]
    [Authorize("RequireStoreOwner")]

    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IOrderDetailRepository _orderDetailRepository;
        public OrdersController(IOrderDetailRepository orderDetailRepository , ApplicationDbContext context)
        {
            _context = context;
            _orderDetailRepository = orderDetailRepository;
        }

        // GET: StoreOwner/Orders
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var OrderDetails = await _orderDetailRepository.OrderDetails(userId);
            return View(OrderDetails);
        }

        // GET: StoreOwner/Orders/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Order = await _orderDetailRepository.Order(id);

         
            if (Order == null)
            {
                return NotFound();
            }

            return View(Order);
        }

        // GET: StoreOwner/Orders/Create
        public IActionResult Create()
        {
            return View();
        }

   
       
    }
}
