using EduHomeProject.Data;
using EduHomeProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmTeacher model = new VmTeacher
            {
                Banners = _context.Banners.FirstOrDefault(b => b.Page == "Teacher"),
                Teachers = _context.Teachers.Include("İnformation").Include("Skill").Include("Sosial").ToList()

            };
            return View(model);
        }
    }
}
