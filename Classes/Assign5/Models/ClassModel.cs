using System;
using System.ComponentModel;

namespace Assign5.Models
{
	public class ClassModel
	{
		public int ID { get; set; }

        [DisplayName("Course Number")]
        public string Number { get; set; }

        [DisplayName("Course Name")]
        public string Name { get; set; }

        public bool Complete { get; set; }
	}
}

