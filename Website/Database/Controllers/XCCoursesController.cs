using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Database.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace Database.Controllers
{
    public class XCCoursesController : Controller
    {
        private NVXCTFData db = new NVXCTFData();

        //default view - list of courses and actions
        public ActionResult Index()
        {


            return View(db.Courses.ToList());
        }

        public ActionResult Details(int? id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int? id)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }

        public ActionResult Edit(int? id)
        {
            if (id == null /*|| _context.Courses == null*/)
            {
                return View();
            }

            return View();
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirmed(int? id)
        {
            //if (id != coursesModel.CourseId)
            //{
            //    return NotFound();
            //}

            if (ModelState.IsValid)
            {
                try
                {

                }
                catch (DbUpdateConcurrencyException)
                {
                    //if (!CoursesModelExists(coursesModel.CourseId))
                    //{
                    //    return NotFound();
                    //}
                    //else
                    //{
                    //    throw;
                    //}
                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public ActionResult Delete(int? id)
        {
            if (id == null /*|| _context.Courses == null*/)
            {
                return NotFound();
            }

            return View();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //if (_context.Courses == null)
            //{
            //    return Problem("Entity set 'DatabaseContext.CoursesModel'  is null.");
            //}

            return RedirectToAction(nameof(Index));
        }

        //private bool CoursesModelExists(int id)
        //{
        //  return (_context.Courses?.Any(e => e.CourseId == id)).GetValueOrDefault();
        //}
    }
}
