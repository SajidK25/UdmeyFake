using System;
using System.Collections.Generic;

namespace UdemyAPI.Core
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FulLPrice { get; set; }
        public tag Author { get; set; }
        public IList<CourseTag> Tags { get; set; }

        public object Include(string v)
        {
            throw new NotImplementedException();
        }
    }
}
