using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProjectWithCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstProjectWithCore.Controllers
{
    public class LoginController : Controller
    {
        private readonly TestDbCoreDbContext _context;

        public LoginController(TestDbCoreDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(SinhVien model)
        {
            if (ModelState.IsValid)
            {
                var sinhVien = _context.SinhViens.SingleOrDefault(x => x.MaSV == model.MaSV && x.TenSv == model.TenSv);
                if (sinhVien != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(model);
          
        }
    }
}