using System;
using ProjectFinal.Models;

namespace ProjectFinal.Services
{
    public class BlankDataSet
    {
        public static List<ClassModel> classList = new List<ClassModel>
        {
            new ClassModel { ID = 1, Section = "XX", Number = "XXXXXXXX", Name = "Xxxxxxxxxxxxxx", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 2, Section = "XX", Number = "XXXXXXXX", Name = "Xxxxxxxxxxxxxx", Complete = false, Grade = null, Notes = null}
        };

        public static List<ClassModel> majorList = new List<ClassModel>
        {
            new ClassModel { ID = 1, Section = "XX", Number = "XXXXXXXX", Name = "Xxxxxxxxxxxxxx", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 2, Section = "XX", Number = "XXXXXXXX", Name = "Xxxxxxxxxxxxxx", Complete = false, Grade = null, Notes = null}
        };

        public static List<ClassModel> minorList = new List<ClassModel>
        {
            new ClassModel { ID = 1, Section = "XX", Number = "XXXXXXXX", Name = "Xxxxxxxxxxxxxx", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 2, Section = "XX", Number = "XXXXXXXX", Name = "Xxxxxxxxxxxxxx", Complete = false, Grade = null, Notes = null}
        };

        public static List<ClassModel> geList = new List<ClassModel>
        {
            new ClassModel { ID = 1, Section = "XX", Number = "XXXXXXXX", Name = "Xxxxxxxxxxxxxx", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 2, Section = "XX", Number = "XXXXXXXX", Name = "Xxxxxxxxxxxxxx", Complete = false, Grade = null, Notes = null}
        };

        public static int GetNextID()
        {
            return classList.Any() ? classList.Max(c => c.ID) + 1 : 1;
        }

    }
}