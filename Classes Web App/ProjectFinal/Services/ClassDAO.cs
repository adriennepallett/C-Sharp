using System;
using ProjectFinal.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectFinal.Services
{
    public class ClassDAO
    {
        private List<ClassModel> classList;
        private List<ClassModel> majorList;
        private List<ClassModel> minorList;
        private List<ClassModel> geList;

        public ClassDAO()
        {
            classList = DataSet.classList;
            majorList = DataSet.majorList;
            minorList = DataSet.minorList;
            geList = DataSet.geList;
        }

        public void AddClass(ClassModel course)
        {
            classList.Add(course);
        }

        public List<ClassModel> GetAllClasses()
        {
            return classList;
        }

        public List<ClassModel> GetAllMJClasses() {
            return majorList;
        }

        public List<ClassModel> GetAllMNClasses() {
            return minorList;
        }

        public List<ClassModel> GetAllGEClasses()
        {
            return geList;
        }

        public ClassModel GetClassByID(int ID)
        {
            return classList.FirstOrDefault(course => course.ID == ID);
        }

        public void UpdateClass(ClassModel updatedCourse)
        {
            ClassModel existingCourse = classList.FirstOrDefault(course => course.ID == updatedCourse.ID);
            if (existingCourse != null)
            {
                existingCourse.Name = updatedCourse.Name;
                existingCourse.Number = updatedCourse.Number;
                existingCourse.Section = updatedCourse.Section;
                existingCourse.Grade = updatedCourse.Grade;
                existingCourse.Complete = updatedCourse.Complete;
                existingCourse.Notes = updatedCourse.Notes;
            }
            else
            {
                throw new InvalidOperationException("Class not found");
            }
        }

        public void DeleteCourse(int ID)
        {
            ClassModel courseToRemove = classList.FirstOrDefault(course => course.ID == ID);
            if (courseToRemove != null)
            {
                classList.Remove(courseToRemove);

                /* BUG0001: This doesnt fix the delete functionality either:
                    majorList.Remove(courseToRemove);
                    minorList.Remove(courseToRemove);
                    geList.Remove(courseToRemove);
                */

                ReassignIDs();
            }
            else
            {
                throw new InvalidOperationException("Class not found");
            }
        }

        private void ReassignIDs()
        {
            for (int i = 0; i < classList.Count; i++)
            {
                classList[i].ID = i + 1;
            }
        }
    }
}

