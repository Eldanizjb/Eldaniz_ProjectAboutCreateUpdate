using EduHomeProject.Data;
using EduHomeProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmLogin model = new VmLogin
            {
                Banners = _context.Banners.FirstOrDefault(b => b.Page == "Login")
            };
            return View(model);
        }
    }
}
