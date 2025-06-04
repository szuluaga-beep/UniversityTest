﻿using System.Diagnostics;

namespace University.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public required Course Course { get; set; }
        public required Student Student { get; set; }
    }
}
