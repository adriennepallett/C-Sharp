using System;
using ProjectFinal.Models;

namespace ProjectFinal.Services
{
    public class DataSet
    {
        public static List<ClassModel> classList = new List<ClassModel>
        {
            new ClassModel { ID = 1, Section = "MJ", Number = "ARTS1200", Name = "Intro to Drawing", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 2, Section = "MJ", Number = "ARTS1700", Name = "Fundamentals of Color", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 3, Section = "MJ", Number = "ARTS1800", Name = "Two-Dimensional Design", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 4, Section = "MJ", Number = "ARTS2200", Name = "Digital Photography", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 5, Section = "MJ", Number = "ARTS2050", Name = "Art History I", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 6, Section = "MJ", Number = "ARTS3050", Name = "Art History II", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 7, Section = "MJ", Number = "ARTS4950", Name = "Internship", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 8, Section = "MJ", Number = "ARTS4995", Name = "Senior Project", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 9, Section = "MJ", Number = "ARTS2190", Name = "Intro to Graphic Design", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 10, Section = "MJ", Number = "ARTS3190", Name = "Idea Visualization", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 11, Section = "MJ", Number = "ARTS3650", Name = "Typography", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 12, Section = "MJ", Number = "ARTS4190", Name = "Advanced Princ. of Graphic Design", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 13, Section = "MN", Number = "ARTS2600", Name = "Intro to Arts Administration", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 14, Section = "MN", Number = "ARTS3200", Name = "Digital Photographic Design", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 15, Section = "MN", Number = "ARTS4900", Name = "Special Topic in the Arts", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 16, Section = "MN", Number = "COMM3900", Name = "Web, Mobile & Interactive Design", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 17, Section = "GE", Number = "COMP1500", Name = "Intro to College Writing", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 18, Section = "GE", Number = "COMP2000", Name = "Advanced College Composition", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 20, Section = "GE", Number = "MATH1040", Name = "College Algebra", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 21, Section = "GE", Number = "MATH1020", Name = "Applied Statistics", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 22, Section = "GE", Number = "MBIO1220", Name = "Intro to Marine Biology", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 23, Section = "GE", Number = "CHEM1310", Name = "General Chemistry I", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 24, Section = "GE", Number = "PSYC1020", Name = "Intro to Psychology", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 25, Section = "GE", Number = "SOCL1020", Name = "Intro to Sociology", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 26, Section = "GE", Number = "SPAN1210", Name = "Elementary Spanish", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 27, Section = "GE", Number = "THEA1000", Name = "Theater I", Complete = false, Grade = null, Notes = null}
        };

        public static List<ClassModel> majorList = new List<ClassModel>
        {
            new ClassModel { ID = 1, Section = "MJ", Number = "ARTS1200", Name = "Intro to Drawing", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 2, Section = "MJ", Number = "ARTS1700", Name = "Fundamentals of Color", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 3, Section = "MJ", Number = "ARTS1800", Name = "Two-Dimensional Design", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 4, Section = "MJ", Number = "ARTS2200", Name = "Digital Photography", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 5, Section = "MJ", Number = "ARTS2050", Name = "Art History I", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 6, Section = "MJ", Number = "ARTS3050", Name = "Art History II", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 7, Section = "MJ", Number = "ARTS4950", Name = "Internship", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 8, Section = "MJ", Number = "ARTS4995", Name = "Senior Project", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 9, Section = "MJ", Number = "ARTS2190", Name = "Intro to Graphic Design", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 10, Section = "MJ", Number = "ARTS3190", Name = "Idea Visualization", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 11, Section = "MJ", Number = "ARTS3650", Name = "Typography", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 12, Section = "MJ", Number = "ARTS4190", Name = "Advanced Princ. of Graphic Design", Complete = false, Grade = null, Notes = null}
        };

        public static List<ClassModel> minorList = new List<ClassModel>
        {
            new ClassModel { ID = 13, Section = "MN", Number = "ARTS2600", Name = "Intro to Arts Administration", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 14, Section = "MN", Number = "ARTS3200", Name = "Digital Photographic Design", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 15, Section = "MN", Number = "ARTS4900", Name = "Special Topic in the Arts", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 16, Section = "MN", Number = "COMM3900", Name = "Web, Mobile & Interactive Design", Complete = false, Grade = null, Notes = null}
        };

        public static List<ClassModel> geList = new List<ClassModel>
        {
            new ClassModel { ID = 17, Section = "GE", Number = "COMP1500", Name = "Intro to College Writing", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 18, Section = "GE", Number = "COMP2000", Name = "Advanced College Composition", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 20, Section = "GE", Number = "MATH1040", Name = "College Algebra", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 21, Section = "GE", Number = "MATH1020", Name = "Applied Statistics", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 22, Section = "GE", Number = "MBIO1220", Name = "Intro to Marine Biology", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 23, Section = "GE", Number = "CHEM1310", Name = "General Chemistry I", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 24, Section = "GE", Number = "PSYC1020", Name = "Intro to Psychology", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 25, Section = "GE", Number = "SOCL1020", Name = "Intro to Sociology", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 26, Section = "GE", Number = "SPAN1210", Name = "Elementary Spanish", Complete = false, Grade = null, Notes = null},
            new ClassModel { ID = 27, Section = "GE", Number = "THEA1000", Name = "Theater I", Complete = false, Grade = null, Notes = null}
        };

        public static int GetNextID()
        {
            return classList.Any() ? classList.Max(c => c.ID) + 1 : 1;
        }

    }
}