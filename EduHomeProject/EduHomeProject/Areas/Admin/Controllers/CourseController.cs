using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EduHomeProject.Data;
using EduHomeProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CourseController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.Cousres.OrderByDescending(o => o.CreatedDate).Include(u => u.CousresUser)
                     .Include(c => c.CousresCategory)
                     .Include(tb => tb.TagToCousres).ThenInclude(t => t.CousresTag).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.CousresCategory = _context.CousresCategories.ToList();
            ViewBag.CousresTag = _context.CousresTags.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cousres model)
        {
            //return Content(model.MainImageFile.FileName + "-" + model.MainImageFile.ContentType + "-" + model.MainImageFile.Length);

            if (ModelState.IsValid)
            {
                if (model.MainImageFile.ContentType == "image/jpeg" || model.MainImageFile.ContentType == "image/png")
                {
                    if (model.MainImageFile.Length <= 2097152)
                    {

                        //Create course
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.MainImageFile.FileName;
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.MainImageFile.CopyTo(stream);
                        }

                        model.MainImage = fileName;
                        model.CreatedDate = DateTime.Now;
                        model.UserId = 2;
                        model.Featureİd = 1;

                        _context.Cousres.Add(model);
                        _context.SaveChanges();


                        //Create Tag to course
                        if (model.TagToCousreId != null && model.TagToCousreId.Count > 0)
                        {
                            foreach (var item in model.TagToCousreId)
                            {
                                TagToCousres tagToCousres = new TagToCousres();
                                tagToCousres.CousresTagId = item;
                                tagToCousres.CousresId = model.Id;
                                _context.TagToCousres.Add(tagToCousres);
                                _context.SaveChanges();
                            }
                        }

                        return RedirectToAction("Index");

                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only less than 2 mb.");
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                    return View(model);
                }
            }
            ViewBag.CousresCategory = _context.CousresCategories.ToList();
            ViewBag.CousresTag = _context.CousresTags.ToList();
            return View(model);
        }

        public IActionResult Update(int? id)
        {
            Cousres model = _context.Cousres.Include(tb => tb.TagToCousres).ThenInclude(t => t.CousresTag).FirstOrDefault(b => b.Id == id);
            model.TagToCousreId = _context.TagToCousres.Where(tb => tb.CousresId == id).Select(a => a.CousresTagId).ToList();
            ViewBag.CousresCategory = _context.CousresCategories.ToList();
            ViewBag.CousresTag = _context.CousresTags.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Cousres model)
        {
            if (ModelState.IsValid)
            {
                if (model.MainImageFile != null)
                {
                    if (model.MainImageFile.ContentType == "image/jpeg" || model.MainImageFile.ContentType == "image/png")
                    {
                        if (model.MainImageFile.Length <= 2097152)
                        {
                            //Delete old image
                            if (!string.IsNullOrEmpty(model.MainImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.MainImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }

                            //Create new image
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.MainImageFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.MainImageFile.CopyTo(stream);
                            }

                            model.MainImage = fileName;
                        }
                        else
                        {
                            ModelState.AddModelError("", "You can upload only less than 2 mb.");
                            ViewBag.CousresCategory = _context.CousresCategories.ToList();
                            ViewBag.CousresTag = _context.CousresTags.ToList();
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                        ViewBag.CousresCategory = _context.CousresCategories.ToList();
                        ViewBag.CousresTag = _context.CousresTags.ToList();
                        return View(model);
                    }
                }


                _context.Cousres.Update(model);
                _context.SaveChanges();

                //Delete old data
                List<TagToCousres> tagToCousres = _context.TagToCousres.Where(tb => tb.CousresId == model.Id).ToList();
                foreach (var item in tagToCousres)
                {
                    _context.TagToCousres.Remove(item);
                }
                _context.SaveChanges();

                //Create new Tag to blog
                if (model.TagToCousreId != null && model.TagToCousreId.Count > 0)
                {
                    foreach (var item in model.TagToCousreId)
                    {
                        TagToCousres tagToCousre = new TagToCousres();
                        tagToCousre.CousresTagId = item;
                        tagToCousre.CousresId = model.Id;
                        _context.TagToCousres.Add(tagToCousre);
                    }

                    _context.SaveChanges();
                }
                return RedirectToAction("Index");

            }

            ViewBag.CousresCategory = _context.CousresCategories.ToList();
            ViewBag.CousresTag = _context.CousresTags.ToList();
            return View(model);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                ///
            }

            Cousres cours = _context.Cousres.Find(id);

            if (cours == null)
            {
                ///
            }


            //Delete old image
            if (!string.IsNullOrEmpty(cours.MainImage))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", cours.MainImage);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            //List<TagToBlog> tagToBlogs = _context.TagToBlogs.Where(t=>t.BlogId==id).ToList();
            //foreach (var item in tagToBlogs)
            //{
            //    _context.TagToBlogs.Remove(item);
            //}
            //_context.SaveChanges();

            _context.Cousres.Remove(cours);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
