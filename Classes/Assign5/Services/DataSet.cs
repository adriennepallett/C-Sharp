using System;
using Assign5.Models;

namespace Assign5.Services
{
	public class DataSet
	{
        public static List<ClassModel> classList = new List<ClassModel>
        {
            new ClassModel { ID = 1, Number = "CSIS1800", Name = "Intro to Comp Sci & IT", Complete = false},
            new ClassModel { ID = 2, Number = "CSIS2000", Name = "Intro to Database Sys", Complete = false},
            new ClassModel { ID = 3, Number = "CSIS2101", Name = "Fund of Programming", Complete = false},
            new ClassModel { ID = 4, Number = "CSIS3020", Name = "Web Programming", Complete = false},
            new ClassModel { ID = 5, Number = "CSIS3500", Name = "Networks & Data", Complete = false},
            new ClassModel { ID = 6, Number = "CSIS4010", Name = "Comp Security", Complete = false},
            new ClassModel { ID = 7, Number = "CSIS4311", Name = "Web Services", Complete = false},
            new ClassModel { ID = 8, Number = "TECH2020", Name = "Programming for Everyone", Complete = false},
            new ClassModel { ID = 9, Number = "COMM3900", Name = "Interactive Design", Complete = false},
            new ClassModel { ID = 10, Number = "ARTS4190", Name = "Graphic Design III", Complete = false}
        };

        public static int GetNextID()
        {
            return classList.Any() ? classList.Max(c => c.ID) + 1 : 1;
        }

	}
}