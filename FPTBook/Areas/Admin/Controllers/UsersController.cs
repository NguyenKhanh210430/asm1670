using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FPTBook.Data;
using FPTBook.Models;
using Microsoft.AspNetCore.Identity;
using FPTBook.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace FPTBook.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize("RequireAdmin")]

    public class UsersController : Controller
    {
        private readonly RoleManager<RoleModel> _roleManager;
        private readonly UserManager<AppUserModel> _userManager;
        public UsersController(RoleManager<RoleModel> roleManager, UserManager<AppUserModel> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        // GET: Admin/Users
        public async Task<IActionResult> Customers()
        {
            var role = await _roleManager.FindByNameAsync("Customer");
            var usersInRole = await _userManager.GetUsersInRoleAsync(role.Name);

            return View(usersInRole);
        }
        public async Task<IActionResult> StoreOwners()
        {
            var role = await _roleManager.FindByNameAsync("StoreOwner");
            var usersInRole = await _userManager.GetUsersInRoleAsync(role.Name);

            return View(usersInRole);
        }
        
        public  IActionResult CustomerResetPassword(string id)
        {

            var result = new ResetPasswordVM
            {
                Id = id,
            };
            return View(result);
        }
        public IActionResult StoreOwnerResetPassword(string id)
        {
            var result = new ResetPasswordVM
            {
                Id = id,
            };
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> CustomerResetPassword(ResetPasswordVM model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, model.Password);
            if (result.Succeeded)
            {
                TempData["SuccessAlert"] = "Changed";

            }
            else
            {
                TempData["FailAlert"] = "Password required 1 character and 1 uppercase";
            }

            return RedirectToAction(nameof(Customers));
        }

        [HttpPost]
        public async Task<IActionResult> StoreOwnerResetPassword(ResetPasswordVM model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, model.Password);
            if (result.Succeeded)
            {
                TempData["SuccessAlert"] = "Changed";

            }
            else
            {
                TempData["FailAlert"] = "Password required 1 character and 1 uppercase";
            }

            return RedirectToAction(nameof(StoreOwners));
        }
    }
}
