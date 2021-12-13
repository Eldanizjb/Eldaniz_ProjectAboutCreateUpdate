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
    
    public class EventDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public EventDetailsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmEventDetails model = new VmEventDetails
            {
                Banners = _context.Banners.FirstOrDefault(b => b.Page == "EventDetails"),
                Events = _context.Events.Include("EventCategories").Include("EventUsers").ToList(),
                EventComments = _context.EventComments.Include("Events").ToList(),
                TagToEvents = _context.TagToEvents.Include("EventTags").Include("Events").ToList(),
                EventCategories = _context.EventCategories.ToList(),
                EventTags = _context.EventTags.ToList()
            };
            return View(model);
        }
    }

}
