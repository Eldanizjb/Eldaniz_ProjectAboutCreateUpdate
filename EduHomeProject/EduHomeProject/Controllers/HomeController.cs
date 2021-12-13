using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EduHomeProject.Data;
using EduHomeProject.Models;
using EduHomeProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace EduHomeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmPage model = new VmPage
            {
                SliderBanners = _context.SliderBanners.Take(3).ToList(),
                BlogComments = _context.BlogComments.OrderByDescending(p => p.CreateDate).Take(4).ToList(),
                Cousres = _context.Cousres.ToList(),
                SliderTeachers = _context.SliderTeachers.Take(3).ToList(),
                CousresComments = _context.CousresComments.OrderByDescending(p => p.CreateDate).Take(3).ToList(),
                Blogs = _context.Blogs.ToList(),
                Events = _context.Events.OrderByDescending(p => p.CreateDate).Take(4).ToList(),
                Subscribes = _context.Subscribes.ToList(),
                Setting = _context.Settings.FirstOrDefault()
            };

            HttpContext.Session.SetString("Attention", "One month left to complete the course");
            return View(model);
           

        }
    }
}
