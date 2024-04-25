using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assign5.Models;
using Assign5.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assign5.Controllers
{
    public class ClassController : Controller
    {
        private ClassDAO classDAO = new ClassDAO();

        public IActionResult Index()
        {
            List<ClassModel> classList = classDAO.GetAllClasses();
            return View(classList);
        }

        public IActionResult Details(int ID)
        {
            ClassModel course = classDAO.GetClassByID(ID);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(ClassModel course)
        {
            course.ID = DataSet.GetNextID();
            classDAO.AddClass(course);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int ID)
        {
            ClassModel course = classDAO.GetClassByID(ID);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        [HttpPost]

        public IActionResult Edit(ClassModel updatedCourse)
        {
            classDAO.UpdateClass(updatedCourse);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int ID)
        {
            ClassModel course = classDAO.GetClassByID(ID);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        [HttpPost, ActionName("Delete")]

        public IActionResult DeleteConfirmed(int ID)
        {
            classDAO.DeleteCourse(ID);
            return RedirectToAction("Index");
        }
    }
}

