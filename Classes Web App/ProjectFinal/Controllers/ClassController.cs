using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ProjectFinal.Models;
using ProjectFinal.Services;


/* BUG0002: Because I am not able to successfully setup a database with the course records to help maintain state,
          Any information entered within this system will maintain only while the window is active.
*/

namespace ProjectFinal.Controllers
{
    public class ClassController : Controller
    {
        private ClassDAO classDAO = new ClassDAO();

        public IActionResult Index()
        {
            ViewBag.IsAuthenticated = true;
            List<ClassModel> classList = classDAO.GetAllClasses();
            return View(classList);
        }

        public IActionResult Major()
        {
            ViewBag.IsAuthenticated = true;
            List<ClassModel> majorList = classDAO.GetAllMJClasses();
            return View(majorList);
        }

        public IActionResult Minor()
        {
            ViewBag.IsAuthenticated = true;
            List<ClassModel> minorList = classDAO.GetAllMNClasses();
            return View(minorList);
        }

        public IActionResult GeneralEducation()
        {
            ViewBag.IsAuthenticated = true;
            List<ClassModel> geList = classDAO.GetAllGEClasses();
            return View(geList);
        }

        public IActionResult Details(int ID)
        {
            ViewBag.IsAuthenticated = true;
            ClassModel course = classDAO.GetClassByID(ID);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        public IActionResult Create()
        {
            ViewBag.IsAuthenticated = true;
            return View();
        }

        [HttpPost]

        public IActionResult Create(ClassModel course)
        {
            ViewBag.IsAuthenticated = true;
            course.ID = DataSet.GetNextID();
            classDAO.AddClass(course);

            if (course.Section == "MJ")
            {
                DataSet.majorList.Add(course);
            }
            else if (course.Section == "MN")
            {
                DataSet.minorList.Add(course);
            }
            else if (course.Section == "GE")
            {
                DataSet.geList.Add(course);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int ID)
        {
            ViewBag.IsAuthenticated = true;
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
            ViewBag.IsAuthenticated = true;

            ClassModel oClass = classDAO.GetClassByID(updatedCourse.ID);

            //BUG0001: Can only edit Section once

            if (oClass != null)
            {
                if (oClass.Section == "MJ")
                {
                    DataSet.majorList.Remove(oClass);
                }
                else if (oClass.Section == "MN")
                {
                    DataSet.minorList.Remove(oClass);
                }
                if (oClass.Section == "GE")
                {
                    DataSet.geList.Remove(oClass);
                }
            }

            classDAO.UpdateClass(updatedCourse);

            if (updatedCourse.Section == "MJ")
            {
                DataSet.majorList.Add(updatedCourse);
            }
            else if(updatedCourse.Section =="MN")
            {
                DataSet.minorList.Add(updatedCourse);
            }
            else if (updatedCourse.Section == "GE")
            {
                DataSet.geList.Add(updatedCourse);
            }
            
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int ID)
        {
            ViewBag.IsAuthenticated = true;
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
            ViewBag.IsAuthenticated = true;
            classDAO.DeleteCourse(ID);

            /* BUG0001: once it gets deleted, it remains in the list view but has no details.
                This didnt fix it:
                    Response.Headers.Add("Cache-Control", "no-cache, no-store, must-revalidate");
                    Response.Headers.Add("Pragma", "no-cache");
                    Response.Headers.Add("Expires", "0");
            */

            return RedirectToAction("Index");
        }
    }
}