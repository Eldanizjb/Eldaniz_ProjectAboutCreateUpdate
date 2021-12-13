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
    public class TeacherDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public TeacherDetailsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmTeacherDetails model = new VmTeacherDetails
            {
                Banners = _context.Banners.FirstOrDefault(b => b.Page == "TeacherDetails"),
                Teachers = _context.Teachers.Include("İnformation").Include("Skill").Include("Sosial").ToList()

            };
            return View(model);
        }
    }
}
