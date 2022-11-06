using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mrinmoy.Models.CSV
{
    public class Student
    {
        public string? Name { get; set; }
        public string? ApplicationFormNo { get; set; }
        public string? FacultyOfStudy { get; set; }
        public string? DateOfBirth { get; set; }

        public List<Qualification> Qualifications { get; set; }
        public List<string> LabPreferences { get; set; }
        public List<string> Fellowships { get; set; }
    }
}
