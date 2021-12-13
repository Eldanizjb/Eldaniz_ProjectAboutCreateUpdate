using EduHomeProject.Data;
using EduHomeProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;



namespace EduHomeProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VmAbout model = new VmAbout
            {             
                Banners = _context.Banners.FirstOrDefault(b => b.Page == "About")
            };
            ViewBag.Session = HttpContext.Session.GetString("Attention");
            return View(model);


        }
    }
}
