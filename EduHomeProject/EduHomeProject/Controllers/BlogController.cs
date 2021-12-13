using EduHomeProject.Data;
using EduHomeProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmBlog model = new VmBlog
            {
                Blogs = _context.Blogs.Include("BlogCategory").Include("BlogUser").ToList(),
                Banners = _context.Banners.FirstOrDefault(b => b.Page == "Blog"),
                BlogComments = _context.BlogComments.Include("Blog").ToList(),
                TagToBlogs = _context.TagToBlogs.Include("BlogTag").Include("Blog").ToList()
             };
            ViewBag.Session = HttpContext.Session.GetString("Attention");

            return View(model);

        }
    }
}
