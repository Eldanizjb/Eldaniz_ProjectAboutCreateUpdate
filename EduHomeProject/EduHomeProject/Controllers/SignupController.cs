using EduHomeProject.Data;
using EduHomeProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Controllers
{
    public class SignupController : Controller
    {
        private readonly AppDbContext _context;

        public SignupController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmSignup model = new VmSignup
            {
                Banners = _context.Banners.FirstOrDefault(b => b.Page == "Signup")
            };
            return View(model);
        }
    }
}
