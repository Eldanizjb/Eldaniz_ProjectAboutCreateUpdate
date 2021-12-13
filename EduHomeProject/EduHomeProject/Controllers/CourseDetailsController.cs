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
    public class CourseDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public CourseDetailsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmCourseDetails model = new VmCourseDetails
            {
                Banners = _context.Banners.FirstOrDefault(b => b.Page == "CourseDetails"),
                Cousres = _context.Cousres.Include("CousresUser").Include("CousresCategory").Include("Feature").ToList(),
                CousresComments = _context.CousresComments.Include("Cousres").ToList(),
                TagToCousres = _context.TagToCousres.Include("CousresTag").Include("Cousres").ToList(),
                CousresCategories = _context.CousresCategories.ToList(),
                CousresTags = _context.CousresTags.ToList()

            };
            return View(model);

        }
    }
}
