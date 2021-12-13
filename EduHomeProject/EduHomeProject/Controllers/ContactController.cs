using EduHomeProject.Data;
using EduHomeProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmContact model = new VmContact
            {
                Banners = _context.Banners.FirstOrDefault(b => b.Page == "Contact")
            };
            ViewBag.Session = HttpContext.Session.GetString("Attention");

            return View(model);

        }
    }
}
