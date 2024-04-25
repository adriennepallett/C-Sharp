using System;
using System.ComponentModel;

namespace ProjectFinal.Models
{
    public class ClassModel
    {
        public int ID { get; set; }
        public string Section { get; set; }

        [DisplayName("Course Number")]
        public string Number { get; set; }

        [DisplayName("Course Name")]
        public string Name { get; set; }

        public bool Complete { get; set; }

        public string? Grade { get; set; }

        public string? Notes { get; set; }
    }
}


