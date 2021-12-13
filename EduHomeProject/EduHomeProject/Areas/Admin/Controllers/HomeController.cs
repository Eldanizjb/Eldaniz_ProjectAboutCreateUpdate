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

namespace EduHomeProject.Areas.Admin.Controllers
{
    [Area("Admin")]
     public class HomeController : Controller
    {
            private readonly AppDbContext _context;

            public HomeController(AppDbContext context)
            {
                _context = context;
            }
            public IActionResult Index()
            {
                VmLayout model = new VmLayout()
                {
                  Settings = _context.Settings.FirstOrDefault()
                };

                return View(model);


            }
        
    }
}