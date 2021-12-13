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
    public class EventController : Controller
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmEvent model = new VmEvent
            {
                Banners = _context.Banners.FirstOrDefault(b => b.Page == "Event"),
                Events = _context.Events.Include("EventUser").Include("EventCategory").ToList(),
                EventComments = _context.EventComments.Include("Events").ToList(),
                TagToEvents = _context.TagToEvents.Include("EventsTag").Include("Events").ToList()



            };
            ViewBag.Session = HttpContext.Session.GetString("Attention");

            return View(model);

        }
    }
}
