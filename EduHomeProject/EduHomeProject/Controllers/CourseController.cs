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
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmCourse model = new VmCourse
            {
                Banners = _context.Banners.FirstOrDefault(b => b.Page == "Course"),
                Cousres = _context.Cousres.Include("CousresUser").Include("CousresCategory").Include("Feature").ToList(),
                CousresComments = _context.CousresComments.Include("Cousres").ToList(),
                TagToCousres = _context.TagToCousres.Include("CousresTag").Include("Cousres").ToList()



            };
            ViewBag.Session = HttpContext.Session.GetString("Attention");

            return View(model);

        }
    }
}
