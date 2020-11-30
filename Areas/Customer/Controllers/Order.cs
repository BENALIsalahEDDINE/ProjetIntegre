using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Shop4Yourself.Data;
using Shop4Yourself.Models;
using Shop4Yourself.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe;

namespace Shop4Yourself.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class Order : Controller
    {
        private readonly ApplicationDbContext _db;

        public Order(ApplicationDbContext db)
        {
            _db = db;
        }


        public async Task<IActionResult> Confirm(int id)
        {
            var claimsidentity = (ClaimsIdentity)User.Identity;
            var claim = claimsidentity.FindFirst(ClaimTypes.NameIdentifier);

            OrderdetailsViewModel ODVM = new OrderdetailsViewModel()
            {
                OrderHeader = await _db.OrderHeader.Include(o => o.ApplicationUser).FirstOrDefaultAsync(o => o.Id == id && o.UserId == claim.Value),
                OrderDetails = await _db.OrderDetail.Where(o => o.OrderId == id).ToListAsync()
            };

            return View(ODVM);
        }

    }
}
