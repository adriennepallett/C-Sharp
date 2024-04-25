using System;
using Assign5.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assign5.Services
{
	public class ClassDAO
	{
		private List<ClassModel> classList;

		public ClassDAO()
		{
			classList = DataSet.classList;
		}

		public void AddClass(ClassModel course)
		{
			classList.Add(course);
		}

		public List<ClassModel> GetAllClasses()
		{
			return classList;
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
				existingCourse.Complete = updatedCourse.Complete;
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

