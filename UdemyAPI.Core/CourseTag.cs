using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace UdemyAPI.Core
{
    public class CourseTag
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public IList<CourseTag> Courses { get; set; }
    }
}
