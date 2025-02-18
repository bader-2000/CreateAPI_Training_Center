using System;
using System.Collections.Generic;

namespace LarningHub.Core.Data
{
    public partial class Course
    {
        public Course()
        {
            Stdcourses = new HashSet<Stdcourse>();
        }

        public decimal Courseid { get; set; }
        public string? Coursename { get; set; }
        public string? Imagename { get; set; }
        public decimal? Categoryid { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Stdcourse> Stdcourses { get; set; }
    }
}
