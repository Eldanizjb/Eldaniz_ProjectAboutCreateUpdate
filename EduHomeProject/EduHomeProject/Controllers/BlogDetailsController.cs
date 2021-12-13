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
    public class BlogDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public BlogDetailsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmBlogDetails model = new VmBlogDetails
            {
                Blogs = _context.Blogs.Include("BlogCategory").Include("BlogUser").ToList(),
                Banners = _context.Banners.FirstOrDefault(b => b.Page == "BlogDetails"),
                BlogComments = _context.BlogComments.Include("Blog").ToList(),
                TagToBlogs = _context.TagToBlogs.Include("BlogTag").Include("Blog").ToList(),
                BlogCategories = _context.BlogCategories.ToList(),
                BlogTags = _context.BlogTags.ToList()
            };
            return View(model);

        }
    }
}
